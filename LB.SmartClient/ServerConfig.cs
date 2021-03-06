﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LB.SmartClient
{
    internal class ServerConfig
    {
        internal const string ConfigName = "ServerConfig.ini";

        /// <summary>
        /// 创建默认的配置文件
        /// </summary>
        internal static void BuildDefaultConfigFile()
        {
            string strConfigPath = Path.Combine(Application.StartupPath, ServerConfig.ConfigName);
            if (!File.Exists(strConfigPath))
            {
                IniClass ini = new SmartClient.IniClass(strConfigPath);
                ini.WriteValue("ServerConfig", "server", "(local)");
                ini.WriteValue("ServerConfig", "port", "2722");
            }
        }

        /// <summary>
        /// 读取配置文件
        /// </summary>
        /// <param name="strServer"></param>
        /// <param name="strPort"></param>
        internal static void ReadConfigFile(out string strServer,out string strPort)
        {
            strServer = "";
            strPort = "";
            string strConfigPath = Path.Combine(Application.StartupPath, ServerConfig.ConfigName);
            if (File.Exists(strConfigPath))
            {
                IniClass ini = new SmartClient.IniClass(strConfigPath);
                strServer = ini.ReadValue("ServerConfig", "server");
                strPort = ini.ReadValue("ServerConfig", "port");
            }
        }
    }
}
