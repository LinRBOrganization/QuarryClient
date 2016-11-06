namespace LB.MI.MI
{
    partial class frmModifyBillHeaderQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifyBillHeaderQuery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctlSearcher1 = new LB.Controls.Searcher.CtlSearcher();
            this.txtSearchDropDown = new LB.Controls.LBMetroComboBox(this.components);
            this.txtSearchText = new LB.Controls.LBSkinTextBox(this.components);
            this.lbSkinTextBox1 = new LB.Controls.LBSkinTextBox(this.components);
            this.skinToolStrip1 = new CCWin.SkinControl.SkinToolStrip();
            this.btnClose = new LB.Controls.LBToolStripButton(this.components);
            this.btnAdd = new LB.Controls.LBToolStripButton(this.components);
            this.btnOpenEdit = new LB.Controls.LBToolStripButton(this.components);
            this.btnCopy = new LB.Controls.LBToolStripButton(this.components);
            this.btnReflesh = new LB.Controls.LBToolStripButton(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.grdMain = new LB.Controls.LBDataGridView(this.components);
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyBillCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculateTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsApprove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ApproveBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApproveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlSearcher1.SuspendLayout();
            this.skinToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlSearcher1
            // 
            this.ctlSearcher1.Controls.Add(this.txtSearchDropDown);
            this.ctlSearcher1.Controls.Add(this.txtSearchText);
            this.ctlSearcher1.Controls.Add(this.lbSkinTextBox1);
            this.ctlSearcher1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlSearcher1.Location = new System.Drawing.Point(0, 40);
            this.ctlSearcher1.Name = "ctlSearcher1";
            this.ctlSearcher1.Size = new System.Drawing.Size(865, 46);
            this.ctlSearcher1.TabIndex = 7;
            // 
            // txtSearchDropDown
            // 
            this.txtSearchDropDown.CanBeEmpty = true;
            this.txtSearchDropDown.Caption = "";
            this.txtSearchDropDown.DM_UseSelectable = true;
            this.txtSearchDropDown.FormattingEnabled = true;
            this.txtSearchDropDown.ItemHeight = 24;
            this.txtSearchDropDown.Location = new System.Drawing.Point(629, 9);
            this.txtSearchDropDown.Name = "txtSearchDropDown";
            this.txtSearchDropDown.Size = new System.Drawing.Size(117, 30);
            this.txtSearchDropDown.Style = DMSkin.Metro.MetroColorStyle.Blue;
            this.txtSearchDropDown.TabIndex = 29;
            this.txtSearchDropDown.Theme = DMSkin.Metro.MetroThemeStyle.Light;
            this.txtSearchDropDown.Visible = false;
            // 
            // txtSearchText
            // 
            this.txtSearchText.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchText.CanBeEmpty = true;
            this.txtSearchText.Caption = "备注";
            this.txtSearchText.DownBack = null;
            this.txtSearchText.Icon = null;
            this.txtSearchText.IconIsButton = false;
            this.txtSearchText.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtSearchText.IsPasswordChat = '\0';
            this.txtSearchText.IsSystemPasswordChar = false;
            this.txtSearchText.Lines = new string[0];
            this.txtSearchText.Location = new System.Drawing.Point(301, 10);
            this.txtSearchText.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchText.MaxLength = 32767;
            this.txtSearchText.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtSearchText.MouseBack = null;
            this.txtSearchText.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtSearchText.Multiline = false;
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.NormlBack = null;
            this.txtSearchText.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearchText.ReadOnly = false;
            this.txtSearchText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchText.Size = new System.Drawing.Size(130, 28);
            // 
            // 
            // 
            this.txtSearchText.SkinTxt.AccessibleName = "";
            this.txtSearchText.SkinTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "asdfasdf",
            "adsfasdf"});
            this.txtSearchText.SkinTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtSearchText.SkinTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchText.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchText.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchText.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtSearchText.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtSearchText.SkinTxt.Name = "BaseText";
            this.txtSearchText.SkinTxt.Size = new System.Drawing.Size(120, 18);
            this.txtSearchText.SkinTxt.TabIndex = 0;
            this.txtSearchText.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSearchText.SkinTxt.WaterText = "";
            this.txtSearchText.TabIndex = 24;
            this.txtSearchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchText.Visible = false;
            this.txtSearchText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSearchText.WaterText = "";
            this.txtSearchText.WordWrap = true;
            // 
            // lbSkinTextBox1
            // 
            this.lbSkinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.lbSkinTextBox1.CanBeEmpty = true;
            this.lbSkinTextBox1.Caption = "备注";
            this.lbSkinTextBox1.DownBack = null;
            this.lbSkinTextBox1.Icon = null;
            this.lbSkinTextBox1.IconIsButton = false;
            this.lbSkinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.lbSkinTextBox1.IsPasswordChat = '\0';
            this.lbSkinTextBox1.IsSystemPasswordChar = false;
            this.lbSkinTextBox1.Lines = new string[0];
            this.lbSkinTextBox1.Location = new System.Drawing.Point(301, 10);
            this.lbSkinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.lbSkinTextBox1.MaxLength = 32767;
            this.lbSkinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.lbSkinTextBox1.MouseBack = null;
            this.lbSkinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.lbSkinTextBox1.Multiline = false;
            this.lbSkinTextBox1.Name = "lbSkinTextBox1";
            this.lbSkinTextBox1.NormlBack = null;
            this.lbSkinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.lbSkinTextBox1.ReadOnly = false;
            this.lbSkinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lbSkinTextBox1.Size = new System.Drawing.Size(130, 28);
            // 
            // 
            // 
            this.lbSkinTextBox1.SkinTxt.AccessibleName = "";
            this.lbSkinTextBox1.SkinTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "asdfasdf",
            "adsfasdf"});
            this.lbSkinTextBox1.SkinTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.lbSkinTextBox1.SkinTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.lbSkinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSkinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSkinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.lbSkinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.lbSkinTextBox1.SkinTxt.Name = "BaseText";
            this.lbSkinTextBox1.SkinTxt.Size = new System.Drawing.Size(120, 18);
            this.lbSkinTextBox1.SkinTxt.TabIndex = 0;
            this.lbSkinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lbSkinTextBox1.SkinTxt.WaterText = "";
            this.lbSkinTextBox1.TabIndex = 24;
            this.lbSkinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lbSkinTextBox1.Visible = false;
            this.lbSkinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lbSkinTextBox1.WaterText = "";
            this.lbSkinTextBox1.WordWrap = true;
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
            this.btnAdd,
            this.btnOpenEdit,
            this.btnCopy,
            this.btnReflesh,
            this.toolStripSeparator1});
            this.skinToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.skinToolStrip1.Name = "skinToolStrip1";
            this.skinToolStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.Size = new System.Drawing.Size(865, 40);
            this.skinToolStrip1.SkinAllColor = true;
            this.skinToolStrip1.TabIndex = 6;
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
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.LBPermissionCode = "";
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 37);
            this.btnAdd.Text = "添加调价单";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOpenEdit
            // 
            this.btnOpenEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenEdit.Image")));
            this.btnOpenEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenEdit.LBPermissionCode = "";
            this.btnOpenEdit.Name = "btnOpenEdit";
            this.btnOpenEdit.Size = new System.Drawing.Size(36, 37);
            this.btnOpenEdit.Text = "编辑";
            this.btnOpenEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnCopy
            // 
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.LBPermissionCode = "";
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(36, 37);
            this.btnCopy.Text = "复制";
            this.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.CustomerName,
            this.ModifyBillCode,
            this.BillDate,
            this.EffectDate,
            this.ItemName,
            this.CarNum,
            this.Price,
            this.CalculateTypeName,
            this.IsApprove,
            this.ApproveBy,
            this.ApproveTime,
            this.CreateBy,
            this.CreateTime,
            this.ChangeBy,
            this.ChangeTime});
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
            this.grdMain.Location = new System.Drawing.Point(0, 86);
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
            this.grdMain.Size = new System.Drawing.Size(865, 342);
            this.grdMain.TabIndex = 8;
            this.grdMain.TitleBack = null;
            this.grdMain.TitleBackColorBegin = System.Drawing.Color.White;
            this.grdMain.TitleBackColorEnd = System.Drawing.SystemColors.ActiveBorder;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "客户名称";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // ModifyBillCode
            // 
            this.ModifyBillCode.DataPropertyName = "ModifyBillCode";
            this.ModifyBillCode.HeaderText = "调价单编码";
            this.ModifyBillCode.Name = "ModifyBillCode";
            this.ModifyBillCode.ReadOnly = true;
            // 
            // BillDate
            // 
            this.BillDate.DataPropertyName = "BillDate";
            this.BillDate.HeaderText = "单据日期";
            this.BillDate.Name = "BillDate";
            this.BillDate.ReadOnly = true;
            // 
            // EffectDate
            // 
            this.EffectDate.DataPropertyName = "EffectDate";
            this.EffectDate.HeaderText = "生效日期";
            this.EffectDate.Name = "EffectDate";
            this.EffectDate.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "物料名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // CarNum
            // 
            this.CarNum.DataPropertyName = "CarNum";
            this.CarNum.HeaderText = "车牌号码";
            this.CarNum.Name = "CarNum";
            this.CarNum.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "单价";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // CalculateTypeName
            // 
            this.CalculateTypeName.DataPropertyName = "CalculateTypeName";
            this.CalculateTypeName.HeaderText = "计价方式";
            this.CalculateTypeName.Name = "CalculateTypeName";
            this.CalculateTypeName.ReadOnly = true;
            // 
            // IsApprove
            // 
            this.IsApprove.DataPropertyName = "IsApprove";
            this.IsApprove.HeaderText = "已审核";
            this.IsApprove.Name = "IsApprove";
            this.IsApprove.ReadOnly = true;
            // 
            // ApproveBy
            // 
            this.ApproveBy.DataPropertyName = "ApproveBy";
            this.ApproveBy.HeaderText = "审核人";
            this.ApproveBy.Name = "ApproveBy";
            this.ApproveBy.ReadOnly = true;
            // 
            // ApproveTime
            // 
            this.ApproveTime.DataPropertyName = "ApproveTime";
            this.ApproveTime.HeaderText = "审核时间";
            this.ApproveTime.Name = "ApproveTime";
            this.ApproveTime.ReadOnly = true;
            // 
            // CreateBy
            // 
            this.CreateBy.DataPropertyName = "CreateBy";
            this.CreateBy.HeaderText = "创建人";
            this.CreateBy.Name = "CreateBy";
            this.CreateBy.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // ChangeBy
            // 
            this.ChangeBy.DataPropertyName = "ChangeBy";
            this.ChangeBy.HeaderText = "修改人";
            this.ChangeBy.Name = "ChangeBy";
            this.ChangeBy.ReadOnly = true;
            // 
            // ChangeTime
            // 
            this.ChangeTime.DataPropertyName = "ChangeTime";
            this.ChangeTime.HeaderText = "修改时间";
            this.ChangeTime.Name = "ChangeTime";
            this.ChangeTime.ReadOnly = true;
            // 
            // frmModifyBillHeaderQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdMain);
            this.Controls.Add(this.ctlSearcher1);
            this.Controls.Add(this.skinToolStrip1);
            this.LBPageTitle = "调价单维护";
            this.Name = "frmModifyBillHeaderQuery";
            this.Size = new System.Drawing.Size(865, 428);
            this.ctlSearcher1.ResumeLayout(false);
            this.ctlSearcher1.PerformLayout();
            this.skinToolStrip1.ResumeLayout(false);
            this.skinToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Searcher.CtlSearcher ctlSearcher1;
        private Controls.LBMetroComboBox txtSearchDropDown;
        private Controls.LBSkinTextBox txtSearchText;
        private Controls.LBSkinTextBox lbSkinTextBox1;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip1;
        private Controls.LBToolStripButton btnClose;
        private Controls.LBToolStripButton btnAdd;
        private Controls.LBToolStripButton btnOpenEdit;
        private Controls.LBToolStripButton btnCopy;
        private Controls.LBToolStripButton btnReflesh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Controls.LBDataGridView grdMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyBillCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculateTypeName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsApprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApproveBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApproveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeTime;
    }
}
