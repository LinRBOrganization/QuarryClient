using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LB.Controls;

namespace LB.MI.MI
{
    public partial class frmCarWeightManager : LBUIPageBase
    {
        public frmCarWeightManager()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.txtBillDateFrom.Text = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
            this.txtBillDateTo.Text = DateTime.Now.ToString("yyyy-MM-dd");

            this.ctlSearcher1.SetGridView(this.grdMain, "CustomerName");
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
    }
}
