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
    public partial class frmItemBaseManager : LBUIPageBase
    {
        public frmItemBaseManager()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BuildTree();
            //加载视图配置数据源
            ReSearchData();

            btnAddItemType.Click += btnAddItemType_Click;
            btnEditItemType.Click += btnEditItemType_Click;
            btnDeleteItemType.Click += btnDeleteItemType_Click;
            btnAddItemBase.Click += BtnAddItemBase_Click;
            btnEditItemBase.Click += btnEditItemBase_Click;
            btnDeleteItemBase.Click += btnDeleteItemBase_Click;
            btnReflush.Click += btnReflush_Click;
            btnTableSetting.Click += btnTableSetting_Click;
            btnSort.Click += btnSort_Click;
        }

        private void btnSort_Click(object sender, EventArgs e)
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

        private void btnTableSetting_Click(object sender, EventArgs e)
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

        private void btnReflush_Click(object sender, EventArgs e)
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

        private void btnDeleteItemBase_Click(object sender, EventArgs e)
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

        private void btnEditItemBase_Click(object sender, EventArgs e)
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

        private void BtnAddItemBase_Click(object sender, EventArgs e)
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

        private void btnDeleteItemType_Click(object sender, EventArgs e)
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

        private void btnEditItemType_Click(object sender, EventArgs e)
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

        private void btnAddItemType_Click(object sender, EventArgs e)
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
            string strSQL = "select * from dbo.Db_v_ItemBase";
            if (this.txtFilter.Text.TrimEnd() != "")
            {
                strFilter = string.Format(@"ItemTypeName like '%{0}%'
or ItemCode like '%{0}%'
or ItemName like '%{0}%'
or ItemMode like '%{0}%'
or UOMName like '%{0}%'
or Description like '%{0}%'", this.txtFilter.Text.TrimEnd());
                strSQL += " where "+ strFilter;
            }
            DataTable dtView = ExecuteSQL.CallDirectSQL(strSQL);
            this.grdMain.DataSource = dtView.DefaultView;
        }

        private void BuildTree()
        {
            string strFieldNames = "ItemTypeID,ItemTypeName";
            DataTable dt = ExecuteSQL.CallView(200, strFieldNames, "", "ItemTypeID");
            TreeNode tnTop = new TreeNode("物料分类");
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode tn = new TreeNode(dr["ItemTypeName"].ToString().TrimEnd());
                tn.Tag = dr;
                tnTop.Nodes.Add(tn);
            }
        }
    }
}
