using LB.Common;
using LB.Common.Camera;
using LB.Controls;
using LB.Page.Helper;
using LB.SysConfig.SysConfig;
using LB.WinFunction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LB.MainForm
{
    public partial class WeightForm : LBForm
    {
        private Timer mTimer=null;
        public bool bolIsCancel = false;
        LB.MainForm.CtlBaseInfoSelection _ctlBaseInfo = null;
        public bool _OpenCamera = false;
        public enWeightType _WeightType;
        public WeightForm()
        {
            InitializeComponent();
            this.AutoSize = false;
            mTimer = new Timer();
            mTimer.Interval = 100;
            mTimer.Enabled = true;
            mTimer.Tick += MTimer_Tick;
        }

        private void MTimer_Tick(object sender, EventArgs e)
        {
            this.lblWeight.Text = LBSerialHelper.WeightValue.ToString();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ReadWeightType();//读取磅房类型

            InitData();
            LoadAllSalesBill();//磅单清单
            this.ctlSearcher1.SetGridView(this.grdMain, "CarNum");

            InitBaseControl();
            InitTextDataSource();

            //OpenCamera();//开启监控

            LBSerialHelper.StartSerial();//启动串口

            System.Threading.Thread threadCamera1 = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart( OpenCamera));
            threadCamera1.Start(1);

            threadCamera1 = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(OpenCamera));
            threadCamera1.Start(2);

            threadCamera1 = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(OpenCamera));
            threadCamera1.Start(3);

            threadCamera1 = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(OpenCamera));
            threadCamera1.Start(4);
        }

        #region -- 读取磅房类型 -- 

        private void ReadWeightType()
        {
            DataTable dtType = ExecuteSQL.CallView(126, "", "MachineName='" + LoginInfo.MachineName + "'", "");
            if (dtType.Rows.Count > 0)
            {
                _WeightType = (enWeightType)LBConverter.ToInt32( dtType.Rows[0]["WeightType"]);
            }

            ChangeTextBoxStatusByType(_WeightType);
        }

        private void ChangeTextBoxStatusByType(enWeightType eWeightType)
        {
            if(eWeightType== enWeightType.WeightIn)//入场磅
            {
                this.txtItemID.TextBox.ReadOnly = false;
                this.txtCalculateType.Enabled = false;
                this.txtReceiveType.Enabled = false;
            }
            else
            {
                this.txtItemID.TextBox.ReadOnly = true;
                this.txtCalculateType.Enabled = true;
                this.txtReceiveType.Enabled = true;
            }
        }

        #endregion

        #region -- Init TextBox DataSource --

        private void InitTextDataSource()
        {
            this.txtReceiveType.DataSource = LB.Common.LBConst.GetConstData("ReceiveType");//收款方式
            this.txtReceiveType.DisplayMember = "ConstText";
            this.txtReceiveType.ValueMember = "ConstValue";

            this.txtCalculateType.DataSource = LB.Common.LBConst.GetConstData("CalculateType");//计价方式
            this.txtCalculateType.DisplayMember = "ConstText";
            this.txtCalculateType.ValueMember = "ConstValue";

            DataTable dtCustom = ExecuteSQL.CallView(110);
            this.txtCustomerID.TextBox.IDColumnName = "CustomerID";
            this.txtCustomerID.TextBox.TextColumnName = "CustomerName";
            this.txtCustomerID.TextBox.PopDataSource = dtCustom.DefaultView;

            DataTable dtCar = ExecuteSQL.CallView(113);
            this.txtCarID.TextBox.IDColumnName = "CarID";
            this.txtCarID.TextBox.TextColumnName = "CarNum";
            this.txtCarID.TextBox.PopDataSource = dtCar.DefaultView;

            DataTable dtItem = ExecuteSQL.CallView(203);
            this.txtItemID.TextBox.IDColumnName = "ItemID";
            this.txtItemID.TextBox.TextColumnName = "ItemName";
            this.txtItemID.TextBox.PopDataSource = dtItem.DefaultView;

            this.txtCustomerID.TextBox.IsAllowNotExists = true;
            this.txtCarID.TextBox.IsAllowNotExists = true;
            this.txtItemID.TextBox.IsAllowNotExists = true;

            this.txtCarID.TextBox.GotFocus += CoolText_GotFocus;
            this.txtItemID.TextBox.GotFocus += CoolText_GotFocus;
            this.txtCustomerID.TextBox.GotFocus += CoolText_GotFocus;

            this.txtCarID.TextBox.LostFocus += CoolText_LostFocus;
            this.txtItemID.TextBox.LostFocus += CoolText_LostFocus;
            this.txtCustomerID.TextBox.LostFocus += CoolText_LostFocus;

            this.txtCarID.TextBox.TextChanged += CoolText_TextChanged;
            this.txtItemID.TextBox.TextChanged += CoolText_TextChanged;
            this.txtCustomerID.TextBox.TextChanged += CoolText_TextChanged;
            this.txtCalculateType.TextChanged += TxtCalculateType_TextChanged;

            this.txtTotalWeight.TextChanged += TxtCalAmount_TextChanged;
            this.txtSuttleWeight.TextChanged+= TxtCalAmount_TextChanged;
            this.txtPrice.TextChanged+= TxtCalAmount_TextChanged;
            this.txtCarTare.TextChanged += TxtCalAmount_TextChanged;
            
        }

        private void TxtCalculateType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //读取物料价格
                ReadPrice(sender);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void CoolText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RereadBaseInfo(sender);
                //读取物料价格
                ReadPrice(sender);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void RereadBaseInfo(object sender)
        {
            if (_ctlBaseInfo.BaseInfoType == enBaseInfoType.Car && sender == txtCarID.TextBox)
            {
                string strFilter = "";
                string strValue = txtCarID.TextBox.Text.TrimEnd();
                if (strValue != "")
                {
                    strFilter = "CarNum like '%" + strValue + "%'";
                }
                _ctlBaseInfo.LoadDataSource(strFilter);
            }
            else if (_ctlBaseInfo.BaseInfoType == enBaseInfoType.Item && sender == txtItemID.TextBox)
            {
                string strFilter = "";
                string strValue = txtItemID.TextBox.Text.TrimEnd();
                if (strValue != "")
                {
                    strFilter = "ItemName like '%" + strValue + "%'";
                }
                _ctlBaseInfo.LoadDataSource(strFilter);
            }
            else if (_ctlBaseInfo.BaseInfoType == enBaseInfoType.Customer && sender == txtCustomerID.TextBox)
            {
                string strFilter = "";
                string strValue = txtCustomerID.TextBox.Text.TrimEnd();
                if (strValue != "")
                {
                    strFilter = "CustomerName like '%" + strValue + "%'";
                }
                _ctlBaseInfo.LoadDataSource(strFilter);
            }
        }

        private void ReadPrice(object sender)
        {
            if (sender == this.txtCarID.TextBox || sender == this.txtItemID.TextBox || sender == this.txtCalculateType)
            {
                this.txtPrice.Text = "0";

                string strCarNum = this.txtCarID.TextBox.Text.ToString();
                string strItemName = this.txtItemID.TextBox.Text.ToString();

                if (strCarNum == "" || strItemName == "")
                    return;

                long lCarID = 0;
                long lItemID = 0;
                using (DataTable dtCar = ExecuteSQL.CallView(113, "CarID", "CarNum='" + strCarNum + "'", ""))
                {
                    if (dtCar.Rows.Count > 0)
                    {
                        lCarID = LBConverter.ToInt64(dtCar.Rows[0]["CarID"]);
                    }
                }
                using (DataTable dtItem = ExecuteSQL.CallView(203, "ItemID", "ItemName='" + strItemName + "'", ""))
                {
                    if (dtItem.Rows.Count > 0)
                    {
                        lItemID = LBConverter.ToInt64(dtItem.Rows[0]["ItemID"]);
                    }
                }


                int iCalculateType = LBConverter.ToInt32(this.txtCalculateType.SelectedValue);
                
                if (lCarID > 0 && lItemID > 0)
                {
                    LBDbParameterCollection parmCol = new LBDbParameterCollection();
                    parmCol.Add(new LBParameter("ItemID", enLBDbType.Int64, lItemID));
                    parmCol.Add(new LBParameter("CarID", enLBDbType.Int64, lCarID));
                    parmCol.Add(new LBParameter("CalculateType", enLBDbType.Int32, iCalculateType));

                    DataSet dsReturn;
                    Dictionary<string, object> dictValue;
                    ExecuteSQL.CallSP(13608, parmCol, out dsReturn, out dictValue);
                    if (dictValue.ContainsKey("Price"))
                    {
                        this.txtPrice.Text = LBConverter.ToDecimal(dictValue["Price"]).ToString("0.0");
                    }
                }
            }
        }

        private void CoolText_LostFocus(object sender, EventArgs e)
        {
            try
            {
                this._ctlBaseInfo.ChangeItemType(enBaseInfoType.None);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void CoolText_GotFocus(object sender, EventArgs e)
        {
            try
            {
                if(sender == txtCarID.TextBox)
                {
                    this._ctlBaseInfo.ChangeItemType(enBaseInfoType.Car);
                    RereadBaseInfo(txtCarID.TextBox);
                }
                else if (sender == txtItemID.TextBox)
                {
                    this._ctlBaseInfo.ChangeItemType(enBaseInfoType.Item);
                    RereadBaseInfo(txtItemID.TextBox);
                }
                else if (sender == txtCustomerID.TextBox)
                {
                    this._ctlBaseInfo.ChangeItemType(enBaseInfoType.Customer);
                    RereadBaseInfo(txtCustomerID.TextBox);
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        #endregion

        #region -- 初始化基础资料列表 --

        private void InitBaseControl()
        {
            _ctlBaseInfo = new LB.MainForm.CtlBaseInfoSelection();
            _ctlBaseInfo.Dock = DockStyle.Fill;
            this.pnlBaseSelect.Controls.Add(_ctlBaseInfo);

            _ctlBaseInfo.SelectedRowEvent += _ctlBaseInfo_SelectedRowEvent;
        }

        private void _ctlBaseInfo_SelectedRowEvent(Controls.Args.SelectedRowArgs e)
        {
            try
            {
                if(e.BaseInfoType== enBaseInfoType.Car)
                {
                    this.txtCarID.TextBox.SelectedItemID = e.SelectedRow["CarID"];
                }
                else if (e.BaseInfoType == enBaseInfoType.Item)
                {
                    this.txtItemID.TextBox.SelectedItemID = e.SelectedRow["ItemID"];
                }
                else if (e.BaseInfoType == enBaseInfoType.Customer)
                {
                    this.txtCustomerID.TextBox.SelectedItemID = e.SelectedRow["CustomerID"];
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        #endregion

        #region -- InitData 读取全局数据 --

        private void InitData()
        {
            LBPermission.ReadAllPermission();//加载所有权限信息

            LBLog.AssemblyStart();

            this.grdMain.LBLoadConst();
        }

        #endregion

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region -- 按钮事件 --
        //皮重
        private void btnReadTareWeight_Click(object sender, EventArgs e)
        {
            try
            {
                decimal decWeight = LBConverter.ToDecimal(lblWeight.Text);//读皮重
                this.txtCarTare.Text = decWeight.ToString("0");
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        //毛重
        private void btnTotalWeight_Click(object sender, EventArgs e)
        {
            try
            {
                decimal decWeight = LBConverter.ToDecimal(lblWeight.Text);//读毛重
                this.txtTotalWeight.Text = decWeight.ToString("0");
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveInBill();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        //查询
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAllSalesBill();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }


        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                LB.SysConfig.frmChangePassword frmChangePW = new SysConfig.frmChangePassword();
                frmChangePW.ShowDialog();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                bolIsCancel = true;
                this.Close();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnDeviceConfig_Click(object sender, EventArgs e)
        {
            try
            {
                frmWeightDecive frmDevice = new frmWeightDecive();
                LBShowForm.ShowDialog(frmDevice);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }
        
        private void btnCameraConfig_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnRoomManager_Click(object sender, EventArgs e)
        {
            try
            {
                frmWeightConfigType frm = new SysConfig.SysConfig.frmWeightConfigType();
                LBShowForm.ShowDialog(frm);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }
        #endregion -- 按钮事件 --

        #region-- 保存入磅记录 --

        private void SaveInBill()
        {
            long lSaleCarInBillID = LBConverter.ToInt64(this.txtSaleCarInBillID.Text);
            long lCarID= LBConverter.ToInt64(this.txtCarID.TextBox.SelectedItemID);
            long lItemID = LBConverter.ToInt64(this.txtItemID.TextBox.SelectedItemID);
            long lCustomerID = LBConverter.ToInt64(this.txtCustomerID.TextBox.SelectedItemID);
            int iReceiveType = LBConverter.ToInt32(this.txtReceiveType.SelectedValue);
            int iCalculateType = LBConverter.ToInt32(this.txtCalculateType.SelectedValue);
            decimal decCarTare = LBConverter.ToDecimal(this.txtCarTare.Text);

            if (decCarTare == 0)
            {
                throw new Exception("当前【皮重】值为0，无法保存！");
            }

            LBDbParameterCollection parmCol = new LBDbParameterCollection();
            parmCol.Add(new LBParameter("SaleCarInBillID", enLBDbType.Int64, lSaleCarInBillID));
            parmCol.Add(new LBParameter("SaleCarInBillCode", enLBDbType.String, ""));
            parmCol.Add(new LBParameter("BillDate", enLBDbType.DateTime, DateTime.Now));
            parmCol.Add(new LBParameter("CarID", enLBDbType.Int64, lCarID));
            parmCol.Add(new LBParameter("ItemID", enLBDbType.Int64, lItemID));
            parmCol.Add(new LBParameter("CustomerID", enLBDbType.Int64, lCustomerID));
            parmCol.Add(new LBParameter("Description", enLBDbType.String, this.txtDescription.Text));
            parmCol.Add(new LBParameter("ReceiveType", enLBDbType.Int32, iReceiveType));
            parmCol.Add(new LBParameter("CalculateType", enLBDbType.Int32, iCalculateType));
            parmCol.Add(new LBParameter("CarTare", enLBDbType.Decimal, decCarTare));
            
            DataSet dsReturn;
            Dictionary<string, object> dictValue;
            ExecuteSQL.CallSP(14100, parmCol, out dsReturn, out dictValue);
            if (dictValue.ContainsKey("CustomerID"))
            {
                this.txtSaleCarInBillID.Text = dictValue["SaleCarInBillID"].ToString();
            }
            if (dictValue.ContainsKey("SaleCarInBillCode"))
            {
                this.txtSaleCarInBillCode.Text = dictValue["SaleCarInBillCode"].ToString();
            }
            if (dictValue.ContainsKey("BillDate"))
            {
                this.txtBillDateIn.Text = dictValue["BillDate"].ToString();
            }

            LoadAllSalesBill(); //刷新磅单清单
        }

        #endregion-- 保存入磅记录 --

        #region -- 查询磅单清单 --

        private void LoadAllSalesBill()
        {
            string strFilter = this.ctlSearcher1.GetFilter();
            if (strFilter != "")
            {
                strFilter += " and ";
            }
            DateTime dtBillDateFrom = Convert.ToDateTime(this.txtBillDateFrom.Text);
            DateTime dtBillDateTo = Convert.ToDateTime(this.txtBillDateTo.Text);
            strFilter += "(BillDateIn>='" + dtBillDateFrom.ToString("yyyy-MM-dd") + "' and BillDateIn<='" + dtBillDateTo.AddDays(1).ToString("yyyy-MM-dd") +"')";
            DataTable dtBill = ExecuteSQL.CallView(125, "", strFilter, "");
            this.grdMain.DataSource = dtBill.DefaultView;
        }

        #endregion

        #region -- 自动开启监控 --

        private void OpenCamera(object CameraIndex)
        {
            return;
            int iCameraIndex = Convert.ToInt16(CameraIndex);
            DataTable dtCamera = ExecuteSQL.CallView(122, "", "MachineName='" + LoginInfo.MachineName + "'", "");
            if (dtCamera.Rows.Count > 0)
            {
                DataRow dr = dtCamera.Rows[0];

                if (iCameraIndex == 1)
                {
                    MethodInvoker func = delegate ()
                    {
                        viewCamera1.IPAddress = dr["IPAddress1"].ToString().TrimEnd();
                        viewCamera1.Port = LBConverter.ToInt32(dr["Port1"]);
                        viewCamera1.Account = dr["Account1"].ToString().TrimEnd();
                        viewCamera1.Password = dr["Password1"].ToString().TrimEnd();
                        viewCamera1.OpenCamera();
                    };

                    if (viewCamera1.InvokeRequired)
                    {
                        viewCamera1.BeginInvoke(func);
                    }
                    else
                    {
                        func();
                    }
                }
                else if (iCameraIndex == 2)
                {
                    MethodInvoker func2 = delegate ()
                    {
                        viewCamera2.IPAddress = dr["IPAddress2"].ToString().TrimEnd();
                        viewCamera2.Port = LBConverter.ToInt32(dr["Port2"]);
                        viewCamera2.Account = dr["Account2"].ToString().TrimEnd();
                        viewCamera2.Password = dr["Password2"].ToString().TrimEnd();
                        viewCamera2.OpenCamera();
                    };

                    if (viewCamera2.InvokeRequired)
                    {
                        viewCamera2.BeginInvoke(func2);
                    }
                    else
                    {
                        func2();
                    }
                }
                else if (iCameraIndex == 3)
                {
                    MethodInvoker func2 = delegate ()
                    {
                        viewCamera3.IPAddress = dr["IPAddress3"].ToString().TrimEnd();
                        viewCamera3.Port = LBConverter.ToInt32(dr["Port3"]);
                        viewCamera3.Account = dr["Account3"].ToString().TrimEnd();
                        viewCamera3.Password = dr["Password3"].ToString().TrimEnd();
                        viewCamera3.OpenCamera();
                    };

                    if (viewCamera3.InvokeRequired)
                    {
                        viewCamera3.BeginInvoke(func2);
                    }
                    else
                    {
                        func2();
                    }
                }
                else if (iCameraIndex == 4)
                {
                    MethodInvoker func2 = delegate ()
                    {
                        viewCamera4.IPAddress = dr["IPAddress4"].ToString().TrimEnd();
                        viewCamera4.Port = LBConverter.ToInt32(dr["Port4"]);
                        viewCamera4.Account = dr["Account4"].ToString().TrimEnd();
                        viewCamera4.Password = dr["Password4"].ToString().TrimEnd();
                        viewCamera4.OpenCamera();
                    };

                    if (viewCamera4.InvokeRequired)
                    {
                        viewCamera4.BeginInvoke(func2);
                    }
                    else
                    {
                        func2();
                    }
                }

                /*if (this.viewCamera1.InvokeRequired)//等待异步
                {
                    OpenViewCamera ovc = new OpenViewCamera(DoneViewCamera);
                    this.Invoke(ovc, viewCamera1,
                        dr["IPAddress1"].ToString().TrimEnd(),
                        LBConverter.ToInt32(dr["Port1"]),
                        dr["Account1"].ToString().TrimEnd(),
                        dr["Password1"].ToString().TrimEnd());
                }

                ovc = new OpenViewCamera(DoneViewCamera);
                this.Invoke(ovc, viewCamera2,
                    dr["IPAddress2"].ToString().TrimEnd(),
                    LBConverter.ToInt32(dr["Port2"]),
                    dr["Account2"].ToString().TrimEnd(),
                    dr["Password2"].ToString().TrimEnd());

                ovc = new OpenViewCamera(DoneViewCamera);
                this.Invoke(ovc, viewCamera3,
                    dr["IPAddress3"].ToString().TrimEnd(),
                    LBConverter.ToInt32(dr["Port3"]),
                    dr["Account3"].ToString().TrimEnd(),
                    dr["Password3"].ToString().TrimEnd());

                ovc = new OpenViewCamera(DoneViewCamera);
                this.Invoke(ovc, viewCamera4,
                    dr["IPAddress4"].ToString().TrimEnd(),
                    LBConverter.ToInt32(dr["Port4"]),
                    dr["Account4"].ToString().TrimEnd(),
                    dr["Password4"].ToString().TrimEnd());*/
            }
        }
        public delegate void OpenViewCamera(ViewCamera vc, string ip,int port,string account,string pw);
        public void DoneViewCamera(ViewCamera vc, string ip, int port, string account, string pw)
        {
            vc.IPAddress = ip;
            vc.Port = port;
            vc.Account = account;
            vc.Password = pw;

            vc.OpenCamera();
        }


        #endregion -- 自动开启监控 --

        #region -- TextBox 事件 计算金额 --

        private void TxtCalAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalAmount();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }
        #endregion -- TextBox 事件 --

        #region -- 计算 金额=净重*单价 --

        private void CalAmount()
        {
            decimal decTotalWeight = LBConverter.ToDecimal(this.txtTotalWeight.Text);
            decimal decCarTare = LBConverter.ToDecimal(this.txtCarTare.Text);
            this.txtSuttleWeight.Text = (decTotalWeight - decCarTare).ToString("0");

            decimal decPrice= LBConverter.ToDecimal(this.txtPrice.Text);
            this.txtAmount.Text = (decPrice * (decTotalWeight - decCarTare)).ToString("0.0");
        }

        #endregion

    }
}
