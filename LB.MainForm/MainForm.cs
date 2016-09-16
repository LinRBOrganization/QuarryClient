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

namespace LB.MainForm
{
    public partial class MainForm : LBForm
    {
        public bool bolIsCancel = false;
        public MainForm()
        {
            InitializeComponent();
            LBShowForm.LBUIPageBaseAdded += LBShowForm_LBUIPageBaseAdded;
            this.tcMain.TabPageClosingEvent += TcMain_TabPageClosingEvent;
            this.tcMain.TabPageClosedEvent += TcMain_TabPageClosedEvent;
        }

        #region -- 按钮事件  --
        //注销
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

    }
}
