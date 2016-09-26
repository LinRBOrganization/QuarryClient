using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using LB.Controls;
using System.IO;
using LB.WinFunction;

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

                        this.txtReportPath.Text = strReportFullName;

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

        private void btnUpLoadReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtReportPath.Text != "")
                {
                    byte[] bReport = FileContent(this.txtReportPath.Text);

                    if (mReportTemplateID == 0)
                    {
                        LBDbParameterCollection parms = new LBDbParameterCollection();
                        parms.Add(new LBParameter("ReportTemplateID", enLBDbType.Int64, 0));
                        parms.Add(new LBParameter("ReportTemplateName", enLBDbType.String, this.txtReportTemplateName.Text));
                        parms.Add(new LBParameter("TemplateFileTime", enLBDbType.DateTime, DateTime.Now));
                        parms.Add(new LBParameter("TemplateSeq", enLBDbType.Int32, 0));
                        parms.Add(new LBParameter("Description", enLBDbType.String, this.txtReportPath.Text));
                        parms.Add(new LBParameter("TemplateData", enLBDbType.Object, bReport));
                        parms.Add(new LBParameter("ReportTypeID", enLBDbType.Int64, mReportTypeID));
                        DataSet dsReturn;
                        Dictionary<string,object> dictResult;
                        ExecuteSQL.CallSP(12000, parms, out dsReturn, out dictResult);
                    }
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private byte[] FileContent(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            try
            {
                byte[] buffur = new byte[fs.Length];
                fs.Read(buffur, 0, (int)fs.Length);

                return buffur;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (fs != null)
                {

                    //关闭资源  
                    fs.Close();
                }
            }
        }
    }
}
