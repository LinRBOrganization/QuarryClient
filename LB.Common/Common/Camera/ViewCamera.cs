using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LB.Common.Camera
{
    public partial class ViewCamera : UserControl
    {
        private int _Port=0;
        private string _IPAddress = "";
        private string _Account = "";
        private string _Password = "";
        private int user = 0;
        private int playHandle = 0;

        public int Port
        {
            set
            {
                _Port = value;
            }
            get
            {
                return _Port;
            }
        }
        public string IPAddress
        {
            set
            {
                _IPAddress = value;
            }
            get
            {
                return _IPAddress;
            }
        }
        public string Account
        {
            set
            {
                _Account = value;
            }
            get
            {
                return _Account;
            }
        }
        public string Password
        {
            set
            {
                _Password = value;
            }
            get
            {
                return _Password;
            }
        }

        public ViewCamera()
        {
            InitializeComponent();
        }

        public void OpenCamera()
        {
            if (IPAddress == "")
                throw new Exception("IP地址不能为空！");
            if (_Port <= 0)
                throw new Exception("端口不能为空！");

            bool tag = HikSDK.NET_DVR_Init();
            ushort uPort = (ushort)_Port;
            HikSDK.LPNET_DVR_DEVICEINFO_V301 dev = new HikSDK.LPNET_DVR_DEVICEINFO_V301();
            user = HikSDK.NET_DVR_Login_V30(IPAddress, uPort, Account, Password, out dev);
            HikSDK.NET_DVR_CLIENTINFO cl = new HikSDK.NET_DVR_CLIENTINFO();
            cl.hPlayWnd = this.Handle;
            cl.lChannel = 1;
            cl.lLinkMode = 0;
            //return;  /////////*******************************************************如果下载或回放,必须先停止播放
            playHandle = HikSDK.NET_DVR_RealPlay(user, ref cl);
        }

        public void CloseCamera()
        {
            HikSDK.NET_DVR_StopRealPlay(playHandle);
            HikSDK.NET_DVR_Logout(user);
            HikSDK.NET_DVR_Cleanup();
        }

        /// <summary>
        /// 获取摄像头截图
        /// </summary>
        /// <returns></returns>
        public byte[] CapturePic()
        {
            byte[] byteImage = null;
            HikSDK.LPNET_DVR_JPEGPARA lpJpegPara = new HikSDK.LPNET_DVR_JPEGPARA();

            //JEPG抓图，数据保存在缓冲区中 Capture a JPEG picture and save in the buffer
            uint iBuffSize = 500000; //缓冲区大小需要不小于一张图片数据的大小 The buffer size should not be less than the picture size
            byte[] byJpegPicBuffer = new byte[iBuffSize];
            uint dwSizeReturned = 0;
            if (!HikSDK.NET_DVR_CaptureJPEGPicture_NEW(user, 1, ref lpJpegPara, byJpegPicBuffer, iBuffSize, ref dwSizeReturned))
            {
                uint iLastErr = HikSDK.NET_DVR_GetLastError();
                string str = "摄像头调用失败，无法获取影像图片, error code= " + iLastErr;
                throw new Exception(str);
                //DebugInfo(str);
                return null;
            }
            else
            {
                byteImage = new byte[dwSizeReturned];
                for(int i=0,j= (int)dwSizeReturned; i < j; i++)
                {
                    byteImage[i] = byJpegPicBuffer[i];
                }
                //将缓冲区里的JPEG图片数据写入文件 save the data into a file
                //string str = Application.StartupPath +@"\"+ name + ".jpg";
                //FileStream fs = new FileStream(str, FileMode.Create);
                //int iLen = (int)dwSizeReturned;
                //fs.Write(byJpegPicBuffer, 0, iLen);
                //fs.Close();

                //str = "NET_DVR_CaptureJPEGPicture_NEW succ and save the data in buffer to 'buffertest.jpg'.";
                //DebugInfo(str);
            }
            return byteImage;
        }
    }
}
