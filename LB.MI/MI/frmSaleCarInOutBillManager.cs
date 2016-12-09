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

namespace LB.MI.MI
{
    public partial class frmSaleCarInOutBillManager : LBUIPageBase
    {
        public frmSaleCarInOutBillManager()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.grdMain.LBLoadConst();

            LoadAllSalesBill();//磅单清单
            this.ctlSearcher1.SetGridView(this.grdMain, "CarNum");

            this.grdMain.CellDoubleClick += GrdMain_CellDoubleClick;
        }

        #region -- 双击打开清单  --

        private void GrdMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    long lSaleCarInBillID = LBConverter.ToInt64(this.grdMain["SaleCarInBillID", e.RowIndex].Value);
                    if (lSaleCarInBillID > 0)
                    {
                        using (DataTable dtBill = ExecuteSQL.CallView(125, "", "SaleCarInBillID=" + lSaleCarInBillID.ToString(), ""))
                        {
                            //if (dtBill.Rows.Count > 0)
                            //{
                            //    DataRow drBill = dtBill.Rows[0];
                            //    long lSaleCarOutBillID = LBConverter.ToInt64(drBill["SaleCarOutBillID"]);
                            //    long lCarID= LBConverter.ToInt64(drBill["CarID"]);
                            //    long lItemID = LBConverter.ToInt64(drBill["ItemID"]);
                            //    long lCustomerID = LBConverter.ToInt64(drBill["CustomerID"]);
                            //    int iBillStatus = LBConverter.ToInt32(drBill["BillStatus"]);

                            //    this.txtBillDateIn.Text = drBill["BillDateIn"].ToString();
                            //    this.txtBillDateOut.Text = drBill["BillDateOut"].ToString().TrimEnd();
                            //    this.txtCalculateType.SelectedValue = drBill["CalculateType"];
                            //    this.txtCarID.TextBox.SelectedItemID = drBill["CarID"];
                            //    this.txtItemID.TextBox.SelectedItemID = drBill["ItemID"];
                            //    this.txtCustomerID.TextBox.SelectedItemID = drBill["CustomerID"];
                            //    this.txtCarTare.Text = drBill["CarTare"].ToString();
                            //    this.txtDescription.Text = drBill["Description"].ToString();
                            //    this.txtReceiveType.SelectedValue = drBill["ReceiveType"];
                            //    this.txtSaleCarInBillCode.Text = drBill["SaleCarInBillCode"].ToString().TrimEnd();
                            //    this.txtSaleCarInBillID.Text = drBill["SaleCarInBillID"].ToString().TrimEnd();
                            //    this.txtSaleCarOutBillID.Text = drBill["SaleCarOutBillID"].ToString().TrimEnd();
                            //    this.txtTotalWeight.Text = drBill["TotalWeight"].ToString().TrimEnd();
                            //    this.txtSuttleWeight.Text = drBill["SuttleWeight"].ToString().TrimEnd();
                            //    this.txtPrice.Text = drBill["Price"].ToString().TrimEnd();
                            //    this.txtAmount.Text = drBill["Amount"].ToString().TrimEnd();
                            //    this.txtBillStatus.SelectedValue = drBill["BillStatus"];

                            //    if(lSaleCarOutBillID >= 0)
                            //    {

                            //    }
                            //}
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        #endregion -- 双击打开清单  --

        #region -- 查询磅单清单 --

        private void LoadAllSalesBill()
        {
            string strFilter = this.ctlSearcher1.GetFilter();
            if (strFilter != "")
            {
                strFilter += " and ";
            }
            DateTime dtBillDateFrom = Convert.ToDateTime(this.txtBillDateFrom.Text);
            DateTime dtBillDateTo = Convert.ToDateTime(this.txtBillDateTo.Text);
            strFilter += "(BillDateIn>='" + dtBillDateFrom.ToString("yyyy-MM-dd") + "' and BillDateIn<='" + dtBillDateTo.AddDays(1).ToString("yyyy-MM-dd") + "')";
            DataTable dtBill = ExecuteSQL.CallView(125, "", strFilter, "");
            this.grdMain.DataSource = dtBill.DefaultView;
        }

        #endregion

        #region -- 按钮事件 --

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                
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
                LoadAllSalesBill();
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
