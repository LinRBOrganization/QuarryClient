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
using LB.Common;
using LB.Page.Helper;

namespace LB.MI.MI
{
    public partial class frmModifyBillHeaderEdit : LBUIPageBase
    {
        private long mModifyBillHeaderID;
        public frmModifyBillHeaderEdit(long lModifyBillHeaderID)
        {
            InitializeComponent();
            mModifyBillHeaderID = lModifyBillHeaderID;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.ctlFieldHeaderPanel1.AddFiledControl("单据编码:", this.txtModifyBillCode, 1, 1, 1);
            this.ctlFieldHeaderPanel1.AddFiledControl("单据日期:", this.txtBillDate, 1, 2, 1);
            this.ctlFieldHeaderPanel1.AddFiledControl("生效日期:", this.txtEffectDate, 1, 3, 1);
            this.ctlFieldHeaderPanel1.AddFiledControl("客户名称:", this.txtCustomerID, 2, 1, 2);
            this.ctlFieldHeaderPanel1.AddFiledControl("备     注 :", this.txtDescription, 2, 3, 2);
            this.ctlFieldHeaderPanel1.AddFiledControl("制 单 人 :", this.txtCreateBy, 3, 1, 1);
            this.ctlFieldHeaderPanel1.AddFiledControl("制单日期:", this.txtCreateTime, 3, 2, 1);
            this.ctlFieldHeaderPanel1.AddFiledControl("修 改 人 :", this.txtChangeBy, 3, 3, 1);
            this.ctlFieldHeaderPanel1.AddFiledControl("修改日期:", this.txtChangeTime, 3, 4, 1);
            this.ctlFieldHeaderPanel1.AddFiledControl("审 核 人 :", this.txtApproveBy, 4, 1, 1);
            this.ctlFieldHeaderPanel1.AddFiledControl("审核日期:", this.txtApproveTime, 4, 2, 1);

            DataTable dtCustom = ExecuteSQL.CallView(110);
            this.txtCustomerID.TextBox.IDColumnName = "CustomerID";
            this.txtCustomerID.TextBox.TextColumnName = "CustomerName";
            this.txtCustomerID.TextBox.PopDataSource = dtCustom.DefaultView;

            //刷新单头信息
            ReadFieldValue(mModifyBillHeaderID);
        }

