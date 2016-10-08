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

namespace LB.Controls.Report
{
    public partial class frmEditReport : LBUIPageBase
    {
        private ReportRequestArgs mReportArgs;
        public frmEditReport( ReportRequestArgs reportArgs)
        {
            InitializeComponent();
            mReportArgs = reportArgs;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (mReportArgs.ReportTemplateID > 0)
            {
                ReadFieldValue();
            }
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            try
            {
                ReportRequestArgs args = new ReportRequestArgs(0,mReportArgs.ReportTypeID,mReportArgs.DSDataSource,mReportArgs.RecordDR);

                this.txtReportPath.Text = ReportHelper.AddNewReport(args, this.txtReportTemplateName.Text);

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
                if (LB.WinFunction.LBCommonHelper.ConfirmMessage("是否确认删除该报表？", "提示", MessageBoxButtons.YesNo) ==
                     DialogResult.Yes)
                {
                    LBDbParameterCollection parms = new LBDbParameterCollection();
                    parms.Add(new LBParameter("ReportTemplateID", enLBDbType.Int64, mReportArgs.ReportTemplateID));
                    DataSet dsReturn;
                    Dictionary<string, object> dictResult;
                    ExecuteSQL.CallSP(12002, parms, out dsReturn, out dictResult);
                    this.Close();
                }
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
                    if (mReportArgs.ReportTemplateID == 0)
                    {
                        if (!File.Exists(this.txtReportPath.Text))
                        {
                            throw new Exception("报表文件不存在，无法保存！");
                        }
                        byte[] bReport = ReportHelper.ConvertToByte(this.txtReportPath.Text);
                        LBDbParameterCollection parms = new LBDbParameterCollection();
                        parms.Add(new LBParameter("ReportTemplateID", enLBDbType.Int64, 0));
                        parms.Add(new LBParameter("ReportTemplateName", enLBDbType.String, this.txtReportTemplateName.Text));
                        parms.Add(new LBParameter("TemplateFileTime", enLBDbType.DateTime, DateTime.Now));
                        parms.Add(new LBParameter("TemplateSeq", enLBDbType.Int32, 0));
                        parms.Add(new LBParameter("Description", enLBDbType.String, this.txtDescription.Text));
                        parms.Add(new LBParameter("TemplateData", enLBDbType.Object, bReport));
                        parms.Add(new LBParameter("ReportTypeID", enLBDbType.Int64, mReportArgs.ReportTypeID));
                        DataSet dsReturn;
                        Dictionary<string, object> dictResult;
                        ExecuteSQL.CallSP(12000, parms, out dsReturn, out dictResult);
                    }
                    else
                    {
                        byte[] bReport = null;
                        DateTime dtTemplateFileTime = DateTime.Now;
                        if (this.txtReportPath.Text.TrimEnd() != "")
                        {
                            if (!File.Exists(this.txtReportPath.Text))
                            {
                                throw new Exception("报表文件不存在，无法保存！");
                            }
                            bReport = ReportHelper.ConvertToByte(this.txtReportPath.Text);
                            dtTemplateFileTime = File.GetLastWriteTime(this.txtReportPath.Text);
                        }

                        LBDbParameterCollection parms = new LBDbParameterCollection();
                        parms.Add(new LBParameter("ReportTemplateID", enLBDbType.Int64, mReportArgs.ReportTemplateID));
                        parms.Add(new LBParameter("ReportTemplateName", enLBDbType.String, this.txtReportTemplateName.Text));
                        parms.Add(new LBParameter("TemplateFileTime", enLBDbType.DateTime, dtTemplateFileTime));
                        parms.Add(new LBParameter("TemplateSeq", enLBDbType.Int32, 0));
                        parms.Add(new LBParameter("Description", enLBDbType.String, this.txtDescription.Text));
                        parms.Add(new LBParameter("TemplateData", enLBDbType.Object, bReport));
                        parms.Add(new LBParameter("ReportTypeID", enLBDbType.Int64, mReportArgs.ReportTypeID));
                        DataSet dsReturn;
                        Dictionary<string, object> dictResult;
                        ExecuteSQL.CallSP(12001, parms, out dsReturn, out dictResult);
                    }
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnSelectReport_Click(object sender, EventArgs e)
        {
            try
            {
                openFile.InitialDirectory = ReportHelper.ReportPath;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string strFile = openFile.FileName;
                    this.txtReportPath.Text = strFile;
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }
        #region -- 读取并加载报表模板数据 --

        private void ReadFieldValue()
        {
            DataTable dtReportTemplate = ExecuteSQL.CallView(105, "", "ReportTemplateID=" + mReportArgs.ReportTemplateID, "");
            if (dtReportTemplate.Rows.Count > 0)
            {
                DataRow drReport = dtReportTemplate.Rows[0];
                this.txtReportTemplateName.Text = drReport["ReportTemplateName"].ToString();
                this.txtDescription.Text = drReport["Description"].ToString();
                //this.txtReportPath.Text = Path.Combine(ReportHelper.ReportPath, drReport["ReportTemplateName"].ToString() + ".frx");
            }
        }

        #endregion

    }
}
