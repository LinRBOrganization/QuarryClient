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
using LB.Page.Helper;
using LB.Controls.Args;
using LB.Controls.Report;

namespace LB.RPReceive.RPReceive
{
    public partial class frmReceiveBillQuery : LBUIPageBase
    {
        public frmReceiveBillQuery()
        {
            InitializeComponent();
            this.grdMain.CellDoubleClick += GrdMain_CellDoubleClick;
        }

        private void GrdMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataRowView drvSelect = this.grdMain.Rows[e.RowIndex].DataBoundItem as DataRowView;
                    long lReceiveBillHeaderID = drvSelect["ReceiveBillHeaderID"] == DBNull.Value ?
                        0 : Convert.ToInt64(drvSelect["ReceiveBillHeaderID"]);
                    if (lReceiveBillHeaderID > 0)
                    {
                        frmEditReceiveBill frm = new frmEditReceiveBill(lReceiveBillHeaderID);
                        LBShowForm.ShowDialog(frm);

                        LoadDataSource();
                    }
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadDataSource();

            this.ctlSearcher1.SetGridView(this.grdMain,"CustomerName");
        }

        private void LoadDataSource()
        {
            string strFilter = this.ctlSearcher1.GetFilter();
            DataTable dtUser = ExecuteSQL.CallView(111,"", strFilter,"");
            this.grdMain.DataSource = dtUser.DefaultView;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmEditReceiveBill frm = new LB.RPReceive.frmEditReceiveBill(0);
                LBShowForm.ShowDialog(frm);

                LoadDataSource();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

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

        #region -- 报表 --

        protected override void OnInitToolStripControl(ToolStripReportArgs args)
        {
            args.LBToolStrip = skinToolStrip1;
            args.ReportTypeID = 2;//充值管理
            base.OnInitToolStripControl(args);

        }

        protected override void OnReportRequest(ReportRequestArgs args)
        {
            base.OnReportRequest(args);
            DataTable dtSource = ((DataView)this.grdMain.DataSource).Table.Copy();
            dtSource.TableName = "T002";
            DataSet dsSource = new DataSet("Report");
            dsSource.Tables.Add(dtSource);
            args.DSDataSource = dsSource;
        }

        #endregion
    }
}
