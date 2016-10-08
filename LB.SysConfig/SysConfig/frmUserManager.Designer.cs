using LB.Controls;

namespace LB.SysConfig
{
    partial class frmUserManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdMain = new LB.Controls.LBDataGridView(this.components);
            this.skinToolStrip1 = new CCWin.SkinControl.SkinToolStrip();
            this.btnClose = new LB.Controls.LBToolStripButton(this.components);
            this.btnSave = new LB.Controls.LBToolStripButton(this.components);
            this.btnReflesh = new LB.Controls.LBToolStripButton(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Delete = new LB.Controls.LBDataGridViewButtonColumn();
            this.ChangeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserType = new LB.Controls.LBDataGridViewComboBoxColumn();
            this.UserSex = new LB.Controls.LBDataGridViewComboBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new LB.Controls.LBToolStripButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.skinToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdMain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.grdMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMain.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdMain.ColumnFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginName,
            this.UserName,
            this.UserSex,
            this.UserType,
            this.ChangeTime,
            this.Delete});
            this.grdMain.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMain.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdMain.EnableHeadersVisualStyles = false;
            this.grdMain.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdMain.HeadFont = null;
            this.grdMain.HeadForeColor = System.Drawing.Color.Empty;
            this.grdMain.HeadSelectBackColor = System.Drawing.Color.Empty;
            this.grdMain.HeadSelectForeColor = System.Drawing.Color.Empty;
            this.grdMain.LineNumberForeColor = System.Drawing.Color.MidnightBlue;
            this.grdMain.Location = new System.Drawing.Point(0, 40);
            this.grdMain.Name = "grdMain";
            this.grdMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdMain.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdMain.RowTemplate.Height = 23;
            this.grdMain.Size = new System.Drawing.Size(649, 293);
            this.grdMain.TabIndex = 1;
            this.grdMain.TitleBack = null;
            this.grdMain.TitleBackColorBegin = System.Drawing.Color.White;
            this.grdMain.TitleBackColorEnd = System.Drawing.SystemColors.ActiveBorder;
            // 
            // skinToolStrip1
            // 
            this.skinToolStrip1.Arrow = System.Drawing.Color.Black;
            this.skinToolStrip1.Back = System.Drawing.Color.White;
            this.skinToolStrip1.BackRadius = 4;
            this.skinToolStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinToolStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinToolStrip1.BaseForeAnamorphosis = false;
            this.skinToolStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip1.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinToolStrip1.BaseItemAnamorphosis = true;
            this.skinToolStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemBorderShow = true;
            this.skinToolStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemDown")));
            this.skinToolStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemMouse")));
            this.skinToolStrip1.BaseItemNorml = null;
            this.skinToolStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemRadius = 4;
            this.skinToolStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BindTabControl = null;
            this.skinToolStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip1.Fore = System.Drawing.Color.Black;
            this.skinToolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStrip1.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip1.ItemAnamorphosis = true;
            this.skinToolStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemBorderShow = true;
            this.skinToolStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemRadius = 4;
            this.skinToolStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose,
            this.btnSave,
            this.btnAdd,
            this.btnReflesh,
            this.toolStripSeparator1});
            this.skinToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.skinToolStrip1.Name = "skinToolStrip1";
            this.skinToolStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.Size = new System.Drawing.Size(649, 40);
            this.skinToolStrip1.SkinAllColor = true;
            this.skinToolStrip1.TabIndex = 0;
            this.skinToolStrip1.Text = "skinToolStrip1";
            this.skinToolStrip1.TitleAnamorphosis = true;
            this.skinToolStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip1.TitleRadius = 4;
            this.skinToolStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::LB.Properties.Resources.btnClose;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.LBPermissionCode = "";
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 37);
            this.btnClose.Text = "关闭";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::LB.Properties.Resources.btnNewSave3;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.LBPermissionCode = "PMUserManager_Edit";
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 37);
            this.btnSave.Text = "保存";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReflesh
            // 
            this.btnReflesh.Image = ((System.Drawing.Image)(resources.GetObject("btnReflesh.Image")));
            this.btnReflesh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReflesh.LBPermissionCode = "";
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Size = new System.Drawing.Size(36, 37);
            this.btnReflesh.Text = "刷新";
            this.btnReflesh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // Delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "删除";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.Delete.HeaderText = "删除";
            this.Delete.LBPermissionCode = "PMUserManager_Del";
            this.Delete.Name = "Delete";
            this.Delete.Width = 60;
            // 
            // ChangeTime
            // 
            this.ChangeTime.DataPropertyName = "ChangeTime";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.ChangeTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.ChangeTime.HeaderText = "修改时间";
            this.ChangeTime.Name = "ChangeTime";
            this.ChangeTime.ReadOnly = true;
            this.ChangeTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChangeTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserType
            // 
            this.UserType.DataPropertyName = "UserType";
            this.UserType.FieldName = "UserType";
            this.UserType.HeaderText = "账户类型";
            this.UserType.Name = "UserType";
            this.UserType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UserSex
            // 
            this.UserSex.DataPropertyName = "UserSex";
            this.UserSex.FieldName = "UserSex";
            this.UserSex.HeaderText = "性别";
            this.UserSex.Name = "UserSex";
            this.UserSex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户名称";
            this.UserName.Name = "UserName";
            // 
            // LoginName
            // 
            this.LoginName.DataPropertyName = "LoginName";
            this.LoginName.HeaderText = "登录账户";
            this.LoginName.Name = "LoginName";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::LB.Properties.Resources.btnOpenAdd;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.LBPermissionCode = "PMUserManager_Add";
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 37);
            this.btnAdd.Text = "添加新用户";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdMain);
            this.Controls.Add(this.skinToolStrip1);
            this.LBPageTitle = "用户及权限管理";
            this.Name = "frmUserManager";
            this.Size = new System.Drawing.Size(649, 333);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.skinToolStrip1.ResumeLayout(false);
            this.skinToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinToolStrip skinToolStrip1;
        private Controls.LBToolStripButton btnClose;
        private Controls.LBToolStripButton btnSave;
        private LBDataGridView grdMain;
        private LBToolStripButton btnReflesh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private LBDataGridViewComboBoxColumn UserSex;
        private LBDataGridViewComboBoxColumn UserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeTime;
        private LBDataGridViewButtonColumn Delete;
        private LBToolStripButton btnAdd;
    }
}