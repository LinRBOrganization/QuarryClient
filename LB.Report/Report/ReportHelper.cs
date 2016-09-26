using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LB.Report.Report
{
    public enum enBuildParmsType
    {
        /// <summary>
        /// 添加新报表
        /// </summary>
        AddNewReport,

        /// <summary>
        /// 更新参数和数据源
        /// </summary>
        ReSetData
    }


    public class ReportHelper
    {
        /// <summary>
        /// 报表文件保存路径
        /// </summary>
        public static string ReportPath
        {
            get
            {
                string strPath = Path.Combine(Application.StartupPath, "ReportFile");
                if (!Directory.Exists(strPath))
                    Directory.CreateDirectory(strPath);
                return strPath;
            }
        }

        public static void BuildReportParmsAndData(FastReport.Report report, ReportArgs reportArgs)
        {
            report.Parameters.Clear();
            List<FastReport.Data.Parameter> lstParm = new List<FastReport.Data.Parameter>();

            if (reportArgs.RecordDR != null)
            {
                foreach (DataColumn dc in reportArgs.RecordDR.Table.Columns)
                {
                    FastReport.Data.Parameter parm = new FastReport.Data.Parameter(dc.ColumnName);
                    parm.DataType = dc.DataType;
                    parm.Value = reportArgs.RecordDR[dc.ColumnName];
                    lstParm.Add(parm);
                }
            }

            if (reportArgs.DataSource != null)
            {
                report.RegisterData(reportArgs.DataSource, reportArgs.DataSource.Table.TableName);
                report.GetDataSource(reportArgs.DataSource.Table.TableName).Enabled = true;
            }
        }
    }

  //  public class ReportHelper
  //  {
  //      /// <summary>
  ///// 生成模板
  ///// </summary>
  ///// <param name="e">参数</param>
  ///// <param name="strTemplateName">模板文件名</param>
  //internal static void GenReportTemplate(ReportArgs e, string strTemplateName)
  //      {
  //          // 已处理打印预览
  //          if (e.HandledPrint)
  //          {
  //              return;
  //          }

    //          // 新建 FastReport
    //          using (FastReport.Report report = new FastReport.Report())
    //          {
    //              // 根据报表参数的 ReportParms 应用 参数及数据源 至 FastReport 中
    //              ReportHelper.BuildParmsAndData(e, report, ReportHelper.enBuildParmsAndDataActionType.AddNew);

    //              // 保存模板
    //              string strReportPath = Path.Combine(TS.Win.ReportExt.Helper.GetReportDirectory(), strTemplateName);
    //              report.Save(strReportPath);
    //              e.ReportPath = strTemplateName;
    //              // Dispose
    //              report.Dispose();
    //          }

    //          // 打开设计器
    //          Helper.OpenDesigner(strTemplateName, e.BizObjID, e.ReportIsFromEditPage, e.ReportTemplateTypeID);
    //      }

    //      /// <summary>
    ///// 根据报表参数的 ReportParms 应用 参数及数据源 至 FastReport 中
    ///// </summary>
    ///// <param name="e">报表参数</param>
    ///// <param name="report">FastReport</param>
    //public static void BuildParmsAndData(ReportArgs e, FastReport.Report report, enBuildParmsType actionType)
    //      {
    //          // FastReport 参数
    //          ReportFastParms fastParms = (ReportFastParms)e.ReportParms;

    //          // 先将旧的参数及数据源删除，以便刷新数据源
    //          if (actionType == enBuildParmsType.ReSetData)
    //          {
    //              report.Parameters.Clear();
    //              //report.ClearRegisterData();
    //          }

    //          // 参数
    //          if (!fastParms.HasInvokeBuildParametersAuto)
    //          {
    //              HelperFast.BuildParametersByReportArgs(e);
    //          }

    //          if (actionType == enBuildParmsAndDataActionType.SetValue)  // 对模板已有参数赋值
    //          {
    //              foreach (FastReport.Data.Parameter parm in report.Parameters)
    //              {
    //                  // 参数值是从 fastParms.ReportParameters 中传入的
    //                  foreach (FastReport.Data.Parameter parmArgs in fastParms.ReportParameters)
    //                  {
    //                      if (parm.Name.Equals(parmArgs.Name, StringComparison.CurrentCultureIgnoreCase))
    //                      {
    //                          parm.Value = parmArgs.Value;
    //                          break;
    //                      }
    //                  }
    //              }
    //          }
    //          else    // 添加新的参数至模板
    //          {
    //              foreach (FastReport.Data.Parameter parm in fastParms.ReportParameters)
    //              {
    //                  report.Parameters.Add(parm);
    //              }
    //          }

    //          // 数据源
    //          if (fastParms.HasInvokeBuildDataSourcesAuto)
    //          {
    //              Dictionary<string, object>.Enumerator enumerator = fastParms.ReportDataSources.GetEnumerator();
    //              while (enumerator.MoveNext())
    //              {
    //                  string description;
    //                  string strTableName = MakeTableNameStandard(enumerator.Current.Key, e.TableNames, out description);

    //                  DataTable table = null;
    //                  if (enumerator.Current.Value is DataTable)
    //                  {
    //                      table = (DataTable)enumerator.Current.Value;
    //                      report.RegisterData(table, strTableName);
    //                  }
    //                  else
    //                  {
    //                      DataView dvSource = (DataView)enumerator.Current.Value;
    //                      report.RegisterData(dvSource, strTableName);
    //                      if (dvSource != null)
    //                      {
    //                          table = dvSource.Table;
    //                      }
    //                  }
    //                  DataSourceBase dataSource = report.GetDataSource(strTableName);
    //                  dataSource.Enabled = true;
    //                  dataSource.SetDescription(description);
    //                  if (e.TableBizObj.ContainsKey(table))
    //                  {
    //                      dataSource.SetRelateBizObjID(e.TableBizObj[table]);
    //                  }
    //              }
    //          }
    //          else if (e.DataSource != null)
    //          {
    //              for (int i = 0, j = e.DataSource.Tables.Count; i < j; i++)
    //              {
    //                  DataTable table = RemoveDataSumLine(e.DataSource.Tables[i]);
    //                  string description;
    //                  string strTableName = MakeTableNameStandard(table.TableName, e.TableNames, out description);
    //                  report.RegisterData(table, strTableName);
    //                  DataSourceBase dataSource = report.GetDataSource(strTableName);
    //                  dataSource.Enabled = true;
    //                  dataSource.SetDescription(description);
    //                  if (e.TableBizObj.ContainsKey(table))
    //                  {
    //                      dataSource.SetRelateBizObjID(e.TableBizObj[table]);
    //                  }
    //              }
    //          }
    //      }

    //      #region -- 参数添加 --

    //      internal static void BuildParametersByReportArgs(RequestReportArgs e)
    //      {
    //          ReportFastParms fastParms = (ReportFastParms)e.ReportParms;
    //          List<FastReport.Data.Parameter> reportParameters = fastParms.ReportParameters;

    //          if (e.ReportIsFromEditPage)
    //          {
    //              if (e.MTRecordDR != null)
    //              {
    //                  BuildParamters(e.MTRecordDR, e.DTFieldConfig, reportParameters);
    //              }
    //          }
    //          else
    //          {
    //              BuildParamtersByDTCriteria(e.DTCriteria, reportParameters);
    //          }

    //          // 添加全局报表参数
    //          AddGlobalParameter(e, reportParameters);

    //          fastParms.HasInvokeBuildParametersAuto = true;
    //      }

    //      internal static void BuildParamters(DataRow row, DataTable fieldConfig, List<FastReport.Data.Parameter> reportParameters)
    //      {
    //          DataColumnCollection dataColumns = row.Table.Columns;
    //          DataView dvResultConfig = new DataView(fieldConfig);

    //          foreach (DataColumn dataColumn in dataColumns)
    //          {
    //              if (dataColumn.ColumnName.StartsWith("_"))
    //              {
    //                  continue;
    //              }

    //              string strFieldCaption = "";
    //              DataRow[] rows = fieldConfig.Select("FieldName='" + dataColumn.ColumnName + "'");
    //              if (rows.Length > 0)
    //              {
    //                  strFieldCaption = rows[0]["FieldCaption"].ToString().Trim();
    //              }
    //              if (strFieldCaption == "")
    //              {
    //                  strFieldCaption = dataColumn.ColumnName;
    //              }

    //              if (ParametersContainsName(reportParameters, dataColumn.ColumnName))
    //              {
    //                  string strTemp = strFieldCaption + "(" + dataColumn.ColumnName + ")";

    //                  int index = 1;
    //                  while (ParametersContainsName(reportParameters, strTemp))
    //                  {
    //                      strTemp = strFieldCaption + index.ToString() + "(" + dataColumn.ColumnName + ")";
    //                  }

    //                  strFieldCaption = strTemp;
    //              }

    //              FastReport.Data.Parameter parm = new FastReport.Data.Parameter(dataColumn.ColumnName);
    //              parm.DataType = dataColumn.DataType;
    //              parm.Value = row[dataColumn];
    //              parm.Description = strFieldCaption;
    //              reportParameters.Add(parm);
    //          }
    //      }

    //      private static bool ParametersContainsName(List<FastReport.Data.Parameter> reportParameters, string fieldName)
    //      {
    //          foreach (FastReport.Data.Parameter parm in reportParameters)
    //          {
    //              if (parm.Name.Equals(fieldName, StringComparison.CurrentCultureIgnoreCase))
    //              {
    //                  return true;
    //              }
    //          }
    //          return false;
    //      }

    //      #endregion -- 参数添加 --
    //  }
}
