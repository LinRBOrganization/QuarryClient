﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LB.Controls;
using LB.MainForm.Permission;
using LB.Page.Helper;
using System.Threading;
using LB.Common;
using LB.SysConfig;
using LB.WinFunction;
using LB.RPReceive;

namespace LB.MainForm
{
    public partial class MainForm : LBForm
    {
        private Thread mThreadStatus;
        public bool bolIsCancel = false;
        private bool bolIsClosing = false;
        public MainForm()
        {
            InitializeComponent();
            LBShowForm.LBUIPageBaseAdded += LBShowForm_LBUIPageBaseAdded;
            this.tcMain.TabPageClosingEvent += TcMain_TabPageClosingEvent;
            this.tcMain.TabPageClosedEvent += TcMain_TabPageClosedEvent;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitData();

            mThreadStatus = new Thread(TestServerConnectStatus);
            mThreadStatus.Start();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (LB.WinFunction.LBCommonHelper.ConfirmMessage("是否确认退出系统？", "提示", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
                return;   
            }

            if (this.mThreadStatus.ThreadState != ThreadState.Stopped ||
            this.mThreadStatus.ThreadState != ThreadState.StopRequested)
            {
                bolIsClosing = true;
                this.mThreadStatus.Abort();
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        #region -- 按钮事件  --
        //注销
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                bolIsCancel = true;
                LBShowForm.LBUIPageBaseAdded -= LBShowForm_LBUIPageBaseAdded;
                this.Dispose();
                this.Close();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        //修改密码
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

        //用户权限管理
        private void btnUserManager_Click(object sender, EventArgs e)
        {
            try
            {
                SysConfig.frmUserManager frmUserMag = new SysConfig.frmUserManager();
                LBShowForm.ShowMainPage(frmUserMag);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        //视图配置
        private void btnViewConfig_Click(object sender, EventArgs e)
        {
            try
            {
                frmDevelopViewConfig frmView = new frmDevelopViewConfig();
                LBShowForm.ShowMainPage(frmView);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        //权限配置
        private void btnPermissionConfig_Click(object sender, EventArgs e)
        {
            try
            {
                frmPermissionConfig frmView = new frmPermissionConfig();
                LBShowForm.ShowMainPage(frmView);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSQLBuilder_Click(object sender, EventArgs e)
        {
            try
            {
                frmSQLScriptBuilder frmView = new frmSQLScriptBuilder();
                frmView.ShowDialog();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        //操作日志管理
        private void btnLogManager_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogManager frmLog = new frmLogManager();
                LBShowForm.ShowMainPage(frmLog);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        //备份设置
        private void btnDBBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                frmBackUpConfig frmBackUp = new frmBackUpConfig();
                LBShowForm.ShowMainPage(frmBackUp);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        //充值
        private void btnRPReceive_Click(object sender, EventArgs e)
        {
            try
            {
                frmEditReceiveBill frmReceive = new frmEditReceiveBill(0);
                LBShowForm.ShowDialog(frmReceive);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        //充值记录
        private void btnRPReceiveList_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }
        #endregion -- 按钮事件  --

        #region -- ShowMainPage --

        private void LBShowForm_LBUIPageBaseAdded(object sender, EventArgs e)
        {
            int iMaxIndex = 0;
            foreach(DMSkin.Metro.Controls.MetroTabPage tp in this.tcMain.TabPages)
            {
                if(tp.TabIndex> iMaxIndex)
                {
                    iMaxIndex = tp.TabIndex;
                }
            }
            LBUIPageBase Uipagebase = sender as LBUIPageBase;
            Uipagebase.FormClosed += Uipagebase_FormClosed;
            
            string strTabTitle= Uipagebase.LBPageTitle == "" ? Uipagebase.Name : Uipagebase.LBPageTitle;
            DMSkin.Metro.Controls.MetroTabPage tpTp1 = new DMSkin.Metro.Controls.MetroTabPage();
            tpTp1.Name = Uipagebase.Name;
            tpTp1.BackColor = System.Drawing.Color.White;
            //tpTp1.Dock = System.Windows.Forms.DockStyle.Fill;
            Graphics g = this.CreateGraphics();
            SizeF size = g.MeasureString(strTabTitle, this.tcMain.Font);
            tpTp1.Size = new System.Drawing.Size((int)size.Width+20, 316);
            tpTp1.TabIndex = iMaxIndex+1;
            tpTp1.Text = Uipagebase.LBPageTitle==""? Uipagebase.Name: Uipagebase.LBPageTitle;
            tpTp1.Tag = Uipagebase;
            this.tcMain.TabPages.Add(tpTp1);

            Uipagebase.Size = new Size(tpTp1.Width, tpTp1.Height);
            Uipagebase.Location = new Point(1, 1);
            tpTp1.Controls.Add(Uipagebase);
            
            this.tcMain.SelectedTab = tpTp1;
            tpTp1.Invalidate();
            tpTp1.SizeChanged += TpTp1_SizeChanged;
            Uipagebase.Invalidate();
            Uipagebase.RefTabPage = tpTp1;
        }

        private void TpTp1_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                DMSkin.Metro.Controls.MetroTabPage tpCurrent = sender as DMSkin.Metro.Controls.MetroTabPage;
                
                if (tpCurrent.Tag is LBUIPageBase)
                {
                    LBUIPageBase pageBase = tpCurrent.Tag as LBUIPageBase;
                    pageBase.Size = new Size(tpCurrent.Width, tpCurrent.Height);
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void Uipagebase_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                LBUIPageBase Uipagebase = sender as LBUIPageBase;
                if (Uipagebase.RefTabPage != null)
                {
                    if (this.tcMain.TabPages.Contains(Uipagebase.RefTabPage))
                    {
                        Uipagebase.Dispose();
                        this.tcMain.TabPages.Remove(Uipagebase.RefTabPage);
                    }
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void TcMain_TabPageClosedEvent(object sender, Controls.Args.TabPageClosedEventArgs e)
        {
            try
            {
                TabPage tpCurrent = e.TabPageClose as TabPage;
                if (tpCurrent.Tag is LBUIPageBase)
                {
                    LBUIPageBase pageBase = tpCurrent.Tag as LBUIPageBase;
                    //pageBase.Dispose();
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
            
        }

        private void TcMain_TabPageClosingEvent(object sender, Controls.Args.TabPageClosingEventArgs e)
        {
            try
            {
                TabPage tpCurrent = e.TabPageClose as TabPage;
                if (tpCurrent.Tag is LBUIPageBase)
                {
                    LBUIPageBase pageBase = tpCurrent.Tag as LBUIPageBase;
                    bool bolCancel = false;
                    pageBase.StartClose(out bolCancel);
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
            SetLoginStatus();//设置状态栏信息
            LBLog.AssemblyStart();
        }

        #endregion

        #region -- 状态栏信息 --

        private void SetLoginStatus()
        {
            this.lblLoginTime.Text = LoginInfo.LoginTime.ToString("yyyy-MM-dd HH:mm");
            this.lblLoginName.Text = LoginInfo.LoginName;
        }

        private delegate void setRichTexBox(string s);
        private void TestServerConnectStatus()
        {
            while (true)
            {
                if (bolIsClosing)
                {
                    break;
                }
                try
                {
                    bool bolConnected = ExecuteSQL.TestConnectStatus();
                    if (bolConnected)
                    {
                        this.Invoke((MethodInvoker)delegate {
                            this.lblConnectStatus.Text = "正常";
                            this.lblConnectStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                        });
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)delegate {
                            this.lblConnectStatus.Text = "异常";
                            this.lblConnectStatus.ForeColor = Color.Red;
                        });
                    }
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate {
                        this.lblConnectStatus.Text = "异常";
                        this.lblConnectStatus.ForeColor = Color.Red;
                    });
                }
                finally
                {
                    Thread.Sleep(1000 * 2);
                }
            }
        }

        #endregion

    }
}
