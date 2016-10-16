namespace LB.MM
{
    partial class frmDevelopViewConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevelopViewConfig));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new LB.Controls.LBToolStripButton(this.components);
            this.grdMain = new LB.Controls.LBDataGridView(this.components);
            this.SysViewType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SysViewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new LB.Controls.LBSkinButton(this.components);
            this.txtFilter = new LB.Controls.LBTextBox.CoolTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lbToolStripButton1 = new LB.Controls.LBToolStripButton(this.components);
            this.lbToolStripButton3 = new LB.Controls.LBToolStripButton(this.components);
            this.lbToolStripButton2 = new LB.Controls.LBToolStripButton(this.components);
            this.lbToolStripButton4 = new LB.Controls.LBToolStripButton(this.components);
            this.lbToolStripButton5 = new LB.Controls.LBToolStripButton(this.components);
            this.lbToolStripButton6 = new LB.Controls.LBToolStripButton(this.components);
            this.lbToolStripButton7 = new LB.Controls.LBToolStripButton(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.lbToolStripButton7,
            this.lbToolStripButton6,
            this.lbToolStripButton5,
            this.lbToolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(398, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.LBPermissionCode = "";
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 37);
            this.btnSave.Text = "添加货物";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // grdMain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.grdMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMain.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdMain.ColumnFont = null;
            this.grdMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SysViewType,
            this.SysViewName,
            this.ItemMode,
            this.ItemRate,
            this.UOMName,
            this.ItemTypeName,
            this.ChangeBy,
            this.ChangeTime});
            this.grdMain.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdMain.EnableHeadersVisualStyles = false;
            this.grdMain.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdMain.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdMain.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdMain.LineNumberForeColor = System.Drawing.Color.MidnightBlue;
            this.grdMain.Location = new System.Drawing.Point(0, 45);
            this.grdMain.Name = "grdMain";
            this.grdMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdMain.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdMain.RowTemplate.Height = 23;
            this.grdMain.Size = new System.Drawing.Size(398, 300);
            this.grdMain.TabIndex = 1;
            this.grdMain.TitleBack = null;
            this.grdMain.TitleBackColorBegin = System.Drawing.Color.White;
            this.grdMain.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // SysViewType
            // 
            this.SysViewType.DataPropertyName = "ItemCode";
            this.SysViewType.HeaderText = "货物编码(kg/m3)";
            this.SysViewType.Name = "SysViewType";
            // 
            // SysViewName
            // 
            this.SysViewName.DataPropertyName = "ItemName";
            this.SysViewName.HeaderText = "货物名称";
            this.SysViewName.Name = "SysViewName";
            // 
            // ItemMode
            // 
            this.ItemMode.HeaderText = "规格";
            this.ItemMode.Name = "ItemMode";
            this.ItemMode.Width = 50;
            // 
            // ItemRate
            // 
            this.ItemRate.HeaderText = "比重";
            this.ItemRate.Name = "ItemRate";
            this.ItemRate.Width = 50;
            // 
            // UOMName
            // 
            this.UOMName.HeaderText = "单位";
            this.UOMName.Name = "UOMName";
            this.UOMName.Width = 50;
            // 
            // ItemTypeName
            // 
            this.ItemTypeName.HeaderText = "物料分类";
            this.ItemTypeName.Name = "ItemTypeName";
            this.ItemTypeName.Width = 60;
            // 
            // ChangeBy
            // 
            this.ChangeBy.HeaderText = "修改人";
            this.ChangeBy.Name = "ChangeBy";
            this.ChangeBy.Width = 80;
            // 
            // ChangeTime
            // 
            this.ChangeTime.HeaderText = "修改时间";
            this.ChangeTime.Name = "ChangeTime";
            this.ChangeTime.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 45);
            this.panel1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.LightGray;
            this.btnSearch.BorderColor = System.Drawing.Color.Gray;
            this.btnSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSearch.DownBack = null;
            this.btnSearch.LBPermissionCode = "";
            this.btnSearch.Location = new System.Drawing.Point(207, 11);
            this.btnSearch.MouseBack = null;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormlBack = null;
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.Transparent;
            this.txtFilter.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtFilter.LBTitle = "关键字";
            this.txtFilter.Location = new System.Drawing.Point(9, 11);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PopupWidth = 120;
            this.txtFilter.SelectedItemBackColor = System.Drawing.SystemColors.Highlight;
            this.txtFilter.SelectedItemForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtFilter.Size = new System.Drawing.Size(184, 25);
            this.txtFilter.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdMain);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(602, 345);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 40);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(200, 305);
            this.treeView1.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbToolStripButton1,
            this.lbToolStripButton3,
            this.lbToolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(200, 40);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lbToolStripButton1
            // 
            this.lbToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("lbToolStripButton1.Image")));
            this.lbToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lbToolStripButton1.LBPermissionCode = "";
            this.lbToolStripButton1.Name = "lbToolStripButton1";
            this.lbToolStripButton1.Size = new System.Drawing.Size(60, 37);
            this.lbToolStripButton1.Text = "添加分类";
            this.lbToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lbToolStripButton3
            // 
            this.lbToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("lbToolStripButton3.Image")));
            this.lbToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lbToolStripButton3.LBPermissionCode = "";
            this.lbToolStripButton3.Name = "lbToolStripButton3";
            this.lbToolStripButton3.Size = new System.Drawing.Size(60, 37);
            this.lbToolStripButton3.Text = "删除分类";
            this.lbToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lbToolStripButton2
            // 
            this.lbToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("lbToolStripButton2.Image")));
            this.lbToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lbToolStripButton2.LBPermissionCode = "";
            this.lbToolStripButton2.Name = "lbToolStripButton2";
            this.lbToolStripButton2.Size = new System.Drawing.Size(48, 37);
            this.lbToolStripButton2.Text = "修改类";
            this.lbToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lbToolStripButton4
            // 
            this.lbToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("lbToolStripButton4.Image")));
            this.lbToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lbToolStripButton4.LBPermissionCode = "";
            this.lbToolStripButton4.Name = "lbToolStripButton4";
            this.lbToolStripButton4.Size = new System.Drawing.Size(36, 37);
            this.lbToolStripButton4.Text = "排序";
            this.lbToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lbToolStripButton5
            // 
            this.lbToolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("lbToolStripButton5.Image")));
            this.lbToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lbToolStripButton5.LBPermissionCode = "";
            this.lbToolStripButton5.Name = "lbToolStripButton5";
            this.lbToolStripButton5.Size = new System.Drawing.Size(60, 37);
            this.lbToolStripButton5.Text = "表格设置";
            this.lbToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lbToolStripButton6
            // 
            this.lbToolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("lbToolStripButton6.Image")));
            this.lbToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lbToolStripButton6.LBPermissionCode = "";
            this.lbToolStripButton6.Name = "lbToolStripButton6";
            this.lbToolStripButton6.Size = new System.Drawing.Size(36, 37);
            this.lbToolStripButton6.Text = "刷新";
            this.lbToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lbToolStripButton7
            // 
            this.lbToolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("lbToolStripButton7.Image")));
            this.lbToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lbToolStripButton7.LBPermissionCode = "";
            this.lbToolStripButton7.Name = "lbToolStripButton7";
            this.lbToolStripButton7.Size = new System.Drawing.Size(60, 37);
            this.lbToolStripButton7.Text = "打开编辑";
            this.lbToolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmDevelopViewConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.LBPageTitle = "视图配置";
            this.Name = "frmDevelopViewConfig";
            this.Size = new System.Drawing.Size(602, 345);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private Controls.LBToolStripButton btnSave;
        private Controls.LBDataGridView grdMain;
        private System.Windows.Forms.Panel panel1;
        private Controls.LBTextBox.CoolTextBox txtFilter;
        private Controls.LBSkinButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SysViewType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SysViewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeTime;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private Controls.LBToolStripButton lbToolStripButton1;
        private Controls.LBToolStripButton lbToolStripButton3;
        private Controls.LBToolStripButton lbToolStripButton2;
        private Controls.LBToolStripButton lbToolStripButton7;
        private Controls.LBToolStripButton lbToolStripButton6;
        private Controls.LBToolStripButton lbToolStripButton5;
        private Controls.LBToolStripButton lbToolStripButton4;
    }
}