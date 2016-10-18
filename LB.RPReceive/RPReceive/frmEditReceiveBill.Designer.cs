namespace LB.RPReceive
{
    partial class frmEditReceiveBill
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClose = new LB.Controls.LBToolStripButton(this.components);
            this.btnSave = new LB.Controls.LBToolStripButton(this.components);
            this.btnDelete = new LB.Controls.LBToolStripButton(this.components);
            this.btnApprove = new LB.Controls.LBToolStripButton(this.components);
            this.btnUnApprove = new LB.Controls.LBToolStripButton(this.components);
            this.btnCancel = new LB.Controls.LBToolStripButton(this.components);
            this.btnUnCancel = new LB.Controls.LBToolStripButton(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblBillStatus = new System.Windows.Forms.Label();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtReceiveBillCode = new LB.Controls.LBSkinTextBox(this.components);
            this.txtBillStatus = new LB.Controls.LBSkinTextBox(this.components);
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.txtCustomerID = new LB.Controls.LBTextBox.CoolTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.txtBillDate = new DMSkin.Metro.Controls.MetroDateTime();
            this.txtReceiveAmount = new LB.Controls.LBSkinTextBox(this.components);
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.txtDescription = new LB.Controls.LBSkinTextBox(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChangedBy = new LB.Controls.LBSkinTextBox(this.components);
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.txtChangeTime = new LB.Controls.LBSkinTextBox(this.components);
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.txtApproveTime = new LB.Controls.LBSkinTextBox(this.components);
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.txtApproveBy = new LB.Controls.LBSkinTextBox(this.components);
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.txtCancelTime = new LB.Controls.LBSkinTextBox(this.components);
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.txtCancelBy = new LB.Controls.LBSkinTextBox(this.components);
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.btnAdd = new LB.Controls.LBToolStripButton(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose,
            this.btnAdd,
            this.btnSave,
            this.btnDelete,
            this.btnApprove,
            this.btnUnApprove,
            this.btnCancel,
            this.btnUnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(528, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::LB.RPReceive.Properties.Resources.btnClose;
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
            this.btnSave.Image = global::LB.RPReceive.Properties.Resources.btnSave;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.LBPermissionCode = "";
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 37);
            this.btnSave.Text = "保存";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::LB.RPReceive.Properties.Resources.btnDelete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.LBPermissionCode = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 37);
            this.btnDelete.Text = "删除";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Image = global::LB.RPReceive.Properties.Resources.btnApprove;
            this.btnApprove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnApprove.LBPermissionCode = "";
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(36, 37);
            this.btnApprove.Text = "审核";
            this.btnApprove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnUnApprove
            // 
            this.btnUnApprove.Image = global::LB.RPReceive.Properties.Resources.btnUnApprove;
            this.btnUnApprove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnApprove.LBPermissionCode = "";
            this.btnUnApprove.Name = "btnUnApprove";
            this.btnUnApprove.Size = new System.Drawing.Size(60, 37);
            this.btnUnApprove.Text = "取消审核";
            this.btnUnApprove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUnApprove.Click += new System.EventHandler(this.btnUnApprove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::LB.RPReceive.Properties.Resources.btnClearAll;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.LBPermissionCode = "";
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(36, 37);
            this.btnCancel.Text = "作废";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUnCancel
            // 
            this.btnUnCancel.Image = global::LB.RPReceive.Properties.Resources.btnClearAll;
            this.btnUnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnCancel.LBPermissionCode = "";
            this.btnUnCancel.Name = "btnUnCancel";
            this.btnUnCancel.Size = new System.Drawing.Size(60, 37);
            this.btnUnCancel.Text = "取消作废";
            this.btnUnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUnCancel.Click += new System.EventHandler(this.btnUnCancel_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "充值单";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBillStatus
            // 
            this.lblBillStatus.AutoSize = true;
            this.lblBillStatus.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold);
            this.lblBillStatus.ForeColor = System.Drawing.Color.Red;
            this.lblBillStatus.Location = new System.Drawing.Point(309, 40);
            this.lblBillStatus.Name = "lblBillStatus";
            this.lblBillStatus.Size = new System.Drawing.Size(115, 33);
            this.lblBillStatus.TabIndex = 3;
            this.lblBillStatus.Text = "(审核)";
            // 
            // skinLabel2
            // 
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(21, 90);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(83, 32);
            this.skinLabel2.TabIndex = 8;
            this.skinLabel2.Text = "充值单号";
            this.skinLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinLabel1
            // 
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(284, 90);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(83, 32);
            this.skinLabel1.TabIndex = 10;
            this.skinLabel1.Text = "单据状态";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReceiveBillCode
            // 
            this.txtReceiveBillCode.BackColor = System.Drawing.Color.Transparent;
            this.txtReceiveBillCode.CanBeEmpty = true;
            this.txtReceiveBillCode.Caption = "充值单号";
            this.txtReceiveBillCode.DownBack = null;
            this.txtReceiveBillCode.Icon = null;
            this.txtReceiveBillCode.IconIsButton = false;
            this.txtReceiveBillCode.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtReceiveBillCode.IsPasswordChat = '\0';
            this.txtReceiveBillCode.IsSystemPasswordChar = false;
            this.txtReceiveBillCode.Lines = new string[0];
            this.txtReceiveBillCode.Location = new System.Drawing.Point(107, 94);
            this.txtReceiveBillCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtReceiveBillCode.MaxLength = 32767;
            this.txtReceiveBillCode.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtReceiveBillCode.MouseBack = null;
            this.txtReceiveBillCode.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtReceiveBillCode.Multiline = false;
            this.txtReceiveBillCode.Name = "txtReceiveBillCode";
            this.txtReceiveBillCode.NormlBack = null;
            this.txtReceiveBillCode.Padding = new System.Windows.Forms.Padding(5);
            this.txtReceiveBillCode.ReadOnly = true;
            this.txtReceiveBillCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReceiveBillCode.Size = new System.Drawing.Size(135, 28);
            // 
            // 
            // 
            this.txtReceiveBillCode.SkinTxt.AccessibleName = "";
            this.txtReceiveBillCode.SkinTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "asdfasdf",
            "adsfasdf"});
            this.txtReceiveBillCode.SkinTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtReceiveBillCode.SkinTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtReceiveBillCode.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiveBillCode.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceiveBillCode.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtReceiveBillCode.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtReceiveBillCode.SkinTxt.Name = "BaseText";
            this.txtReceiveBillCode.SkinTxt.ReadOnly = true;
            this.txtReceiveBillCode.SkinTxt.Size = new System.Drawing.Size(125, 18);
            this.txtReceiveBillCode.SkinTxt.TabIndex = 0;
            this.txtReceiveBillCode.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtReceiveBillCode.SkinTxt.WaterText = "";
            this.txtReceiveBillCode.TabIndex = 11;
            this.txtReceiveBillCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReceiveBillCode.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtReceiveBillCode.WaterText = "";
            this.txtReceiveBillCode.WordWrap = true;
            // 
            // txtBillStatus
            // 
            this.txtBillStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtBillStatus.CanBeEmpty = true;
            this.txtBillStatus.Caption = "单据状态";
            this.txtBillStatus.DownBack = null;
            this.txtBillStatus.Icon = null;
            this.txtBillStatus.IconIsButton = false;
            this.txtBillStatus.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtBillStatus.IsPasswordChat = '\0';
            this.txtBillStatus.IsSystemPasswordChar = false;
            this.txtBillStatus.Lines = new string[0];
            this.txtBillStatus.Location = new System.Drawing.Point(370, 94);
            this.txtBillStatus.Margin = new System.Windows.Forms.Padding(0);
            this.txtBillStatus.MaxLength = 32767;
            this.txtBillStatus.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtBillStatus.MouseBack = null;
            this.txtBillStatus.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtBillStatus.Multiline = false;
            this.txtBillStatus.Name = "txtBillStatus";
            this.txtBillStatus.NormlBack = null;
            this.txtBillStatus.Padding = new System.Windows.Forms.Padding(5);
            this.txtBillStatus.ReadOnly = true;
            this.txtBillStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBillStatus.Size = new System.Drawing.Size(134, 28);
            // 
            // 
            // 
            this.txtBillStatus.SkinTxt.AccessibleName = "";
            this.txtBillStatus.SkinTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "asdfasdf",
            "adsfasdf"});
            this.txtBillStatus.SkinTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtBillStatus.SkinTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBillStatus.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillStatus.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBillStatus.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtBillStatus.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtBillStatus.SkinTxt.Name = "BaseText";
            this.txtBillStatus.SkinTxt.ReadOnly = true;
            this.txtBillStatus.SkinTxt.Size = new System.Drawing.Size(124, 18);
            this.txtBillStatus.SkinTxt.TabIndex = 0;
            this.txtBillStatus.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtBillStatus.SkinTxt.WaterText = "";
            this.txtBillStatus.TabIndex = 12;
            this.txtBillStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBillStatus.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtBillStatus.WaterText = "";
            this.txtBillStatus.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(21, 143);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(83, 32);
            this.skinLabel3.TabIndex = 13;
            this.skinLabel3.Text = "充值客户";
            this.skinLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerID.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtCustomerID.CanBeEmpty = false;
            this.txtCustomerID.Caption = "充值客户";
            this.txtCustomerID.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtCustomerID.LBTitle = "";
            this.txtCustomerID.LBTitleVisible = true;
            this.txtCustomerID.Location = new System.Drawing.Point(97, 147);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.PopupWidth = 120;
            this.txtCustomerID.SelectedItemBackColor = System.Drawing.SystemColors.Highlight;
            this.txtCustomerID.SelectedItemForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtCustomerID.Size = new System.Drawing.Size(407, 28);
            this.txtCustomerID.TabIndex = 14;
            // 
            // skinLabel4
            // 
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(21, 195);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(83, 32);
            this.skinLabel4.TabIndex = 15;
            this.skinLabel4.Text = "充值日期";
            this.skinLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBillDate
            // 
            this.txtBillDate.Location = new System.Drawing.Point(107, 195);
            this.txtBillDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.Size = new System.Drawing.Size(135, 30);
            this.txtBillDate.TabIndex = 16;
            // 
            // txtReceiveAmount
            // 
            this.txtReceiveAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtReceiveAmount.CanBeEmpty = false;
            this.txtReceiveAmount.Caption = "充值金额";
            this.txtReceiveAmount.DownBack = null;
            this.txtReceiveAmount.Icon = null;
            this.txtReceiveAmount.IconIsButton = false;
            this.txtReceiveAmount.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtReceiveAmount.IsPasswordChat = '\0';
            this.txtReceiveAmount.IsSystemPasswordChar = false;
            this.txtReceiveAmount.Lines = new string[] {
        "0"};
            this.txtReceiveAmount.Location = new System.Drawing.Point(370, 195);
            this.txtReceiveAmount.Margin = new System.Windows.Forms.Padding(0);
            this.txtReceiveAmount.MaxLength = 32767;
            this.txtReceiveAmount.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtReceiveAmount.MouseBack = null;
            this.txtReceiveAmount.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtReceiveAmount.Multiline = false;
            this.txtReceiveAmount.Name = "txtReceiveAmount";
            this.txtReceiveAmount.NormlBack = null;
            this.txtReceiveAmount.Padding = new System.Windows.Forms.Padding(5);
            this.txtReceiveAmount.ReadOnly = false;
            this.txtReceiveAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReceiveAmount.Size = new System.Drawing.Size(135, 28);
            // 
            // 
            // 
            this.txtReceiveAmount.SkinTxt.AccessibleName = "";
            this.txtReceiveAmount.SkinTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "asdfasdf",
            "adsfasdf"});
            this.txtReceiveAmount.SkinTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtReceiveAmount.SkinTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtReceiveAmount.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiveAmount.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceiveAmount.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtReceiveAmount.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtReceiveAmount.SkinTxt.Name = "BaseText";
            this.txtReceiveAmount.SkinTxt.Size = new System.Drawing.Size(125, 18);
            this.txtReceiveAmount.SkinTxt.TabIndex = 0;
            this.txtReceiveAmount.SkinTxt.Text = "0";
            this.txtReceiveAmount.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtReceiveAmount.SkinTxt.WaterText = "";
            this.txtReceiveAmount.TabIndex = 18;
            this.txtReceiveAmount.Text = "0";
            this.txtReceiveAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReceiveAmount.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtReceiveAmount.WaterText = "";
            this.txtReceiveAmount.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(284, 195);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(83, 32);
            this.skinLabel5.TabIndex = 17;
            this.skinLabel5.Text = "充值金额";
            this.skinLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinLabel6
            // 
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(21, 248);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(83, 32);
            this.skinLabel6.TabIndex = 19;
            this.skinLabel6.Text = "备注";
            this.skinLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.CanBeEmpty = true;
            this.txtDescription.Caption = "备注";
            this.txtDescription.DownBack = null;
            this.txtDescription.Icon = null;
            this.txtDescription.IconIsButton = false;
            this.txtDescription.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDescription.IsPasswordChat = '\0';
            this.txtDescription.IsSystemPasswordChar = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(107, 248);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtDescription.MouseBack = null;
            this.txtDescription.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NormlBack = null;
            this.txtDescription.Padding = new System.Windows.Forms.Padding(5);
            this.txtDescription.ReadOnly = false;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.Size = new System.Drawing.Size(397, 28);
            // 
            // 
            // 
            this.txtDescription.SkinTxt.AccessibleName = "";
            this.txtDescription.SkinTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "asdfasdf",
            "adsfasdf"});
            this.txtDescription.SkinTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDescription.SkinTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDescription.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtDescription.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtDescription.SkinTxt.Name = "BaseText";
            this.txtDescription.SkinTxt.Size = new System.Drawing.Size(387, 18);
            this.txtDescription.SkinTxt.TabIndex = 0;
            this.txtDescription.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDescription.SkinTxt.WaterText = "";
            this.txtDescription.TabIndex = 20;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDescription.WaterText = "";
            this.txtDescription.WordWrap = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 10);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // txtChangedBy
            // 
            this.txtChangedBy.BackColor = System.Drawing.Color.Transparent;
            this.txtChangedBy.CanBeEmpty = true;
            this.txtChangedBy.Caption = "";
            this.txtChangedBy.DownBack = null;
            this.txtChangedBy.Icon = null;
            this.txtChangedBy.IconIsButton = false;
            this.txtChangedBy.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtChangedBy.IsPasswordChat = '\0';
            this.txtChangedBy.IsSystemPasswordChar = false;
            this.txtChangedBy.Lines = new string[0];
            this.txtChangedBy.Location = new System.Drawing.Point(107, 319);
            this.txtChangedBy.Margin = new System.Windows.Forms.Padding(0);
            this.txtChangedBy.MaxLength = 32767;
            this.txtChangedBy.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtChangedBy.MouseBack = null;
            this.txtChangedBy.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtChangedBy.Multiline = false;
            this.txtChangedBy.Name = "txtChangedBy";
            this.txtChangedBy.NormlBack = null;
            this.txtChangedBy.Padding = new System.Windows.Forms.Padding(5);
            this.txtChangedBy.ReadOnly = true;
            this.txtChangedBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChangedBy.Size = new System.Drawing.Size(135, 28);
            // 
            // 
            // 
            this.txtChangedBy.SkinTxt.AccessibleName = "";
            this.txtChangedBy.SkinTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "asdfasdf",
            "adsfasdf"});
            this.txtChangedBy.SkinTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtChangedBy.SkinTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtChangedBy.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChangedBy.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChangedBy.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtChangedBy.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtChangedBy.SkinTxt.Name = "BaseText";
            this.txtChangedBy.SkinTxt.ReadOnly = true;
            this.txtChangedBy.SkinTxt.Size = new System.Drawing.Size(125, 18);
            this.txtChangedBy.SkinTxt.TabIndex = 0;
            this.txtChangedBy.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtChangedBy.SkinTxt.WaterText = "";
            this.txtChangedBy.TabIndex = 23;
            this.txtChangedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChangedBy.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtChangedBy.WaterText = "";
            this.txtChangedBy.WordWrap = true;
            // 
            // skinLabel7
            // 
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(21, 315);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(83, 32);
            this.skinLabel7.TabIndex = 22;
            this.skinLabel7.Text = "修改人";
            this.skinLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChangeTime
            // 
            this.txtChangeTime.BackColor = System.Drawing.Color.Transparent;
            this.txtChangeTime.CanBeEmpty = true;
            this.txtChangeTime.Caption = "";
            this.txtChangeTime.DownBack = null;
            this.txtChangeTime.Icon = null;
            this.txtChangeTime.IconIsButton = false;
            this.txtChangeTime.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtChangeTime.IsPasswordChat = '\0';
            this.txtChangeTime.IsSystemPasswordChar = false;
            this.txtChangeTime.Lines = new string[0];
            this.txtChangeTime.Location = new System.Drawing.Point(370, 319);
            this.txtChangeTime.Margin = new System.Windows.Forms.Padding(0);
            this.txtChangeTime.MaxLength = 32767;
            this.txtChangeTime.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtChangeTime.MouseBack = null;
            this.txtChangeTime.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtChangeTime.Multiline = false;
            this.txtChangeTime.Name = "txtChangeTime";
            this.txtChangeTime.NormlBack = null;
            this.txtChangeTime.Padding = new System.Windows.Forms.Padding(5);
            this.txtChangeTime.ReadOnly = true;
            this.txtChangeTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChangeTime.Size = new System.Drawing.Size(135, 28);
            // 
            // 
            // 
            this.txtChangeTime.SkinTxt.AccessibleName = "";
            this.txtChangeTime.SkinTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "asdfasdf",
            "adsfasdf"});
            this.txtChangeTime.SkinTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtChangeTime.SkinTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtChangeTime.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChangeTime.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChangeTime.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtChangeTime.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtChangeTime.SkinTxt.Name = "BaseText";
            this.txtChangeTime.SkinTxt.ReadOnly = true;
            this.txtChangeTime.SkinTxt.Size = new System.Drawing.Size(125, 18);
            this.txtChangeTime.SkinTxt.TabIndex = 0;
            this.txtChangeTime.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtChangeTime.SkinTxt.WaterText = "";
            this.txtChangeTime.TabIndex = 25;
            this.txtChangeTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChangeTime.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtChangeTime.WaterText = "";
            this.txtChangeTime.WordWrap = true;
            // 
            // skinLabel8
            // 
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(284, 315);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(83, 32);
            this.skinLabel8.TabIndex = 24;
            this.skinLabel8.Text = "修改时间";
            this.skinLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApproveTime
            // 
            this.txtApproveTime.BackColor = System.Drawing.Color.Transparent;
            this.txtApproveTime.CanBeEmpty = true;
            this.txtApproveTime.Caption = "";
            this.txtApproveTime.DownBack = null;
            this.txtApproveTime.Icon = null;
            this.txtApproveTime.IconIsButton = false;
            this.txtApproveTime.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtApproveTime.IsPasswordChat = '\0';
            this.txtApproveTime.IsSystemPasswordChar = false;
            this.txtApproveTime.Lines = new string[0];
            this.txtApproveTime.Location = new System.Drawing.Point(370, 356);
            this.txtApproveTime.Margin = new System.Windows.Forms.Padding(0);
            this.txtApproveTime.MaxLength = 32767;
            this.txtApproveTime.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtApproveTime.MouseBack = null;
            this.txtApproveTime.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtApproveTime.Multiline = false;
            this.txtApproveTime.Name = "txtApproveTime";
            this.txtApproveTime.NormlBack = null;
            this.txtApproveTime.Padding = new System.Windows.Forms.Padding(5);
            this.txtApproveTime.ReadOnly = true;
            this.txtApproveTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApproveTime.Size = new System.Drawing.Size(135, 28);
            // 
            // 
            // 
            this.txtApproveTime.SkinTxt.AccessibleName = "";
            this.txtApproveTime.SkinTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "asdfasdf",
            "adsfasdf"});
            this.txtApproveTime.SkinTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtApproveTime.SkinTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtApproveTime.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApproveTime.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApproveTime.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtApproveTime.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtApproveTime.SkinTxt.Name = "BaseText";
            this.txtApproveTime.SkinTxt.ReadOnly = true;
            this.txtApproveTime.SkinTxt.Size = new System.Drawing.Size(125, 18);
            this.txtApproveTime.SkinTxt.TabIndex = 0;
            this.txtApproveTime.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtApproveTime.SkinTxt.WaterText = "";
            this.txtApproveTime.TabIndex = 29;
            this.txtApproveTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApproveTime.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtApproveTime.WaterText = "";
            this.txtApproveTime.WordWrap = true;
            // 
            // skinLabel9
            // 
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(284, 352);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(83, 32);
            this.skinLabel9.TabIndex = 28;
            this.skinLabel9.Text = "审核时间";
            this.skinLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApproveBy
            // 
            this.txtApproveBy.BackColor = System.Drawing.Color.Transparent;
            this.txtApproveBy.CanBeEmpty = true;
            this.txtApproveBy.Caption = "";
            this.txtApproveBy.DownBack = null;
            this.txtApproveBy.Icon = null;
            this.txtApproveBy.IconIsButton = false;
            this.txtApproveBy.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtApproveBy.IsPasswordChat = '\0';
            this.txtApproveBy.IsSystemPasswordChar = false;
            this.txtApproveBy.Lines = new string[0];
            this.txtApproveBy.Location = new System.Drawing.Point(107, 356);
            this.txtApproveBy.Margin = new System.Windows.Forms.Padding(0);
            this.txtApproveBy.MaxLength = 32767;
            this.txtApproveBy.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtApproveBy.MouseBack = null;
            this.txtApproveBy.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtApproveBy.Multiline = false;
            this.txtApproveBy.Name = "txtApproveBy";
            this.txtApproveBy.NormlBack = null;
            this.txtApproveBy.Padding = new System.Windows.Forms.Padding(5);
            this.txtApproveBy.ReadOnly = true;
            this.txtApproveBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApproveBy.Size = new System.Drawing.Size(135, 28);
            // 
            // 
            // 
            this.txtApproveBy.SkinTxt.AccessibleName = "";
            this.txtApproveBy.SkinTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "asdfasdf",
            "adsfasdf"});
            this.txtApproveBy.SkinTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtApproveBy.SkinTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtApproveBy.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApproveBy.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApproveBy.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtApproveBy.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtApproveBy.SkinTxt.Name = "BaseText";
            this.txtApproveBy.SkinTxt.ReadOnly = true;
            this.txtApproveBy.SkinTxt.Size = new System.Drawing.Size(125, 18);
            this.txtApproveBy.SkinTxt.TabIndex = 0;
            this.txtApproveBy.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtApproveBy.SkinTxt.WaterText = "";
            this.txtApproveBy.TabIndex = 27;
            this.txtApproveBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApproveBy.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtApproveBy.WaterText = "";
            this.txtApproveBy.WordWrap = true;
            // 
            // skinLabel10
            // 
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(21, 352);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(83, 32);
            this.skinLabel10.TabIndex = 26;
            this.skinLabel10.Text = "审核人";
            this.skinLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCancelTime
            // 
            this.txtCancelTime.BackColor = System.Drawing.Color.Transparent;
            this.txtCancelTime.CanBeEmpty = true;
            this.txtCancelTime.Caption = "";
            this.txtCancelTime.DownBack = null;
            this.txtCancelTime.Icon = null;
            this.txtCancelTime.IconIsButton = false;
            this.txtCancelTime.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCancelTime.IsPasswordChat = '\0';
            this.txtCancelTime.IsSystemPasswordChar = false;
            this.txtCancelTime.Lines = new string[0];
            this.txtCancelTime.Location = new System.Drawing.Point(370, 395);
            this.txtCancelTime.Margin = new System.Windows.Forms.Padding(0);
            this.txtCancelTime.MaxLength = 32767;
            this.txtCancelTime.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtCancelTime.MouseBack = null;
            this.txtCancelTime.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCancelTime.Multiline = false;
            this.txtCancelTime.Name = "txtCancelTime";
            this.txtCancelTime.NormlBack = null;
            this.txtCancelTime.Padding = new System.Windows.Forms.Padding(5);
            this.txtCancelTime.ReadOnly = true;
            this.txtCancelTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCancelTime.Size = new System.Drawing.Size(135, 28);
            // 
            // 
            // 
            this.txtCancelTime.SkinTxt.AccessibleName = "";
            this.txtCancelTime.SkinTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "asdfasdf",
            "adsfasdf"});
            this.txtCancelTime.SkinTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtCancelTime.SkinTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCancelTime.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCancelTime.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCancelTime.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtCancelTime.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtCancelTime.SkinTxt.Name = "BaseText";
            this.txtCancelTime.SkinTxt.ReadOnly = true;
            this.txtCancelTime.SkinTxt.Size = new System.Drawing.Size(125, 18);
            this.txtCancelTime.SkinTxt.TabIndex = 0;
            this.txtCancelTime.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCancelTime.SkinTxt.WaterText = "";
            this.txtCancelTime.TabIndex = 33;
            this.txtCancelTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCancelTime.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCancelTime.WaterText = "";
            this.txtCancelTime.WordWrap = true;
            // 
            // skinLabel11
            // 
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.Location = new System.Drawing.Point(284, 391);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(83, 32);
            this.skinLabel11.TabIndex = 32;
            this.skinLabel11.Text = "作废时间";
            this.skinLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCancelBy
            // 
            this.txtCancelBy.BackColor = System.Drawing.Color.Transparent;
            this.txtCancelBy.CanBeEmpty = true;
            this.txtCancelBy.Caption = "";
            this.txtCancelBy.DownBack = null;
            this.txtCancelBy.Icon = null;
            this.txtCancelBy.IconIsButton = false;
            this.txtCancelBy.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCancelBy.IsPasswordChat = '\0';
            this.txtCancelBy.IsSystemPasswordChar = false;
            this.txtCancelBy.Lines = new string[0];
            this.txtCancelBy.Location = new System.Drawing.Point(107, 395);
            this.txtCancelBy.Margin = new System.Windows.Forms.Padding(0);
            this.txtCancelBy.MaxLength = 32767;
            this.txtCancelBy.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtCancelBy.MouseBack = null;
            this.txtCancelBy.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtCancelBy.Multiline = false;
            this.txtCancelBy.Name = "txtCancelBy";
            this.txtCancelBy.NormlBack = null;
            this.txtCancelBy.Padding = new System.Windows.Forms.Padding(5);
            this.txtCancelBy.ReadOnly = true;
            this.txtCancelBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCancelBy.Size = new System.Drawing.Size(135, 28);
            // 
            // 
            // 
            this.txtCancelBy.SkinTxt.AccessibleName = "";
            this.txtCancelBy.SkinTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "asdfasdf",
            "adsfasdf"});
            this.txtCancelBy.SkinTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtCancelBy.SkinTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCancelBy.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCancelBy.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCancelBy.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtCancelBy.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtCancelBy.SkinTxt.Name = "BaseText";
            this.txtCancelBy.SkinTxt.ReadOnly = true;
            this.txtCancelBy.SkinTxt.Size = new System.Drawing.Size(125, 18);
            this.txtCancelBy.SkinTxt.TabIndex = 0;
            this.txtCancelBy.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCancelBy.SkinTxt.WaterText = "";
            this.txtCancelBy.TabIndex = 31;
            this.txtCancelBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCancelBy.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtCancelBy.WaterText = "";
            this.txtCancelBy.WordWrap = true;
            // 
            // skinLabel12
            // 
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.Location = new System.Drawing.Point(21, 391);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(83, 32);
            this.skinLabel12.TabIndex = 30;
            this.skinLabel12.Text = "作废人";
            this.skinLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::LB.RPReceive.Properties.Resources.btnOpenAdd;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.LBPermissionCode = "";
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 37);
            this.btnAdd.Text = "继续添加";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmEditReceiveBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCancelTime);
            this.Controls.Add(this.skinLabel11);
            this.Controls.Add(this.txtCancelBy);
            this.Controls.Add(this.skinLabel12);
            this.Controls.Add(this.txtApproveTime);
            this.Controls.Add(this.skinLabel9);
            this.Controls.Add(this.txtApproveBy);
            this.Controls.Add(this.skinLabel10);
            this.Controls.Add(this.txtChangeTime);
            this.Controls.Add(this.skinLabel8);
            this.Controls.Add(this.txtChangedBy);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.txtReceiveAmount);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.txtBillDate);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.txtBillStatus);
            this.Controls.Add(this.txtReceiveBillCode);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.lblBillStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.LBPageTitle = "充值单";
            this.Name = "frmEditReceiveBill";
            this.Size = new System.Drawing.Size(528, 430);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private Controls.LBToolStripButton btnClose;
        private Controls.LBToolStripButton btnSave;
        private Controls.LBToolStripButton btnDelete;
        private Controls.LBToolStripButton btnApprove;
        private Controls.LBToolStripButton btnUnApprove;
        private Controls.LBToolStripButton btnCancel;
        private Controls.LBToolStripButton btnUnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBillStatus;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private Controls.LBSkinTextBox txtReceiveBillCode;
        private Controls.LBSkinTextBox txtBillStatus;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private Controls.LBTextBox.CoolTextBox txtCustomerID;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private DMSkin.Metro.Controls.MetroDateTime txtBillDate;
        private Controls.LBSkinTextBox txtReceiveAmount;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private Controls.LBSkinTextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.LBSkinTextBox txtChangedBy;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private Controls.LBSkinTextBox txtChangeTime;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private Controls.LBSkinTextBox txtApproveTime;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private Controls.LBSkinTextBox txtApproveBy;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private Controls.LBSkinTextBox txtCancelTime;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private Controls.LBSkinTextBox txtCancelBy;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private Controls.LBToolStripButton btnAdd;
    }
}