        #region -- 按钮事件 --

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            try
            {
                frmItemBaseManager frmItem = new frmItemBaseManager();
                LBShowForm.ShowDialog(frmItem);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            try
            {
                
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
                SaveHeader();
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (LB.WinFunction.LBCommonHelper.ConfirmMessage("是否确认删除调价单？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (mModifyBillHeaderID > 0)
                    {
                        LBDbParameterCollection parmCol = new LBDbParameterCollection();
                        parmCol.Add(new LBParameter("ModifyBillHeaderID", enLBDbType.Int64, mModifyBillHeaderID));
                        DataSet dsReturn;
                        Dictionary<string, object> dictValue;
                        ExecuteSQL.CallSP(13602, parmCol, out dsReturn, out dictValue);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }


        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                if (LB.WinFunction.LBCommonHelper.ConfirmMessage("是否确认审核调价单？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (mModifyBillHeaderID > 0)
                    {
                        LBDbParameterCollection parmCol = new LBDbParameterCollection();
                        parmCol.Add(new LBParameter("ModifyBillHeaderID", enLBDbType.Int64, mModifyBillHeaderID));
                        DataSet dsReturn;
                        Dictionary<string, object> dictValue;
                        ExecuteSQL.CallSP(13603, parmCol, out dsReturn, out dictValue);

                        //刷新单头信息
                        ReadFieldValue(mModifyBillHeaderID);
                    }
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnUnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                if (LB.WinFunction.LBCommonHelper.ConfirmMessage("是否确认取消审核调价单？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (mModifyBillHeaderID > 0)
                    {
                        LBDbParameterCollection parmCol = new LBDbParameterCollection();
                        parmCol.Add(new LBParameter("ModifyBillHeaderID", enLBDbType.Int64, mModifyBillHeaderID));
                        DataSet dsReturn;
                        Dictionary<string, object> dictValue;
                        ExecuteSQL.CallSP(13604, parmCol, out dsReturn, out dictValue);

                        //刷新单头信息
                        ReadFieldValue(mModifyBillHeaderID);
                    }
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (LB.WinFunction.LBCommonHelper.ConfirmMessage("是否确认作废调价单？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (mModifyBillHeaderID > 0)
                    {
                        LBDbParameterCollection parmCol = new LBDbParameterCollection();
                        parmCol.Add(new LBParameter("ModifyBillHeaderID", enLBDbType.Int64, mModifyBillHeaderID));
                        DataSet dsReturn;
                        Dictionary<string, object> dictValue;
                        ExecuteSQL.CallSP(13605, parmCol, out dsReturn, out dictValue);

                        //刷新单头信息
                        ReadFieldValue(mModifyBillHeaderID);
                    }
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnUnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (LB.WinFunction.LBCommonHelper.ConfirmMessage("是否确认取消作废调价单？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (mModifyBillHeaderID > 0)
                    {
                        LBDbParameterCollection parmCol = new LBDbParameterCollection();
                        parmCol.Add(new LBParameter("ModifyBillHeaderID", enLBDbType.Int64, mModifyBillHeaderID));
                        DataSet dsReturn;
                        Dictionary<string, object> dictValue;
                        ExecuteSQL.CallSP(13606, parmCol, out dsReturn, out dictValue);

                        //刷新单头信息
                        ReadFieldValue(mModifyBillHeaderID);
                    }
                }
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
                mModifyBillHeaderID = 0;
                ReadFieldValue(mModifyBillHeaderID);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        #endregion -- 按钮事件 --

        #region -- 保存单头信息 --

        private void SaveHeader()
        {
            this.VerifyTextBoxIsEmpty();
            int iSPType = 13600;
            if (mModifyBillHeaderID > 0)
            {
                iSPType = 13601;
            }

            LBDbParameterCollection parmCol = new LBDbParameterCollection();
            parmCol.Add(new LBParameter("ModifyBillHeaderID", enLBDbType.Int64, mModifyBillHeaderID));
            parmCol.Add(new LBParameter("CustomerID", enLBDbType.Int64, this.txtCustomerID.TextBox.SelectedItemID));
            parmCol.Add(new LBParameter("ModifyBillCode", enLBDbType.String, this.txtModifyBillCode.Text));
            parmCol.Add(new LBParameter("BillDate", enLBDbType.DateTime, this.txtBillDate.Text));
            parmCol.Add(new LBParameter("EffectDate", enLBDbType.DateTime, this.txtEffectDate.Text));
            parmCol.Add(new LBParameter("Description", enLBDbType.String, this.txtDescription.Text));

            DataSet dsReturn;
            Dictionary<string, object> dictValue;
            ExecuteSQL.CallSP(iSPType, parmCol, out dsReturn, out dictValue);
            if (dictValue.ContainsKey("ModifyBillHeaderID"))
            {
                mModifyBillHeaderID = LBConverter.ToInt64(dictValue["ModifyBillHeaderID"]);
            }
            if (dictValue.ContainsKey("ModifyBillCode"))
            {
                this.txtModifyBillCode.Text = dictValue["ModifyBillCode"].ToString();
            }
            //刷新单头信息
            ReadFieldValue(mModifyBillHeaderID);
        }

        #endregion

        #region -- 刷新单头数据 --

        private void ReadFieldValue(long lModifyBillHeaderID)
        {
            if (lModifyBillHeaderID > 0)
            {
                DataTable dtHeader = ExecuteSQL.CallView(115, "", "ModifyBillHeaderID=" + lModifyBillHeaderID, "");
                if (dtHeader.Rows.Count > 0)
                {
                    DataRow drHeader = dtHeader.Rows[0];
                    this.txtApproveBy.Text = drHeader["ApproveBy"].ToString();
                    this.txtApproveTime.Text = drHeader["ApproveTime"].ToString();
                    this.txtBillDate.Text = drHeader["BillDate"].ToString();
                    this.txtChangeBy.Text = drHeader["ChangeBy"].ToString();
                    this.txtChangeTime.Text = drHeader["ChangeTime"].ToString();
                    this.txtCreateBy.Text = drHeader["CreateBy"].ToString();
                    this.txtCreateTime.Text = drHeader["CreateTime"].ToString();
                    this.txtCustomerID.TextBox.SelectedItemID =LBConverter.ToInt64( drHeader["CustomerID"]);
                    this.txtDescription.Text = drHeader["Description"].ToString();
                    this.txtEffectDate.Text = drHeader["EffectDate"].ToString();
                    this.txtModifyBillCode.Text = drHeader["ModifyBillCode"].ToString();

                    ResetFieldControlStatus(drHeader);
                }
            }
            else
            {
                this.txtApproveBy.Text = "";
                this.txtApproveTime.Text = "";
                this.txtChangeBy.Text = "";
                this.txtChangeTime.Text = "";
                this.txtCreateBy.Text = "";
                this.txtCreateTime.Text = "";
                this.txtDescription.Text = "";
                this.txtModifyBillCode.Text = "";
                this.grdMain.DataSource = null;

                ResetFieldControlStatus(null);
            }
        }

        #endregion -- 刷新单头数据 --

        #region -- 刷新按钮以及控件状态 --

        private void ResetFieldControlStatus(DataRow drHeader)
        {
            this.btnAdd.Visible = true;
            this.btnAddDetail.Visible = true;
            this.btnApprove.Visible = true;
            this.btnUnApprove.Visible = true;
            this.btnCancel.Visible = true;
            this.btnUnCancel.Visible = true;
            this.btnSave.Visible = true;
            this.btnDeleteDetail.Visible = true;
            this.btnDelete.Visible = true;
            this.btnReflesh.Visible = true;
            this.btnCopy.Visible = true;

            this.txtBillDate.Enabled = true;
            this.txtCustomerID.Enabled = true;
            this.txtDescription.Enabled = true;
            this.txtEffectDate.Enabled = true;
            this.grdMain.ReadOnly = false;

            if (mModifyBillHeaderID == 0 || drHeader==null)
            {
                //添加状态
                this.btnApprove.Visible = false;
                this.btnUnApprove.Visible = false;
                this.btnCancel.Visible = false;
                this.btnUnCancel.Visible = false;
                this.btnDelete.Visible = false;
                this.btnCopy.Visible = false;
                this.btnReflesh.Visible = false;
            }
            else
            {
                bool bolIsApprove = LBConverter.ToBoolean(drHeader["IsApprove"]);
                bool bolIsCancel = LBConverter.ToBoolean(drHeader["IsCancel"]);

                if (bolIsCancel)//已作废
                {
                    this.btnAddDetail.Visible = false;
                    this.btnApprove.Visible = false;
                    this.btnUnApprove.Visible = false;
                    this.btnCancel.Visible = false;
                    this.btnSave.Visible = false;
                    this.btnDeleteDetail.Visible = false;
                    this.btnDelete.Visible = false;

                    this.txtBillDate.Enabled = false;
                    this.txtCustomerID.Enabled = false;
                    this.txtDescription.Enabled = false;
                    this.txtEffectDate.Enabled = false;
                    this.grdMain.ReadOnly = true;
                }
                else if (bolIsApprove)//已审核
                {
                    this.btnAddDetail.Visible = false;
                    this.btnApprove.Visible = false;
                    this.btnCancel.Visible = false;
                    this.btnUnCancel.Visible = false;
                    this.btnSave.Visible = false;
                    this.btnDeleteDetail.Visible = false;
                    this.btnDelete.Visible = false;

                    this.txtBillDate.Enabled = false;
                    this.txtCustomerID.Enabled = false;
                    this.txtDescription.Enabled = false;
                    this.txtEffectDate.Enabled = false;
                    this.grdMain.ReadOnly = false;

                    this.grdMain.ReadOnly = true;
                }
                else if (!bolIsApprove)//未审核
                {
                    this.btnUnApprove.Visible = false;
                    this.btnUnCancel.Visible = false;
                }

            }
        }

        #endregion

        
    }
}
