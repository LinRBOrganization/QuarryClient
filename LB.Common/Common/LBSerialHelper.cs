using LB.WinFunction;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LB.Common
{
    public class LBSerialHelper
    {
        private static Timer mTimer = null;
        private static SerialPort _comm;

        private static string _SerialName = "";
        private static int _DeviceBoTeLv = 0;
        private static int _DeviceZhenChuLiFangShi = 0;
        private static int _DeviceShuJuWei = 0;
        private static int _DeviceZhenQiShiBiaoShi = 0;

        public static int WeightValue = 0;

        public static void StartSerial()
        {
            mTimer = new Timer();
            mTimer.Interval = 2000;
            mTimer.Tick += MTimer_Tick;
            mTimer.Enabled = true;
            InitSerialPort();
        }

        private static void MTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                GetSerialInfo(out _SerialName, out _DeviceBoTeLv, out _DeviceZhenChuLiFangShi, out _DeviceShuJuWei,out _DeviceZhenQiShiBiaoShi);

                if (_SerialName != "")
                {
                    if (!_comm.IsOpen)
                    {
                        //lstBytes = new List<byte[]>();
                        //关闭时点击，则设置好端口，波特率后打开
                        _comm.PortName = _SerialName;
                        _comm.BaudRate = _DeviceBoTeLv;

                        try
                        {
                            _comm.Open();
                        }
                        catch (Exception ex)
                        {
                            //捕获到异常信息，创建一个新的comm对象，之前的不能用了。
                            InitSerialPort();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private static void InitSerialPort()
        {
            _comm = new SerialPort();
            _comm.DataReceived += _comm_DataReceived;
        }

        private static void _comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int n = _comm.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
                byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据

                _comm.Read(buf, 0, n);//读取缓冲数据
                if (buf.Length == _DeviceShuJuWei)//如果接受的数据长度大于设定的数据位长度
                {
                    byte[] bcatch_data = new byte[buf.Length - _DeviceZhenQiShiBiaoShi];
                    for (int i = _DeviceZhenQiShiBiaoShi; i < buf.Length; i++)
                    {
                        bcatch_data[i - _DeviceZhenQiShiBiaoShi] = buf[i];
                    }
                    //buf.CopyTo(bcatch_data, iStartBit);

                    string strValue = "";
                    if (_DeviceZhenChuLiFangShi == 0)//ASCII
                    {
                        strValue = Encoding.ASCII.GetString(bcatch_data);
                    }
                    
                    int.TryParse(strValue, out WeightValue);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static void CloseSerial()
        {
            if (_comm != null)
            {
                if(_comm.IsOpen)
                {
                    _comm.Close();
                    _comm.Dispose();
                }
            }
        }

        private static void GetSerialInfo(
            out string strSerialName,
            out int DeviceBoTeLv,
            out int DeviceZhenChuLiFangShi,
            out int DeviceShuJuWei,
            out int DeviceZhenQiShiBiaoShi)
        {
            strSerialName = "";
            DeviceBoTeLv = 0;
            DeviceZhenChuLiFangShi = 0;
            DeviceShuJuWei = 0;
            DeviceZhenQiShiBiaoShi = 0;

            string strMathineName = LoginInfo.MachineName;
            DataTable dtSerial = ExecuteSQL.CallView(120, "", "MachineName='" + strMathineName + "'", "");
            if (dtSerial.Rows.Count > 0)
            {
                DataRow dr = dtSerial.Rows[0];
                long lWeightDeviceUserTypeID = LBConverter.ToInt64(dr["WeightDeviceUserTypeID"]);
                strSerialName = dr["SerialName"].ToString();
                int iWeightDeviceType = LBConverter.ToInt32(dr["WeightDeviceType"]);

                if (iWeightDeviceType == 0)//自定义
                {
                    if (lWeightDeviceUserTypeID > 0)
                    {
                        DataTable dtUserConfig = ExecuteSQL.CallView(119, "", "WeightDeviceUserTypeID=" + lWeightDeviceUserTypeID, "");

                        if (dtUserConfig.Rows.Count > 0)
                        {
                            DataRow drUserConfig = dtUserConfig.Rows[0];
                            DeviceBoTeLv =LBConverter.ToInt32( drUserConfig["DeviceBoTeLv"]);
                            DeviceShuJuWei = LBConverter.ToInt32(drUserConfig["DeviceShuJuWei"]);
                            DeviceZhenChuLiFangShi = LBConverter.ToInt32(drUserConfig["DeviceZhenChuLiFangShi"]);
                            DeviceZhenQiShiBiaoShi = LBConverter.ToInt32(drUserConfig["DeviceZhenQiShiBiaoShi"]);
                        }
                    }
                }
                else
                {
                    DataTable dtSysSerial = ExecuteSQL.CallView(118, "", "WeightDeviceType=" + iWeightDeviceType, "");
                    if (dtSysSerial.Rows.Count > 0)
                    {
                        DataRow drSerial = dtSysSerial.Rows[0];
                        DeviceBoTeLv = LBConverter.ToInt32(drSerial["DeviceBoTeLv"]);
                        DeviceShuJuWei = LBConverter.ToInt32(drSerial["DeviceShuJuWei"]);
                        DeviceZhenChuLiFangShi = LBConverter.ToInt32(drSerial["DeviceZhenChuLiFangShi"]);
                        DeviceZhenQiShiBiaoShi = LBConverter.ToInt32(drSerial["DeviceZhenQiShiBiaoShi"]);
                    }
                }
            }
        }
    }
}
