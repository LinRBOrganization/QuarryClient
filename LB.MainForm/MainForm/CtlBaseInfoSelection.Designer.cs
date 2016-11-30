namespace LB.MainForm
{
    partial class CtlBaseInfoSelection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdCustomer = new LB.Controls.LBDataGridView(this.components);
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarIsLimit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AmountTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenceNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsForbid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ReceiveTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDisplayAmount = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsDisplayPrice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsPrintAmount = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsAllowOverFul = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CreateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCar = new LB.Controls.LBDataGridView(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdItem = new LB.Controls.LBDataGridView(this.components);
            this.LBSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItem)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCustomer
            // 
            this.grdCustomer.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.grdCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCustomer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdCustomer.ColumnFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.Contact,
            this.Phone,
            this.Address,
            this.CarIsLimit,
            this.AmountTypeName,
            this.LicenceNum,
            this.Description,
            this.IsForbid,
            this.ReceiveTypeName,
            this.CreditAmount,
            this.IsDisplayAmount,
            this.IsDisplayPrice,
            this.IsPrintAmount,
            this.IsAllowOverFul,
            this.CreateBy,
            this.CreateTime,
            this.ChangeBy,
            this.ChangeTime});
            this.grdCustomer.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdCustomer.EnableHeadersVisualStyles = false;
            this.grdCustomer.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdCustomer.HeadFont = null;
            this.grdCustomer.HeadForeColor = System.Drawing.Color.Empty;
            this.grdCustomer.HeadSelectBackColor = System.Drawing.Color.Empty;
            this.grdCustomer.HeadSelectForeColor = System.Drawing.Color.Empty;
            this.grdCustomer.LineNumberForeColor = System.Drawing.Color.MidnightBlue;
            this.grdCustomer.Location = new System.Drawing.Point(8, 8);
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdCustomer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdCustomer.RowTemplate.Height = 23;
            this.grdCustomer.Size = new System.Drawing.Size(324, 140);
            this.grdCustomer.TabIndex = 7;
            this.grdCustomer.TitleBack = null;
            this.grdCustomer.TitleBackColorBegin = System.Drawing.Color.White;
            this.grdCustomer.TitleBackColorEnd = System.Drawing.SystemColors.ActiveBorder;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "客户名称";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "联系人名称";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "联系人电话";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "地址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // CarIsLimit
            // 
            this.CarIsLimit.DataPropertyName = "CarIsLimit";
            this.CarIsLimit.HeaderText = "车辆是否限制";
            this.CarIsLimit.Name = "CarIsLimit";
            this.CarIsLimit.ReadOnly = true;
            this.CarIsLimit.Width = 120;
            // 
            // AmountTypeName
            // 
            this.AmountTypeName.DataPropertyName = "AmountTypeName";
            this.AmountTypeName.HeaderText = "金额格式";
            this.AmountTypeName.Name = "AmountTypeName";
            this.AmountTypeName.ReadOnly = true;
            // 
            // LicenceNum
            // 
            this.LicenceNum.DataPropertyName = "LicenceNum";
            this.LicenceNum.HeaderText = "营业执照号";
            this.LicenceNum.Name = "LicenceNum";
            this.LicenceNum.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "备注";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // IsForbid
            // 
            this.IsForbid.DataPropertyName = "IsForbid";
            this.IsForbid.HeaderText = "是否禁用";
            this.IsForbid.Name = "IsForbid";
            this.IsForbid.ReadOnly = true;
            // 
            // ReceiveTypeName
            // 
            this.ReceiveTypeName.DataPropertyName = "ReceiveTypeName";
            this.ReceiveTypeName.HeaderText = "收款方式";
            this.ReceiveTypeName.Name = "ReceiveTypeName";
            this.ReceiveTypeName.ReadOnly = true;
            // 
            // CreditAmount
            // 
            this.CreditAmount.DataPropertyName = "CreditAmount";
            this.CreditAmount.HeaderText = "信用额度";
            this.CreditAmount.Name = "CreditAmount";
            this.CreditAmount.ReadOnly = true;
            // 
            // IsDisplayAmount
            // 
            this.IsDisplayAmount.DataPropertyName = "IsDisplayAmount";
            this.IsDisplayAmount.HeaderText = "显示金额";
            this.IsDisplayAmount.Name = "IsDisplayAmount";
            this.IsDisplayAmount.ReadOnly = true;
            // 
            // IsDisplayPrice
            // 
            this.IsDisplayPrice.DataPropertyName = "IsDisplayPrice";
            this.IsDisplayPrice.HeaderText = "显示单价";
            this.IsDisplayPrice.Name = "IsDisplayPrice";
            this.IsDisplayPrice.ReadOnly = true;
            // 
            // IsPrintAmount
            // 
            this.IsPrintAmount.DataPropertyName = "IsPrintAmount";
            this.IsPrintAmount.HeaderText = "是否打印金额";
            this.IsPrintAmount.Name = "IsPrintAmount";
            this.IsPrintAmount.ReadOnly = true;
            // 
            // IsAllowOverFul
            // 
            this.IsAllowOverFul.DataPropertyName = "IsAllowOverFul";
            this.IsAllowOverFul.HeaderText = "是否允许超额提货";
            this.IsAllowOverFul.Name = "IsAllowOverFul";
            this.IsAllowOverFul.ReadOnly = true;
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
            // grdCar
            // 
            this.grdCar.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.grdCar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdCar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdCar.ColumnFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdCar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CarNum});
            this.grdCar.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCar.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdCar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdCar.EnableHeadersVisualStyles = false;
            this.grdCar.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdCar.HeadFont = null;
            this.grdCar.HeadForeColor = System.Drawing.Color.Empty;
            this.grdCar.HeadSelectBackColor = System.Drawing.Color.Empty;
            this.grdCar.HeadSelectForeColor = System.Drawing.Color.Empty;
            this.grdCar.LineNumberForeColor = System.Drawing.Color.MidnightBlue;
            this.grdCar.Location = new System.Drawing.Point(8, 163);
            this.grdCar.Name = "grdCar";
            this.grdCar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdCar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdCar.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdCar.RowTemplate.Height = 23;
            this.grdCar.Size = new System.Drawing.Size(411, 128);
            this.grdCar.TabIndex = 9;
            this.grdCar.TitleBack = null;
            this.grdCar.TitleBackColorBegin = System.Drawing.Color.White;
            this.grdCar.TitleBackColorEnd = System.Drawing.SystemColors.ActiveBorder;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn1.HeaderText = "客户名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // CarNum
            // 
            this.CarNum.DataPropertyName = "CarNum";
            this.CarNum.HeaderText = "车牌号码";
            this.CarNum.Name = "CarNum";
            this.CarNum.ReadOnly = true;
            this.CarNum.Width = 150;
            // 
            // grdItem
            // 
            this.grdItem.AllowUserToAddRows = false;
            this.grdItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.grdItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grdItem.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdItem.ColumnFont = null;
            this.grdItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LBSelected,
            this.ItemCode,
            this.ItemName,
            this.ItemMode,
            this.ItemRate,
            this.UOMName,
            this.ItemTypeName,
            this.ItemID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.grdItem.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdItem.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdItem.EnableHeadersVisualStyles = false;
            this.grdItem.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdItem.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdItem.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdItem.LineNumberForeColor = System.Drawing.Color.MidnightBlue;
            this.grdItem.Location = new System.Drawing.Point(338, 27);
            this.grdItem.Name = "grdItem";
            this.grdItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdItem.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.grdItem.RowTemplate.Height = 23;
            this.grdItem.Size = new System.Drawing.Size(324, 89);
            this.grdItem.TabIndex = 10;
            this.grdItem.TitleBack = null;
            this.grdItem.TitleBackColorBegin = System.Drawing.Color.White;
            this.grdItem.TitleBackColorEnd = System.Drawing.SystemColors.ActiveBorder;
            // 
            // LBSelected
            // 
            this.LBSelected.HeaderText = "选择";
            this.LBSelected.Name = "LBSelected";
            this.LBSelected.Width = 60;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "货物编码";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "货物名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemMode
            // 
            this.ItemMode.DataPropertyName = "ItemMode";
            this.ItemMode.HeaderText = "规格";
            this.ItemMode.Name = "ItemMode";
            this.ItemMode.ReadOnly = true;
            this.ItemMode.Width = 50;
            // 
            // ItemRate
            // 
            this.ItemRate.DataPropertyName = "ItemRate";
            this.ItemRate.HeaderText = "比重(kg/m3)";
            this.ItemRate.Name = "ItemRate";
            this.ItemRate.ReadOnly = true;
            this.ItemRate.Width = 50;
            // 
            // UOMName
            // 
            this.UOMName.DataPropertyName = "UOMName";
            this.UOMName.HeaderText = "单位";
            this.UOMName.Name = "UOMName";
            this.UOMName.ReadOnly = true;
            this.UOMName.Width = 50;
            // 
            // ItemTypeName
            // 
            this.ItemTypeName.DataPropertyName = "ItemTypeName";
            this.ItemTypeName.HeaderText = "物料分类";
            this.ItemTypeName.Name = "ItemTypeName";
            this.ItemTypeName.ReadOnly = true;
            this.ItemTypeName.Width = 60;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "流水号";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ChangeBy";
            this.dataGridViewTextBoxColumn2.HeaderText = "修改人";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ChangeTime";
            this.dataGridViewTextBoxColumn3.HeaderText = "修改时间";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // CtlBaseInfoSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdItem);
            this.Controls.Add(this.grdCar);
            this.Controls.Add(this.grdCustomer);
            this.Name = "CtlBaseInfoSelection";
            this.Size = new System.Drawing.Size(643, 263);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.LBDataGridView grdCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CarIsLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenceNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsForbid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDisplayAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDisplayPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPrintAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAllowOverFul;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeTime;
        private Controls.LBDataGridView grdCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNum;
        private Controls.LBDataGridView grdItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LBSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
