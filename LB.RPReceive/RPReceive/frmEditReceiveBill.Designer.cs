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
            this.lbToolStripButton1 = new LB.Controls.LBToolStripButton(this.components);
            this.btnCancel = new LB.Controls.LBToolStripButton(this.components);
            this.btnUnCancel = new LB.Controls.LBToolStripButton(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose,
            this.btnSave,
            this.btnDelete,
            this.btnApprove,
            this.lbToolStripButton1,
            this.btnCancel,
            this.btnUnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(490, 40);
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
            // 
            // lbToolStripButton1
            // 
            this.lbToolStripButton1.Image = global::LB.RPReceive.Properties.Resources.btnUnApprove;
            this.lbToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lbToolStripButton1.LBPermissionCode = "";
            this.lbToolStripButton1.Name = "lbToolStripButton1";
            this.lbToolStripButton1.Size = new System.Drawing.Size(60, 37);
            this.lbToolStripButton1.Text = "取消审核";
            this.lbToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // 
            // frmEditReceiveBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmEditReceiveBill";
            this.Size = new System.Drawing.Size(490, 352);
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
        private Controls.LBToolStripButton lbToolStripButton1;
        private Controls.LBToolStripButton btnCancel;
        private Controls.LBToolStripButton btnUnCancel;
    }
}
