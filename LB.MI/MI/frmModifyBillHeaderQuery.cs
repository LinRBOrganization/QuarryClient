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
using LB.Common;
using static LB.Common.Args.LBQueryFilterArgs;
using LB.Common.Args;

namespace LB.MI.MI
{
    public partial class frmModifyBillHeaderQuery : LBUIPageBase
    {
        public event GetCustomFilterEventHandle GetCustomFilterEvent;
        public frmModifyBillHeaderQuery()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadDataSource();
            this.ctlSearcher1.SetGridView(this.grdMain, "CustomerName");

            this.grdMain.CellDoubleClick += GrdMain_CellDoubleClick;
        }

        private void GrdMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    DataRowView drv = this.grdMain.Rows[e.RowIndex].DataBoundItem as DataRowView;
                    long lModifyBillHeaderID = LBConverter.ToInt64(drv["ModifyBillHeaderID"]);
                    if (lModifyBillHeaderID > 0)
                    {
                        frmModifyBillHeaderEdit frmEdit = new MI.frmModifyBillHeaderEdit(lModifyBillHeaderID);
                        frmEdit.PageAutoSize = true;
                        LBShowForm.ShowDialog(frmEdit);
                    }
                }
                LoadDataSource();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void LoadDataSource()
        {
            string strFilter = this.ctlSearcher1.GetFilter();

            if (GetCustomFilterEvent != null)
            {
                LBQueryFilterArgs args = new LBQueryFilterArgs();
                GetCustomFilterEvent(args);
                if (args.Filter != "")
                {
                    if (strFilter != "")
                        strFilter += " and ";
                    strFilter += args.Filter;
                }
            }

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
            args.ReportTypeID = 4;//调价单序时簿
            base.OnInitToolStripControl(args);

        }

        protected override void OnReportRequest(ReportRequestArgs args)
        {
            base.OnReportRequest(args);
            DataTable dtSource = ((DataView)this.grdMain.DataSource).Table.Copy();
            dtSource.TableName = "T004";
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
                frm.PageAutoSize = true;
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
