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
            this.btnDropDownDevice = new LB.Controls.LBToolStripDropDownButton(this.components);
            this.btnWeightDevice = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnCameraDevice = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnDDBaseManager = new LB.Controls.LBToolStripDropDownButton(this.components);
            this.btnItemBaseManager = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnUOMManager = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDescriptionManager = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCarWeightManager = new LB.Controls.LBToolStripMenuItem(this.components);
            this.lbToolStripDropDownButton1 = new LB.Controls.LBToolStripDropDownButton(this.components);
            this.btnAddCustomer = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnCustomerManager = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnAddCar = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnAddChangePriceBill = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnChangePriceManager = new LB.Controls.LBToolStripMenuItem(this.components);
            this.lbToolStripDropDownButton2 = new LB.Controls.LBToolStripDropDownButton(this.components);
            this.btnSaleInOutManager = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnDropDownReceive = new LB.Controls.LBToolStripDropDownButton(this.components);
            this.btnRPReceive = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnRPReceiveList = new LB.Controls.LBToolStripMenuItem(this.components);
            this.btnAbort = new LB.Controls.LBToolStripDropDownButton(this.components);
            this.版本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new LB.Controls.LBTabControl.LBMainTabControl(this.components);
            this.tpMain = new DMSkin.Metro.Controls.MetroTabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoginTime = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.btnDDSystemManager,
            this.btnDropDownDevice,
            this.btnDDBaseManager,
            this.lbToolStripDropDownButton1,
            this.lbToolStripDropDownButton2,
            this.btnDropDownReceive,
            this.btnAbort});
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
            this.btnDDSystemManager.Image = global::LB.MainForm.Properties.Resources.btnConfig;
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
            this.btnChangePassword.Size = new System.Drawing.Size(152, 22);
            this.btnChangePassword.Text = "修改密码";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnDBBackUp
            // 
            this.btnDBBackUp.LBPermissionCode = "DBBackUp_Query";
            this.btnDBBackUp.Name = "btnDBBackUp";
            this.btnDBBackUp.Size = new System.Drawing.Size(152, 22);
            this.btnDBBackUp.Text = "帐套备份设置";
            this.btnDBBackUp.Click += new System.EventHandler(this.btnDBBackUp_Click);
            // 
            // btnUserManager
            // 
            this.btnUserManager.LBPermissionCode = "PMUserManager_Query";
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Size = new System.Drawing.Size(152, 22);
            this.btnUserManager.Text = "用户权限管理";
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            // 
            // btnLogManager
            // 
            this.btnLogManager.LBPermissionCode = "LogManager_Query";
            this.btnLogManager.Name = "btnLogManager";
            this.btnLogManager.Size = new System.Drawing.Size(152, 22);
            this.btnLogManager.Text = "操作日志";
            this.btnLogManager.Click += new System.EventHandler(this.btnLogManager_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.LBPermissionCode = "";
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 22);
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
            this.tsmConfig.Size = new System.Drawing.Size(152, 22);
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
            // btnDropDownDevice
            // 
            this.btnDropDownDevice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnWeightDevice,
            this.btnCameraDevice});
            this.btnDropDownDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnDropDownDevice.Image")));
            this.btnDropDownDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDropDownDevice.LBPermissionCode = "";
            this.btnDropDownDevice.Name = "btnDropDownDevice";
            this.btnDropDownDevice.Size = new System.Drawing.Size(85, 22);
            this.btnDropDownDevice.Text = "设备管理";
            // 
            // btnWeightDevice
            // 
            this.btnWeightDevice.LBPermissionCode = "";
            this.btnWeightDevice.Name = "btnWeightDevice";
            this.btnWeightDevice.Size = new System.Drawing.Size(148, 22);
            this.btnWeightDevice.Text = "地磅仪表设置";
            this.btnWeightDevice.Click += new System.EventHandler(this.btnWeightDevice_Click);
            // 
            // btnCameraDevice
            // 
            this.btnCameraDevice.LBPermissionCode = "";
            this.btnCameraDevice.Name = "btnCameraDevice";
            this.btnCameraDevice.Size = new System.Drawing.Size(148, 22);
            this.btnCameraDevice.Text = "摄像头设置";
            this.btnCameraDevice.Click += new System.EventHandler(this.btnCameraDevice_Click);
            // 
            // btnDDBaseManager
            // 
            this.btnDDBaseManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnItemBaseManager,
            this.btnUOMManager,
            this.btnDescriptionManager,
            this.btnCarWeightManager});
            this.btnDDBaseManager.Image = ((System.Drawing.Image)(resources.GetObject("btnDDBaseManager.Image")));
            this.btnDDBaseManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDDBaseManager.LBPermissionCode = "PMSystemManager";
            this.btnDDBaseManager.Name = "btnDDBaseManager";
            this.btnDDBaseManager.Size = new System.Drawing.Size(109, 22);
            this.btnDDBaseManager.Text = "基础资料管理";
            // 
            // btnItemBaseManager
            // 
            this.btnItemBaseManager.LBPermissionCode = "PMChangePassword";
            this.btnItemBaseManager.Name = "btnItemBaseManager";
            this.btnItemBaseManager.Size = new System.Drawing.Size(152, 22);
            this.btnItemBaseManager.Text = "物料管理";
            this.btnItemBaseManager.Click += new System.EventHandler(this.btnItemBaseManager_Click);
            // 
            // btnUOMManager
            // 
            this.btnUOMManager.Name = "btnUOMManager";
            this.btnUOMManager.Size = new System.Drawing.Size(148, 22);
            this.btnUOMManager.Text = "计量单位管理";
            this.btnUOMManager.Click += new System.EventHandler(this.btnUOMManager_Click);
            // 
            // btnDescriptionManager
            // 
            this.btnDescriptionManager.Name = "btnDescriptionManager";
            this.btnDescriptionManager.Size = new System.Drawing.Size(148, 22);
            this.btnDescriptionManager.Text = "备注管理";
            this.btnDescriptionManager.Click += new System.EventHandler(this.btnDescriptionManager_Click);
            // 
            // btnCarWeightManager
            // 
            this.btnCarWeightManager.LBPermissionCode = "";
            this.btnCarWeightManager.Name = "btnCarWeightManager";
            this.btnCarWeightManager.Size = new System.Drawing.Size(148, 22);
            this.btnCarWeightManager.Text = "车辆皮重管理";
            this.btnCarWeightManager.Click += new System.EventHandler(this.btnCarWeightManager_Click);
            // 
            // lbToolStripDropDownButton1
            // 
            this.lbToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCustomer,
            this.btnCustomerManager,
            this.btnAddCar,
            this.btnAddChangePriceBill,
            this.btnChangePriceManager});
            this.lbToolStripDropDownButton1.Image = global::LB.MainForm.Properties.Resources.MenuIcon031;
            this.lbToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lbToolStripDropDownButton1.LBPermissionCode = "";
            this.lbToolStripDropDownButton1.Name = "lbToolStripDropDownButton1";
            this.lbToolStripDropDownButton1.Size = new System.Drawing.Size(85, 22);
            this.lbToolStripDropDownButton1.Text = "客户管理";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.LBPermissionCode = "";
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(148, 22);
            this.btnAddCustomer.Text = "添加客户";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnCustomerManager
            // 
            this.btnCustomerManager.LBPermissionCode = "";
            this.btnCustomerManager.Name = "btnCustomerManager";
            this.btnCustomerManager.Size = new System.Drawing.Size(148, 22);
            this.btnCustomerManager.Text = "客户资料管理";
            this.btnCustomerManager.Click += new System.EventHandler(this.btnCustomerManager_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.LBPermissionCode = "";
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(148, 22);
            this.btnAddCar.Text = "添加车辆";
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnAddChangePriceBill
            // 
            this.btnAddChangePriceBill.LBPermissionCode = "";
            this.btnAddChangePriceBill.Name = "btnAddChangePriceBill";
            this.btnAddChangePriceBill.Size = new System.Drawing.Size(148, 22);
            this.btnAddChangePriceBill.Text = "添加调价单";
            this.btnAddChangePriceBill.Click += new System.EventHandler(this.btnAddChangePriceBill_Click);
            // 
            // btnChangePriceManager
            // 
            this.btnChangePriceManager.LBPermissionCode = "";
            this.btnChangePriceManager.Name = "btnChangePriceManager";
            this.btnChangePriceManager.Size = new System.Drawing.Size(148, 22);
            this.btnChangePriceManager.Text = "调价单管理";
            this.btnChangePriceManager.Click += new System.EventHandler(this.btnChangePriceManager_Click);
            // 
            // lbToolStripDropDownButton2
            // 
            this.lbToolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaleInOutManager});
            this.lbToolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("lbToolStripDropDownButton2.Image")));
            this.lbToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lbToolStripDropDownButton2.LBPermissionCode = "";
            this.lbToolStripDropDownButton2.Name = "lbToolStripDropDownButton2";
            this.lbToolStripDropDownButton2.Size = new System.Drawing.Size(85, 22);
            this.lbToolStripDropDownButton2.Text = "销售管理";
            // 
            // btnSaleInOutManager
            // 
            this.btnSaleInOutManager.LBPermissionCode = "";
            this.btnSaleInOutManager.Name = "btnSaleInOutManager";
            this.btnSaleInOutManager.Size = new System.Drawing.Size(148, 22);
            this.btnSaleInOutManager.Text = "销售磅单管理";
            this.btnSaleInOutManager.Click += new System.EventHandler(this.btnSaleInOutManager_Click);
            // 
            // btnDropDownReceive
            // 
            this.btnDropDownReceive.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRPReceive,
            this.btnRPReceiveList});
            this.btnDropDownReceive.Image = global::LB.MainForm.Properties.Resources.btnBalanceApportion;
            this.btnDropDownReceive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDropDownReceive.LBPermissionCode = "";
            this.btnDropDownReceive.Name = "btnDropDownReceive";
            this.btnDropDownReceive.Size = new System.Drawing.Size(85, 22);
            this.btnDropDownReceive.Text = "收款管理";
            // 
            // btnRPReceive
            // 
            this.btnRPReceive.LBPermissionCode = "";
            this.btnRPReceive.Name = "btnRPReceive";
            this.btnRPReceive.Size = new System.Drawing.Size(124, 22);
            this.btnRPReceive.Text = "充值";
            this.btnRPReceive.Click += new System.EventHandler(this.btnRPReceive_Click);
            // 
            // btnRPReceiveList
            // 
            this.btnRPReceiveList.LBPermissionCode = "";
            this.btnRPReceiveList.Name = "btnRPReceiveList";
            this.btnRPReceiveList.Size = new System.Drawing.Size(124, 22);
            this.btnRPReceiveList.Text = "充值记录";
            this.btnRPReceiveList.Click += new System.EventHandler(this.btnRPReceiveList_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本信息ToolStripMenuItem,
            this.关于我们ToolStripMenuItem});
            this.btnAbort.Image = ((System.Drawing.Image)(resources.GetObject("btnAbort.Image")));
            this.btnAbort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbort.LBPermissionCode = "";
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(61, 22);
            this.btnAbort.Text = "关于";
            // 
            // 版本信息ToolStripMenuItem
            // 
            this.版本信息ToolStripMenuItem.Name = "版本信息ToolStripMenuItem";
            this.版本信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.版本信息ToolStripMenuItem.Text = "版本信息";
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于我们ToolStripMenuItem.Text = "关于我们";
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
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(78, 22);
            this.toolStripStatusLabel3.Text = "登录时间:";
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.AutoSize = false;
            this.lblLoginTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(161, 22);
            this.lblLoginTime.Text = "2016-10-14 20:30    ";
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
        private LBToolStripDropDownButton btnDropDownReceive;
        private LBToolStripMenuItem btnRPReceive;
        private LBToolStripMenuItem btnRPReceiveList;
        private LBToolStripDropDownButton btnDDBaseManager;
        private LBToolStripMenuItem btnItemBaseManager;
        private LBToolStripDropDownButton lbToolStripDropDownButton1;
        private LBToolStripMenuItem btnAddCustomer;
        private LBToolStripMenuItem btnCustomerManager;
        private LBToolStripMenuItem btnAddCar;
        private LBToolStripMenuItem btnAddChangePriceBill;
        private LBToolStripMenuItem btnChangePriceManager;
        private LBToolStripDropDownButton btnAbort;
        private System.Windows.Forms.ToolStripMenuItem 版本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnUOMManager;
        private System.Windows.Forms.ToolStripMenuItem btnDescriptionManager;
        private LBToolStripDropDownButton btnDropDownDevice;
        private LBToolStripMenuItem btnWeightDevice;
        private LBToolStripMenuItem btnCameraDevice;
        private LBToolStripMenuItem btnCarWeightManager;
        private LBToolStripDropDownButton lbToolStripDropDownButton2;
        private LBToolStripMenuItem btnSaleInOutManager;
    }
}

