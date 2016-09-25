namespace LB.Report.Report
{
    partial class frmEditReport
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
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.txtReportTemplateName = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtDescription = new CCWin.SkinControl.SkinTextBox();
            this.btnSaveReport = new LB.Controls.LBSkinButton(this.components);
            this.btnDeleteReport = new LB.Controls.LBSkinButton(this.components);
            this.SuspendLayout();
            // 
            // skinLabel2
            // 
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(31, 30);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(83, 32);
            this.skinLabel2.TabIndex = 8;
            this.skinLabel2.Text = "报表名称";
            this.skinLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReportTemplateName
            // 
            this.txtReportTemplateName.BackColor = System.Drawing.Color.Transparent;
            this.txtReportTemplateName.DownBack = null;
            this.txtReportTemplateName.Icon = null;
            this.txtReportTemplateName.IconIsButton = false;
            this.txtReportTemplateName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtReportTemplateName.IsPasswordChat = '\0';
            this.txtReportTemplateName.IsSystemPasswordChar = false;
            this.txtReportTemplateName.Lines = new string[0];
            this.txtReportTemplateName.Location = new System.Drawing.Point(117, 34);
            this.txtReportTemplateName.Margin = new System.Windows.Forms.Padding(0);
            this.txtReportTemplateName.MaxLength = 32767;
            this.txtReportTemplateName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtReportTemplateName.MouseBack = null;
            this.txtReportTemplateName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtReportTemplateName.Multiline = false;
            this.txtReportTemplateName.Name = "txtReportTemplateName";
            this.txtReportTemplateName.NormlBack = null;
            this.txtReportTemplateName.Padding = new System.Windows.Forms.Padding(5);
            this.txtReportTemplateName.ReadOnly = false;
            this.txtReportTemplateName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReportTemplateName.Size = new System.Drawing.Size(275, 28);
            // 
            // 
            // 
            this.txtReportTemplateName.SkinTxt.AccessibleName = "";
            this.txtReportTemplateName.SkinTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "asdfasdf",
            "adsfasdf"});
            this.txtReportTemplateName.SkinTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtReportTemplateName.SkinTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtReportTemplateName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReportTemplateName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReportTemplateName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtReportTemplateName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtReportTemplateName.SkinTxt.Name = "BaseText";
            this.txtReportTemplateName.SkinTxt.Size = new System.Drawing.Size(265, 18);
            this.txtReportTemplateName.SkinTxt.TabIndex = 0;
            this.txtReportTemplateName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtReportTemplateName.SkinTxt.WaterText = "";
            this.txtReportTemplateName.TabIndex = 7;
            this.txtReportTemplateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReportTemplateName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtReportTemplateName.WaterText = "";
            this.txtReportTemplateName.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(31, 72);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(83, 32);
            this.skinLabel1.TabIndex = 10;
            this.skinLabel1.Text = "备注";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.DownBack = null;
            this.txtDescription.Icon = null;
            this.txtDescription.IconIsButton = false;
            this.txtDescription.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDescription.IsPasswordChat = '\0';
            this.txtDescription.IsSystemPasswordChar = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(117, 76);
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
            this.txtDescription.Size = new System.Drawing.Size(275, 28);
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
            this.txtDescription.SkinTxt.Size = new System.Drawing.Size(265, 18);
            this.txtDescription.SkinTxt.TabIndex = 0;
            this.txtDescription.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDescription.SkinTxt.WaterText = "";
            this.txtDescription.TabIndex = 9;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDescription.WaterText = "";
            this.txtDescription.WordWrap = true;
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveReport.BaseColor = System.Drawing.Color.LightGray;
            this.btnSaveReport.BorderColor = System.Drawing.Color.Gray;
            this.btnSaveReport.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSaveReport.DownBack = null;
            this.btnSaveReport.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSaveReport.LBPermissionCode = "";
            this.btnSaveReport.Location = new System.Drawing.Point(128, 120);
            this.btnSaveReport.MouseBack = null;
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.NormlBack = null;
            this.btnSaveReport.Size = new System.Drawing.Size(81, 26);
            this.btnSaveReport.TabIndex = 11;
            this.btnSaveReport.Text = "保存报表";
            this.btnSaveReport.UseVisualStyleBackColor = false;
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
            // 
            // btnDeleteReport
            // 
            this.btnDeleteReport.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteReport.BaseColor = System.Drawing.Color.LightGray;
            this.btnDeleteReport.BorderColor = System.Drawing.Color.Gray;
            this.btnDeleteReport.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDeleteReport.DownBack = null;
            this.btnDeleteReport.Font = new System.Drawing.Font("宋体", 10F);
            this.btnDeleteReport.LBPermissionCode = "";
            this.btnDeleteReport.Location = new System.Drawing.Point(240, 120);
            this.btnDeleteReport.MouseBack = null;
            this.btnDeleteReport.Name = "btnDeleteReport";
            this.btnDeleteReport.NormlBack = null;
            this.btnDeleteReport.Size = new System.Drawing.Size(81, 26);
            this.btnDeleteReport.TabIndex = 12;
            this.btnDeleteReport.Text = "删除报表";
            this.btnDeleteReport.UseVisualStyleBackColor = false;
            this.btnDeleteReport.Click += new System.EventHandler(this.btnDeleteReport_Click);
            // 
            // frmEditReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteReport);
            this.Controls.Add(this.btnSaveReport);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.txtReportTemplateName);
            this.Name = "frmEditReport";
            this.Size = new System.Drawing.Size(432, 158);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox txtReportTemplateName;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox txtDescription;
        private Controls.LBSkinButton btnSaveReport;
        private Controls.LBSkinButton btnDeleteReport;
    }
}
