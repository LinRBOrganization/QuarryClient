﻿using LB.Controls;

namespace LB.MainForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDDSystemManager = new LB.Controls.LBToolStripDropDownButton(this.components);
            this.btnChangePassword = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnDBBackUp = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnUserManager = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnLogManager = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnCancel = new LB.Controls.LBToolStripMenuItem(this.components);
            this.tsmConfig = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnViewConfig = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnPermissionConfig = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnSQLBuilder = new LB.Controls.LBToolStripMenuItem(this.components);
            this.tcMain = new LB.Controls.LBTabControl.LBMainTabControl(this.components);
            this.tpMain = new DMSkin.Metro.Controls.MetroTabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.lblLoginTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConnectStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDDSystemManager});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(893, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDDSystemManager
            // 
            this.btnDDSystemManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePassword,
            this.btnDBBackUp,
            this.btnUserManager,
            this.btnLogManager,
            this.btnCancel,
            this.tsmConfig});
            this.btnDDSystemManager.Image = ((System.Drawing.Image)(resources.GetObject("btnDDSystemManager.Image")));
            this.btnDDSystemManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDDSystemManager.LBPermissionCode = "PMSystemManager";
            this.btnDDSystemManager.Name = "btnDDSystemManager";
            this.btnDDSystemManager.Size = new System.Drawing.Size(85, 22);
            this.btnDDSystemManager.Text = "系统管理";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.LBPermissionCode = "PMChangePassword";
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(148, 22);
            this.btnChangePassword.Text = "修改密码";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnDBBackUp
            // 
            this.btnDBBackUp.LBPermissionCode = "DBBackUp_Query";
            this.btnDBBackUp.Name = "btnDBBackUp";
            this.btnDBBackUp.Size = new System.Drawing.Size(148, 22);
            this.btnDBBackUp.Text = "帐套备份设置";
            this.btnDBBackUp.Click += new System.EventHandler(this.btnDBBackUp_Click);
            // 
            // btnUserManager
            // 
            this.btnUserManager.LBPermissionCode = "PMUserManager_Query";
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Size = new System.Drawing.Size(148, 22);
            this.btnUserManager.Text = "用户权限管理";
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            // 
            // btnLogManager
            // 
            this.btnLogManager.LBPermissionCode = "LogManager_Query";
            this.btnLogManager.Name = "btnLogManager";
            this.btnLogManager.Size = new System.Drawing.Size(148, 22);
            this.btnLogManager.Text = "操作日志";
            this.btnLogManager.Click += new System.EventHandler(this.btnLogManager_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.LBPermissionCode = "";
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 22);
            this.btnCancel.Text = "注销";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tsmConfig
            // 
            this.tsmConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewConfig,
            this.btnPermissionConfig,
            this.btnSQLBuilder});
            this.tsmConfig.LBPermissionCode = "";
            this.tsmConfig.Name = "tsmConfig";
            this.tsmConfig.Size = new System.Drawing.Size(148, 22);
            this.tsmConfig.Text = "开发配置管理";
            // 
            // btnViewConfig
            // 
            this.btnViewConfig.LBPermissionCode = "";
            this.btnViewConfig.Name = "btnViewConfig";
            this.btnViewConfig.Size = new System.Drawing.Size(135, 22);
            this.btnViewConfig.Text = "视图配置";
            this.btnViewConfig.Click += new System.EventHandler(this.btnViewConfig_Click);
            // 
            // btnPermissionConfig
            // 
            this.btnPermissionConfig.LBPermissionCode = "";
            this.btnPermissionConfig.Name = "btnPermissionConfig";
            this.btnPermissionConfig.Size = new System.Drawing.Size(135, 22);
            this.btnPermissionConfig.Text = "权限配置";
            this.btnPermissionConfig.Click += new System.EventHandler(this.btnPermissionConfig_Click);
            // 
            // btnSQLBuilder
            // 
            this.btnSQLBuilder.LBPermissionCode = "";
            this.btnSQLBuilder.Name = "btnSQLBuilder";
            this.btnSQLBuilder.Size = new System.Drawing.Size(135, 22);
            this.btnSQLBuilder.Text = "SQL生成器";
            this.btnSQLBuilder.Click += new System.EventHandler(this.btnSQLBuilder_Click);
            // 
            // tcMain
            // 
            this.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.tcMain.DM_FontSize = DMSkin.Metro.MetroTabControlSize.Tall;
            this.tcMain.DM_UseSelectable = true;
            this.tcMain.DM_UseStyleColors = true;
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 25);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(893, 325);
            this.tcMain.Style = DMSkin.Metro.MetroColorStyle.Blue;
            this.tcMain.TabIndex = 1;
            // 
            // tpMain
            // 
            this.tpMain.HorizontalScrollbarBarColor = true;
            this.tpMain.HorizontalScrollbarDM_HighlightOnWheel = false;
            this.tpMain.HorizontalScrollbarSize = 10;
            this.tpMain.Location = new System.Drawing.Point(4, 46);
            this.tpMain.Name = "tpMain";
            this.tpMain.Size = new System.Drawing.Size(885, 275);
            this.tpMain.Style = DMSkin.Metro.MetroColorStyle.Blue;
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "主界面";
            this.tpMain.VerticalScrollbarBarColor = true;
            this.tpMain.VerticalScrollbarDM_HighlightOnWheel = false;
            this.tpMain.VerticalScrollbarSize = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblLoginName,
            this.toolStripSplitButton1,
            this.toolStripStatusLabel3,
            this.lblLoginTime,
            this.toolStripStatusLabel4,
            this.lblConnectStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(893, 27);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 22);
            this.toolStripStatusLabel1.Text = "当前登录用户：";
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = false;
            this.lblLoginName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(92, 22);
            this.lblLoginName.Text = "阿斯顿";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 25);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.AutoSize = false;
            this.lblLoginTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(161, 22);
            this.lblLoginTime.Text = "2016-10-14 20:30    ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(78, 22);
            this.toolStripStatusLabel3.Text = "登录时间:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(126, 22);
            this.toolStripStatusLabel4.Text = "服务器连接状态:";
            // 
            // lblConnectStatus
            // 
            this.lblConnectStatus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lblConnectStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblConnectStatus.Name = "lblConnectStatus";
            this.lblConnectStatus.Size = new System.Drawing.Size(42, 22);
            this.lblConnectStatus.Text = "正常";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 377);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "石场管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private Controls.LBToolStripDropDownButton btnDDSystemManager;
        private Controls.LBToolStripMenuItem btnChangePassword;
        private LBToolStripMenuItem btnCancel;
        private LBToolStripMenuItem btnUserManager;
        private LBToolStripMenuItem tsmConfig;
        private LBToolStripMenuItem btnViewConfig;
        private LBToolStripMenuItem btnPermissionConfig;
        private LBToolStripMenuItem btnSQLBuilder;
        private Controls.LBTabControl.LBMainTabControl tcMain;
        private DMSkin.Metro.Controls.MetroTabPage tpMain;
        private LBToolStripMenuItem btnLogManager;
        private LBToolStripMenuItem btnDBBackUp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginName;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblConnectStatus;
    }
}

