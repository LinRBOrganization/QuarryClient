using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using LB.Controls;
using System.IO;

namespace LB.Report.Report
{
    public partial class frmEditReport : LBUIPageBase
    {
        private long mReportTemplateID;
        private long mReportTypeID;
        private ReportArgs mReportArgs;
        public frmEditReport(long lReportTemplateID,long lReportTypeID, ReportArgs reportArgs)
        {
            InitializeComponent();
            mReportTemplateID = lReportTemplateID;
            mReportTypeID = lReportTypeID;
            mReportArgs = reportArgs;
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtReportTemplateName.Text.TrimEnd() != "")
                {
                    using(FastReport.Report report = new FastReport.Report())
                    {
                        ReportHelper.BuildReportParmsAndData(report, mReportArgs);

                        string strReportFullName = Path.Combine(ReportHelper.ReportPath, txtReportTemplateName.Text.TrimEnd() + ".frx");
                        report.Save(strReportFullName);

                        Form frm = new Form();
                        frm.Icon = FastReport.Utils.Config.PreviewSettings.Icon;
                        frm.Show();
                        report.Design();
                        report.Dispose();
                        frm.Close();
                    }
                    //ReportHelper.BuildReportParmsAndData()
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnDeleteReport_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }
    }
}
