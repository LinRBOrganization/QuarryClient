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
            this.btnUserManager = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPermissionConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSQLBuilder = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new LB.Controls.LBTabControl.LBMainTabControl(this.components);
            this.tpMain = new DMSkin.Metro.Controls.MetroTabPage();
            this.toolStrip1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDDSystemManager});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(803, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDDSystemManager
            // 
            this.btnDDSystemManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePassword,
            this.btnUserManager,
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
            // btnUserManager
            // 
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Size = new System.Drawing.Size(148, 22);
            this.btnUserManager.Text = "用户权限管理";
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            // 
            // btnCancel
            // 
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
            this.tsmConfig.Name = "tsmConfig";
            this.tsmConfig.Size = new System.Drawing.Size(148, 22);
            this.tsmConfig.Text = "开发配置管理";
            // 
            // btnViewConfig
            // 
            this.btnViewConfig.Name = "btnViewConfig";
            this.btnViewConfig.Size = new System.Drawing.Size(135, 22);
            this.btnViewConfig.Text = "视图配置";
            this.btnViewConfig.Click += new System.EventHandler(this.btnViewConfig_Click);
            // 
            // btnPermissionConfig
            // 
            this.btnPermissionConfig.Name = "btnPermissionConfig";
            this.btnPermissionConfig.Size = new System.Drawing.Size(135, 22);
            this.btnPermissionConfig.Text = "权限配置";
            this.btnPermissionConfig.Click += new System.EventHandler(this.btnPermissionConfig_Click);
            // 
            // btnSQLBuilder
            // 
            this.btnSQLBuilder.Name = "btnSQLBuilder";
            this.btnSQLBuilder.Size = new System.Drawing.Size(135, 22);
            this.btnSQLBuilder.Text = "SQL生成器";
            this.btnSQLBuilder.Click += new System.EventHandler(this.btnSQLBuilder_Click);
            // 
            // tcMain
            // 
            this.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.DM_FontSize = DMSkin.Metro.MetroTabControlSize.Tall;
            this.tcMain.DM_UseSelectable = true;
            this.tcMain.DM_UseStyleColors = true;
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 25);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(803, 352);
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
            this.tpMain.Size = new System.Drawing.Size(795, 302);
            this.tpMain.Style = DMSkin.Metro.MetroColorStyle.Blue;
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "主界面";
            this.tpMain.VerticalScrollbarBarColor = true;
            this.tpMain.VerticalScrollbarDM_HighlightOnWheel = false;
            this.tpMain.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 377);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "石场管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private Controls.LBToolStripDropDownButton btnDDSystemManager;
        private Controls.LBToolStripMenuItem btnChangePassword;
        private System.Windows.Forms.ToolStripMenuItem btnCancel;
        private System.Windows.Forms.ToolStripMenuItem btnUserManager;
        private System.Windows.Forms.ToolStripMenuItem tsmConfig;
        private System.Windows.Forms.ToolStripMenuItem btnViewConfig;
        private System.Windows.Forms.ToolStripMenuItem btnPermissionConfig;
        private System.Windows.Forms.ToolStripMenuItem btnSQLBuilder;
        private Controls.LBTabControl.LBMainTabControl tcMain;
        private DMSkin.Metro.Controls.MetroTabPage tpMain;
    }
}

