using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LB.Controls;
using System.IO.Ports;
using LB.Common;
using LB.WinFunction;

namespace LB.SysConfig.SysConfig
{
    public partial class frmWeightDecive : LBUIPageBase
    {
        private SerialPort _comm = new SerialPort();
        public frmWeightDecive()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitComboxDataSource();

            this.txtWeightDeviceType.SelectedValueChanged += TxtWeightDeviceType_SelectedValueChanged;

            //初始化串口信息
            InitSerialData();

            //读取本机对应的串口信息
            LoadMathineSerialInfo();

            _comm.RtsEnable = true;//根据实际情况吧。
            _comm.DataReceived += _comm_DataReceived;

            this.FormClosing += FrmWeightDecive_FormClosing;
        }

        private void FrmWeightDecive_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //页面关闭前先检查串口是否已关闭，如果否则强制关闭
                if (_comm.IsOpen)
                {
                    _comm.Close();
                    _comm.Dispose();
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void _comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (!_comm.IsOpen)
                    return;

                int iDataLength = 0;
                int iStartBit = 0;
                int iDataType = 0;

                txtDeviceShuJuWei.Invoke((EventHandler)(delegate
                {
                    iDataLength = LBConverter.ToInt32(txtDeviceShuJuWei.SelectedValue);
                }));
                txtDeviceZhenQiShiBiaoShi.Invoke((EventHandler)(delegate
                {
                    iStartBit = LBConverter.ToInt32(txtDeviceZhenQiShiBiaoShi.SelectedValue);
                }));
                txtDeviceZhenChuLiFangShi.Invoke((EventHandler)(delegate
                {
                    iDataType = LBConverter.ToInt32(txtDeviceZhenChuLiFangShi.SelectedValue);
                }));


                int n = _comm.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
                byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据

                _comm.Read(buf, 0, n);//读取缓冲数据
                if (buf.Length == iDataLength)//如果接受的数据长度大于设定的数据位长度
                {
                    byte[] bcatch_data = new byte[buf.Length - iStartBit];
                    for(int i= iStartBit;i< buf.Length; i++)
                    {
                        bcatch_data[i - iStartBit] = buf[i];
                    }
                    //buf.CopyTo(bcatch_data, iStartBit);

                    lblWeight.Invoke((EventHandler)(delegate
                    {
                        string strValue = "";
                        if (iDataType == 0)//ASCII
                        {
                            strValue = Encoding.ASCII.GetString(bcatch_data);
                        }

                        int iValue = 0;
                        int.TryParse(strValue, out iValue);
                        this.lblWeight.Text = iValue.ToString();
                    }));
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void TxtWeightDeviceType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int iWeightDeviceType = LBConverter.ToInt32(this.txtWeightDeviceType.SelectedValue);
                if (iWeightDeviceType > 0)
                {
                    LoadSerialData(iWeightDeviceType);
                }
                SetTextBoxEnable();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        #region-- 初始化串口数据 --

        private void InitSerialData()
        {
            DataTable dtPort = new DataTable();
            dtPort.Columns.Add("PortName", typeof(string));

            string[] ArryPort = SerialPort.GetPortNames();
            for (int i = 0; i < ArryPort.Length; i++)
            {
                DataRow drNew = dtPort.NewRow();
                drNew["PortName"] = ArryPort[i];
                dtPort.Rows.Add(drNew);
            }
            this.txtSerialName.DataSource = dtPort.DefaultView;
            this.txtSerialName.DisplayMember = "PortName";
            this.txtSerialName.ValueMember = "PortName";
            if (ArryPort.Length>0)
                this.txtSerialName.SelectedIndex = 0;
        }

        #endregion

        #region -- 初始化控件数据源 --

        private void InitComboxDataSource()
        {
            this.txtWeightDeviceType.DataSource = LB.Common.LBConst.GetConstData("WeightDeviceType");
            this.txtWeightDeviceType.DisplayMember = "ConstText";
            this.txtWeightDeviceType.ValueMember = "ConstValue";

            this.txtDeviceZhenChuLiFangShi.DataSource = LB.Common.LBConst.GetConstData("DeviceFrameType");//帧处理方式
            this.txtDeviceZhenChuLiFangShi.DisplayMember = "ConstText";
            this.txtDeviceZhenChuLiFangShi.ValueMember = "ConstValue";
            this.txtDeviceZhenChuLiFangShi.SelectedValue = 0;

            DataTable dtData = new DataTable();
            dtData.Columns.Add("ConstValue", typeof(int));
            for(int i=0; i < 15; i++)
            {
                DataRow dr = dtData.NewRow();
                dr["ConstValue"] = i;
                dtData.Rows.Add(dr);
            }
            dtData.AcceptChanges();

            this.txtDeviceChongFuChangDu.DataSource = dtData.Copy();
            this.txtDeviceChongFuChangDu.DisplayMember = "ConstValue";
            this.txtDeviceChongFuChangDu.ValueMember = "ConstValue";
            this.txtDeviceChongFuChangDu.SelectedValue = 6;

            this.txtDeviceChongFuWeiZhi.DataSource = dtData.Copy();
            this.txtDeviceChongFuWeiZhi.DisplayMember = "ConstValue";
            this.txtDeviceChongFuWeiZhi.ValueMember = "ConstValue";
            this.txtDeviceChongFuWeiZhi.SelectedValue = 3;

            this.txtDeviceShuJuWei.DataSource = dtData.Copy();
            this.txtDeviceShuJuWei.DisplayMember = "ConstValue";
            this.txtDeviceShuJuWei.ValueMember = "ConstValue";
            this.txtDeviceShuJuWei.SelectedValue = 8;

            this.txtDeviceTingZhiWei.DataSource = dtData;
            this.txtDeviceTingZhiWei.DisplayMember = "ConstValue";
            this.txtDeviceTingZhiWei.ValueMember = "ConstValue";
            this.txtDeviceTingZhiWei.SelectedValue = 1;

            this.txtDeviceZhenChangDu.DataSource = dtData.Copy();
            this.txtDeviceZhenChangDu.DisplayMember = "ConstValue";
            this.txtDeviceZhenChangDu.ValueMember = "ConstValue";
            this.txtDeviceZhenChangDu.SelectedValue = 12;

            this.txtDeviceZhenQiShiBiaoShi.DataSource = dtData.Copy();
            this.txtDeviceZhenQiShiBiaoShi.DisplayMember = "ConstValue";
            this.txtDeviceZhenQiShiBiaoShi.ValueMember = "ConstValue";
            this.txtDeviceZhenQiShiBiaoShi.SelectedValue = 2;

            DataTable dtBTL = new DataTable();
            dtBTL.Columns.Add("ConstValue", typeof(int));
            DataRow drNew = dtBTL.NewRow();
            drNew["ConstValue"] = 1200;
            dtBTL.Rows.Add(drNew);
            drNew = dtBTL.NewRow();
            drNew["ConstValue"] = 2400;
            dtBTL.Rows.Add(drNew);
            drNew = dtBTL.NewRow();
            drNew["ConstValue"] = 4800;
            dtBTL.Rows.Add(drNew);
            drNew = dtBTL.NewRow();
            drNew["ConstValue"] = 9600;
            dtBTL.Rows.Add(drNew);
            this.txtDeviceBoTeLv.DataSource = dtBTL;
            this.txtDeviceBoTeLv.DisplayMember = "ConstValue";
            this.txtDeviceBoTeLv.ValueMember = "ConstValue";
            this.txtDeviceBoTeLv.SelectedValue = 4800;
        }

        #endregion -- 初始化控件数据源 --

        #region -- 按钮事件 --

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int iWeightDeviceType = LBConverter.ToInt32(this.txtWeightDeviceType.SelectedValue);
                string strSerialName = this.txtSerialName.SelectedValue==null?"": this.txtSerialName.SelectedValue.ToString().TrimEnd();
                int DeviceBoTeLv = LBConverter.ToInt32(this.txtDeviceBoTeLv.SelectedValue);
                int DeviceChongFuChangDu = LBConverter.ToInt32(this.txtDeviceChongFuChangDu.SelectedValue);
                int DeviceChongFuWeiZhi = LBConverter.ToInt32(this.txtDeviceChongFuWeiZhi.SelectedValue);
                int DeviceShuJuWei = LBConverter.ToInt32(this.txtDeviceShuJuWei.SelectedValue);
                int DeviceTingZhiWei = LBConverter.ToInt32(this.txtDeviceTingZhiWei.SelectedValue);
                int DeviceZhenChangDu = LBConverter.ToInt32(this.txtDeviceZhenChangDu.SelectedValue);
                int DeviceZhenChuLiFangShi = LBConverter.ToInt32(this.txtDeviceZhenChuLiFangShi.SelectedValue);
                int DeviceZhenQiShiBiaoShi = LBConverter.ToInt32(this.txtDeviceZhenQiShiBiaoShi.SelectedValue);

                LBDbParameterCollection parmCol = new LBDbParameterCollection();
                parmCol.Add(new LBParameter("WeightDeviceType", enLBDbType.Int32, iWeightDeviceType));
                parmCol.Add(new LBParameter("SerialName", enLBDbType.String, strSerialName));
                parmCol.Add(new LBParameter("DeviceBoTeLv", enLBDbType.Int32, DeviceBoTeLv));
                parmCol.Add(new LBParameter("DeviceChongFuChangDu", enLBDbType.Int32, DeviceChongFuChangDu));
                parmCol.Add(new LBParameter("DeviceChongFuWeiZhi", enLBDbType.Int32, DeviceChongFuWeiZhi));
                parmCol.Add(new LBParameter("DeviceShuJuWei", enLBDbType.Int32, DeviceShuJuWei));
                parmCol.Add(new LBParameter("DeviceTingZhiWei", enLBDbType.Int32, DeviceTingZhiWei));
                parmCol.Add(new LBParameter("DeviceZhenChangDu", enLBDbType.Int32, DeviceZhenChangDu));
                parmCol.Add(new LBParameter("DeviceZhenChuLiFangShi", enLBDbType.Int32, DeviceZhenChuLiFangShi));
                parmCol.Add(new LBParameter("DeviceZhenQiShiBiaoShi", enLBDbType.Int32, DeviceZhenQiShiBiaoShi));
                parmCol.Add(new LBParameter("MachineName", enLBDbType.String, LoginInfo.MachineName));
                DataSet dsReturn;
                Dictionary<string, object> dictValue;
                ExecuteSQL.CallSP(13800, parmCol, out dsReturn, out dictValue);

                LB.WinFunction.LBCommonHelper.ShowCommonMessage("保存成功！");
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtSerialName.SelectedValue.ToString()))
                {
                    throw new Exception("请选择串口名称！");
                }

