using LB.Controls;
using LB.WinFunction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LB.MM
{
    public partial class frmDevelopViewConfig : LBUIPageBase
    {
        public frmDevelopViewConfig()
        {
            InitializeComponent();
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //加载视图配置数据源
            ReSearchData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ReSearchData();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.grdMain.CurrentCell = null;
                this.grdMain.EndEdit();
                DataView dvResult = this.grdMain.DataSource as DataView;
                
                foreach (DataGridViewRow dgvr in this.grdMain.Rows)
                {
                    if (dgvr.DataBoundItem == null)
                        continue;

                    DataRowView drv = dgvr.DataBoundItem as DataRowView;

                    if(drv.Row.RowState!= DataRowState.Added &&
                       drv.Row.RowState != DataRowState.Modified)
                    {
                        continue;
                    }

                    long lSysViewTypeID = drv["SysViewTypeID"] == DBNull.Value ? 
                        0 : Convert.ToInt64(drv["SysViewTypeID"]);
                    string strSysViewType = drv["SysViewType"].ToString().TrimEnd();
                    string strSysViewName = drv["SysViewName"].ToString().TrimEnd();

                    if (strSysViewType != "" && strSysViewName != "")
                    {
                        int iSPType = 9000;//Insert
                        LBDbParameterCollection parmCol = new LBDbParameterCollection();

                        if (lSysViewTypeID > 0)
                        {
                            parmCol.Add(new LBParameter("SysViewTypeID", enLBDbType.Int64, lSysViewTypeID));
                            iSPType = 9001;//Update
                        }
                        else
                        {
                            parmCol.Add(new LBParameter("SysViewTypeID", enLBDbType.Int64, lSysViewTypeID,true));
                        }

                        parmCol.Add(new LBParameter("SysViewType", enLBDbType.String, strSysViewType));
                        parmCol.Add(new LBParameter("SysViewName", enLBDbType.String, strSysViewName));

                        DataSet dsReturn;
                        Dictionary<string, object> dictValue;
                        try
                        {
                            ExecuteSQL.CallSP(iSPType, parmCol, out dsReturn, out dictValue);
                            dgvr.ErrorText = "";
                            if (dictValue.ContainsKey("SysViewTypeID"))
                            {
                                drv["SysViewTypeID"] = dictValue["SysViewTypeID"];
                            }
                        }
                        catch(Exception ex)
                        {
                            dgvr.ErrorText = ex.Message;
                        }
                    }
                }
                dvResult.Table.AcceptChanges();
                LB.WinFunction.LBCommonHelper.ShowCommonMessage("保存成功！");
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void ReSearchData()
        {
            string strFilter = "";
            string strSQL = "select * from dbo.SysViewType";
            if (this.txtFilter.Text.TrimEnd() != "")
            {
                strFilter = "SysViewType like '%" + this.txtFilter.Text.TrimEnd() + "%' or SysViewName like '%" + this.txtFilter.Text.TrimEnd() + "%'";
                strSQL += " where "+ strFilter;
            }
            DataTable dtView = ExecuteSQL.CallDirectSQL(strSQL);
            this.grdMain.DataSource = dtView.DefaultView;
        }
    }
}
