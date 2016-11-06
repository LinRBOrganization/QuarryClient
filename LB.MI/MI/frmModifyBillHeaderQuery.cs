using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LB.Controls;
using LB.WinFunction;
using LB.Controls.Args;
using LB.Controls.Report;
using LB.Page.Helper;

namespace LB.MI.MI
{
    public partial class frmModifyBillHeaderQuery : LBUIPageBase
    {
        public frmModifyBillHeaderQuery()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadDataSource();
            this.ctlSearcher1.SetGridView(this.grdMain, "CustomerName");
        }

        private void LoadDataSource()
        {
            string strFilter = this.ctlSearcher1.GetFilter();
            DataTable dtUser = ExecuteSQL.CallView(114, "", strFilter, "");
            this.grdMain.DataSource = dtUser.DefaultView;

            this.grdMain.HiddenSaveColumnValue("CustomerName", "ModifyBillCode", "BillDate", "EffectDate", "HeaderDescription", 
                "ApproveDate", "ApproveBy", "CreateBy", "CreateTime", "ChangeBy", "ChangeTime",
                "IsApprove", "IsCancel", "CancelBy", "CancelTime");
        }

        #region -- 报表 --

        protected override void OnInitToolStripControl(ToolStripReportArgs args)
        {
            args.LBToolStrip = skinToolStrip1;
            args.ReportTypeID = 3;//客户管理
            base.OnInitToolStripControl(args);

        }

        protected override void OnReportRequest(ReportRequestArgs args)
        {
            base.OnReportRequest(args);
            DataTable dtSource = ((DataView)this.grdMain.DataSource).Table.Copy();
            dtSource.TableName = "T003";
            DataSet dsSource = new DataSet("Report");
            dsSource.Tables.Add(dtSource);
            args.DSDataSource = dsSource;
        }

        #endregion

        #region -- 按钮事件 --

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDataSource();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmModifyBillHeaderEdit frm = new frmModifyBillHeaderEdit(0);
                LBShowForm.ShowDialog(frm);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        #endregion -- 按钮事件 --

    }
}
