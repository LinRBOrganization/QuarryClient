namespace LB.MI.MI
{
    partial class frmSaleCarInOutBillManager
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleCarInOutBillManager));
            this.ctlSearcher1 = new LB.Controls.Searcher.CtlSearcher();
            this.grdMain = new LB.Controls.LBDataGridView(this.components);
            this.txtBillDateTo = new DMSkin.Metro.Controls.MetroDateTime();
            this.skinLabel19 = new CCWin.SkinControl.SkinLabel();
            this.txtBillDateFrom = new DMSkin.Metro.Controls.MetroDateTime();
            this.skinLabel18 = new CCWin.SkinControl.SkinLabel();
            this.skinToolStrip1 = new CCWin.SkinControl.SkinToolStrip();
            this.btnClose = new LB.Controls.LBToolStripButton(this.components);
            this.btnReflesh = new LB.Controls.LBToolStripButton(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnApprove = new LB.Controls.LBToolStripButton(this.components);
            this.btnUnApprove = new LB.Controls.LBToolStripButton(this.components);
            this.btnCancel = new LB.Controls.LBToolStripButton(this.components);
            this.btnUnCancel = new LB.Controls.LBToolStripButton(this.components);
            this.BillDateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleCarInBillCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillStatus = new LB.Controls.LBDataGridViewComboBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarTare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuttleWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculateType = new LB.Controls.LBDataGridViewComboBoxColumn();
            this.CreateByIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateByOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleCarInBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.skinToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlSearcher1
            // 
            this.ctlSearcher1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlSearcher1.Location = new System.Drawing.Point(0, 40);
            this.ctlSearcher1.Name = "ctlSearcher1";
            this.ctlSearcher1.Size = new System.Drawing.Size(971, 47);
            this.ctlSearcher1.TabIndex = 8;
            // 
            // grdMain
            // 
            this.grdMain.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.grdMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMain.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdMain.ColumnFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillDateIn,
            this.BillDateOut,
            this.SaleCarInBillCode,
            this.BillStatus,
            this.CustomerName,
            this.CarNum,
            this.ItemName,
            this.TotalWeight,
            this.CarTare,
            this.SuttleWeight,
            this.Price,
            this.Amount,
            this.CalculateType,
            this.CreateByIn,
            this.CreateTimeIn,
            this.CreateByOut,
            this.CreateTimeOut,
            this.SaleCarInBillID});
            this.grdMain.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdMain.EnableHeadersVisualStyles = false;
            this.grdMain.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdMain.HeadFont = null;
            this.grdMain.HeadForeColor = System.Drawing.Color.Empty;
            this.grdMain.HeadSelectBackColor = System.Drawing.Color.Empty;
            this.grdMain.HeadSelectForeColor = System.Drawing.Color.Empty;
            this.grdMain.LineNumberForeColor = System.Drawing.Color.MidnightBlue;
            this.grdMain.Location = new System.Drawing.Point(0, 87);
            this.grdMain.Name = "grdMain";
            this.grdMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdMain.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdMain.RowTemplate.Height = 23;
            this.grdMain.Size = new System.Drawing.Size(971, 256);
            this.grdMain.TabIndex = 9;
            this.grdMain.TitleBack = null;
            this.grdMain.TitleBackColorBegin = System.Drawing.Color.White;
            this.grdMain.TitleBackColorEnd = System.Drawing.SystemColors.ActiveBorder;
            // 
            // txtBillDateTo
            // 
            this.txtBillDateTo.Location = new System.Drawing.Point(711, 49);
            this.txtBillDateTo.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtBillDateTo.Name = "txtBillDateTo";
            this.txtBillDateTo.Size = new System.Drawing.Size(134, 30);
            this.txtBillDateTo.TabIndex = 30;
            // 
            // skinLabel19
            // 
            this.skinLabel19.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel19.BorderColor = System.Drawing.Color.White;
            this.skinLabel19.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.skinLabel19.Location = new System.Drawing.Point(681, 55);
            this.skinLabel19.Name = "skinLabel19";
            this.skinLabel19.Size = new System.Drawing.Size(24, 21);
            this.skinLabel19.TabIndex = 29;
            this.skinLabel19.Text = "至";
            this.skinLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBillDateFrom
            // 
            this.txtBillDateFrom.Location = new System.Drawing.Point(541, 51);
            this.txtBillDateFrom.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtBillDateFrom.Name = "txtBillDateFrom";
            this.txtBillDateFrom.Size = new System.Drawing.Size(134, 30);
            this.txtBillDateFrom.TabIndex = 27;
            // 
            // skinLabel18
            // 
            this.skinLabel18.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel18.BorderColor = System.Drawing.Color.White;
            this.skinLabel18.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.skinLabel18.Location = new System.Drawing.Point(457, 55);
            this.skinLabel18.Name = "skinLabel18";
            this.skinLabel18.Size = new System.Drawing.Size(86, 21);
            this.skinLabel18.TabIndex = 28;
            this.skinLabel18.Text = "过磅日期";
            this.skinLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnReflesh,
            this.toolStripSeparator1,
            this.btnApprove,
            this.btnUnApprove,
            this.btnCancel,
            this.btnUnCancel});
            this.skinToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.skinToolStrip1.Name = "skinToolStrip1";
            this.skinToolStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.Size = new System.Drawing.Size(971, 40);
            this.skinToolStrip1.SkinAllColor = true;
            this.skinToolStrip1.TabIndex = 7;
            this.skinToolStrip1.Text = "skinToolStrip1";
            this.skinToolStrip1.TitleAnamorphosis = true;
            this.skinToolStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip1.TitleRadius = 4;
            this.skinToolStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.LBPermissionCode = "";
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 37);
            this.btnClose.Text = "关闭";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // btnApprove
            // 
            this.btnApprove.Image = global::LB.MI.Properties.Resources.btnApprove;
            this.btnApprove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnApprove.LBPermissionCode = "";
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(60, 37);
            this.btnApprove.Text = "批量审核";
            this.btnApprove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnUnApprove
            // 
            this.btnUnApprove.Image = global::LB.MI.Properties.Resources.btnUnApprove;
            this.btnUnApprove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnApprove.LBPermissionCode = "";
            this.btnUnApprove.Name = "btnUnApprove";
            this.btnUnApprove.Size = new System.Drawing.Size(84, 37);
            this.btnUnApprove.Text = "批量取消审核";
            this.btnUnApprove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUnApprove.Click += new System.EventHandler(this.btnUnApprove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::LB.MI.Properties.Resources.btnUnPostInUse;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.LBPermissionCode = "";
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 37);
            this.btnCancel.Text = "批量作废";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUnCancel
            // 
            this.btnUnCancel.Image = global::LB.MI.Properties.Resources.btnReset;
            this.btnUnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnCancel.LBPermissionCode = "";
            this.btnUnCancel.Name = "btnUnCancel";
            this.btnUnCancel.Size = new System.Drawing.Size(84, 37);
            this.btnUnCancel.Text = "批量取消作废";
            this.btnUnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUnCancel.Click += new System.EventHandler(this.btnUnCancel_Click);
            // 
            // BillDateIn
            // 
            this.BillDateIn.DataPropertyName = "BillDateIn";
            this.BillDateIn.HeaderText = "入场过磅时间";
            this.BillDateIn.Name = "BillDateIn";
            this.BillDateIn.ReadOnly = true;
            this.BillDateIn.Width = 200;
            // 
            // BillDateOut
            // 
            this.BillDateOut.DataPropertyName = "BillDateOut";
            this.BillDateOut.HeaderText = "出场过磅时间";
            this.BillDateOut.Name = "BillDateOut";
            this.BillDateOut.ReadOnly = true;
            this.BillDateOut.Width = 200;
            // 
            // SaleCarInBillCode
            // 
            this.SaleCarInBillCode.DataPropertyName = "SaleCarInBillCode";
            this.SaleCarInBillCode.HeaderText = "单号";
            this.SaleCarInBillCode.Name = "SaleCarInBillCode";
            this.SaleCarInBillCode.ReadOnly = true;
            // 
            // BillStatus
            // 
            this.BillStatus.DataPropertyName = "BillStatus";
            this.BillStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.BillStatus.FieldName = "BillStatus";
            this.BillStatus.HeaderText = "单据状态";
            this.BillStatus.Name = "BillStatus";
            this.BillStatus.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "客户名称";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CarNum
            // 
            this.CarNum.DataPropertyName = "CarNum";
            this.CarNum.HeaderText = "车号";
            this.CarNum.Name = "CarNum";
            this.CarNum.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "货物名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // TotalWeight
            // 
            this.TotalWeight.DataPropertyName = "TotalWeight";
            this.TotalWeight.HeaderText = "毛重";
            this.TotalWeight.Name = "TotalWeight";
            this.TotalWeight.ReadOnly = true;
            // 
            // CarTare
            // 
            this.CarTare.DataPropertyName = "CarTare";
            this.CarTare.HeaderText = "皮重";
            this.CarTare.Name = "CarTare";
            this.CarTare.ReadOnly = true;
            // 
            // SuttleWeight
            // 
            this.SuttleWeight.DataPropertyName = "SuttleWeight";
            this.SuttleWeight.HeaderText = "净重";
            this.SuttleWeight.Name = "SuttleWeight";
            this.SuttleWeight.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "单价";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "金额";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // CalculateType
            // 
            this.CalculateType.DataPropertyName = "CalculateType";
            this.CalculateType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CalculateType.FieldName = "CalculateType";
            this.CalculateType.HeaderText = "计价方式";
            this.CalculateType.Name = "CalculateType";
            this.CalculateType.ReadOnly = true;
            // 
            // CreateByIn
            // 
            this.CreateByIn.DataPropertyName = "CreateByIn";
            this.CreateByIn.HeaderText = "入磅创建人";
            this.CreateByIn.Name = "CreateByIn";
            this.CreateByIn.ReadOnly = true;
            // 
            // CreateTimeIn
            // 
            this.CreateTimeIn.DataPropertyName = "CreateTimeIn";
            this.CreateTimeIn.HeaderText = "入磅创建时间";
            this.CreateTimeIn.Name = "CreateTimeIn";
            this.CreateTimeIn.ReadOnly = true;
            this.CreateTimeIn.Width = 150;
            // 
            // CreateByOut
            // 
            this.CreateByOut.DataPropertyName = "CreateByOut";
            this.CreateByOut.HeaderText = "出磅创建人";
            this.CreateByOut.Name = "CreateByOut";
            this.CreateByOut.ReadOnly = true;
            // 
            // CreateTimeOut
            // 
            this.CreateTimeOut.DataPropertyName = "CreateTimeOut";
            this.CreateTimeOut.HeaderText = "出磅创建时间";
            this.CreateTimeOut.Name = "CreateTimeOut";
            this.CreateTimeOut.ReadOnly = true;
            this.CreateTimeOut.Width = 150;
            // 
            // SaleCarInBillID
            // 
            this.SaleCarInBillID.DataPropertyName = "SaleCarInBillID";
            this.SaleCarInBillID.HeaderText = "SaleCarInBillID";
            this.SaleCarInBillID.Name = "SaleCarInBillID";
            this.SaleCarInBillID.ReadOnly = true;
            this.SaleCarInBillID.Visible = false;
            // 
            // frmSaleCarInOutBillManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBillDateTo);
            this.Controls.Add(this.skinLabel19);
            this.Controls.Add(this.txtBillDateFrom);
            this.Controls.Add(this.skinLabel18);
            this.Controls.Add(this.grdMain);
            this.Controls.Add(this.ctlSearcher1);
            this.Controls.Add(this.skinToolStrip1);
            this.LBPageTitle = "磅单管理";
            this.Name = "frmSaleCarInOutBillManager";
            this.Size = new System.Drawing.Size(971, 343);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.skinToolStrip1.ResumeLayout(false);
            this.skinToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinToolStrip skinToolStrip1;
        private Controls.LBToolStripButton btnClose;
        private Controls.LBToolStripButton btnReflesh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Controls.Searcher.CtlSearcher ctlSearcher1;
        private Controls.LBDataGridView grdMain;
        private Controls.LBToolStripButton btnUnApprove;
        private Controls.LBToolStripButton btnApprove;
        private Controls.LBToolStripButton btnCancel;
        private Controls.LBToolStripButton btnUnCancel;
        private DMSkin.Metro.Controls.MetroDateTime txtBillDateTo;
        private CCWin.SkinControl.SkinLabel skinLabel19;
        private DMSkin.Metro.Controls.MetroDateTime txtBillDateFrom;
        private CCWin.SkinControl.SkinLabel skinLabel18;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDateIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDateOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleCarInBillCode;
        private Controls.LBDataGridViewComboBoxColumn BillStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarTare;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuttleWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private Controls.LBDataGridViewComboBoxColumn CalculateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateByIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateByOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleCarInBillID;
    }
}
