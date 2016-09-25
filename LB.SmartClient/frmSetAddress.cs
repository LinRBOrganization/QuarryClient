using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LB.SmartClient
{
    public partial class frmSetAddress : Form
    {
        public frmSetAddress()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strConfigName = "ServerConfig.ini";
            string strConfigPath = Path.Combine(Application.StartupPath, strConfigName);
            IniClass ini = new SmartClient.IniClass(strConfigPath);
            ini.WriteValue("ServerConfig", "server", this.txtAddress.Text);
            ini.WriteValue("ServerConfig", "port", this.txtPort.Text);
            this.Close();
        }
    }
}