                if (!_comm.IsOpen)
                {
                    //lstBytes = new List<byte[]>();
                    //关闭时点击，则设置好端口，波特率后打开
                    _comm.PortName = txtSerialName.SelectedValue.ToString();
                    _comm.BaudRate = int.Parse(txtDeviceBoTeLv.SelectedValue.ToString());
                    
                    try
                    {
                        _comm.Open();
                    }
                    catch (Exception ex)
                    {
                        //捕获到异常信息，创建一个新的comm对象，之前的不能用了。
                        _comm = new SerialPort();
                        throw new Exception(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        #endregion -- 按钮事件 --

        #region -- 控件状态，如果设备选择自定义则可编辑，否则只读 --

        private void SetTextBoxEnable()
        {
            int iWeightDeviceType = LBConverter.ToInt32(this.txtWeightDeviceType.SelectedValue);
            bool bolEnable = true;
            if (iWeightDeviceType > 0)
            {
                bolEnable = false;
            }

            this.txtDeviceBoTeLv.Enabled = bolEnable;
            this.txtDeviceChongFuChangDu.Enabled = bolEnable;
            this.txtDeviceChongFuWeiZhi.Enabled = bolEnable;
            this.txtDeviceShuJuWei.Enabled = bolEnable;
            this.txtDeviceTingZhiWei.Enabled = bolEnable;
            this.txtDeviceZhenChangDu.Enabled = bolEnable;
            this.txtDeviceZhenChuLiFangShi.Enabled = bolEnable;
            this.txtDeviceZhenQiShiBiaoShi.Enabled = bolEnable;
            this.txtSerialName.Enabled = bolEnable;
        }

        #endregion

        #region -- 加载预设的设备串口数据 --

        private void LoadSerialData(int iWeightDeviceType)
        {
            DataTable dtSerial = ExecuteSQL.CallView(118, "", "WeightDeviceType=" + iWeightDeviceType, "");
            if (dtSerial.Rows.Count > 0)
            {
                DataRow dr = dtSerial.Rows[0];
                this.txtDeviceBoTeLv.PromptText = dr["DeviceBoTeLv"].ToString();
                this.txtDeviceChongFuChangDu.PromptText = dr["DeviceChongFuChangDu"].ToString();
                this.txtDeviceChongFuWeiZhi.PromptText = dr["DeviceChongFuWeiZhi"].ToString();
                this.txtDeviceShuJuWei.PromptText = dr["DeviceShuJuWei"].ToString();
                this.txtDeviceTingZhiWei.PromptText = dr["DeviceTingZhiWei"].ToString();
                this.txtDeviceZhenChangDu.PromptText = dr["DeviceZhenChangDu"].ToString();
                this.txtDeviceZhenChuLiFangShi.PromptText = dr["DeviceZhenChuLiFangShi"].ToString();
                this.txtDeviceZhenQiShiBiaoShi.PromptText = dr["DeviceZhenQiShiBiaoShi"].ToString();
            }
        }

        #endregion

        #region -- 读取本机已保存的串口信息 --

        private void LoadMathineSerialInfo()
        {
            string strMathineName = LoginInfo.MachineName;
            DataTable dtSerial = ExecuteSQL.CallView(120, "", "MachineName='" + strMathineName + "'", "");
            if (dtSerial.Rows.Count > 0)
            {
                DataRow dr = dtSerial.Rows[0];
                long lWeightDeviceUserTypeID = LBConverter.ToInt64(dr["WeightDeviceUserTypeID"]);

                this.txtWeightDeviceType.SelectedValue = dr["WeightDeviceType"];
                string strSerialName = dr["SerialName"].ToString().TrimEnd();
                
                int iWeightDeviceType = LBConverter.ToInt32(this.txtWeightDeviceType.SelectedValue);

                if (iWeightDeviceType == 0)//自定义
                {
                    if (lWeightDeviceUserTypeID > 0)
                    {
                        DataTable dtUserConfig = ExecuteSQL.CallView(119, "", "WeightDeviceUserTypeID=" + lWeightDeviceUserTypeID, "");

                        if (dtUserConfig.Rows.Count > 0)
                        {
                            DataRow drUserConfig = dtUserConfig.Rows[0];
                            this.txtDeviceBoTeLv.SelectedValue = drUserConfig["DeviceBoTeLv"].ToString();
                            this.txtDeviceChongFuChangDu.SelectedValue = drUserConfig["DeviceChongFuChangDu"].ToString();
                            this.txtDeviceChongFuWeiZhi.SelectedValue = drUserConfig["DeviceChongFuWeiZhi"].ToString();
                            this.txtDeviceShuJuWei.SelectedValue = drUserConfig["DeviceShuJuWei"].ToString();
                            this.txtDeviceTingZhiWei.SelectedValue = drUserConfig["DeviceTingZhiWei"].ToString();
                            this.txtDeviceZhenChangDu.SelectedValue = drUserConfig["DeviceZhenChangDu"].ToString();
                            this.txtDeviceZhenChuLiFangShi.SelectedValue = drUserConfig["DeviceZhenChuLiFangShi"].ToString();
                            this.txtDeviceZhenQiShiBiaoShi.SelectedValue = drUserConfig["DeviceZhenQiShiBiaoShi"].ToString();
                            this.txtSerialName.SelectedValue = strSerialName;
                        }
                    }
                }
                else
                {
                    this.txtSerialName.SelectedValue = strSerialName;
                }
            }
        }

        #endregion
    }
}
