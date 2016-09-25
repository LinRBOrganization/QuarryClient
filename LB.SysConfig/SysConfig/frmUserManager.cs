using LB.Controls;
using LB.Page.Helper;
using LB.Report.Report;
using LB.WinFunction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LB.SysConfig
{
    public partial class frmUserManager : LBUIPageBase
    {
        public frmUserManager()
        {
            InitializeComponent();
            this.grdMain.AutoGenerateColumns = false;
            this.grdMain.LBLoadConst();
            this.grdMain.DataError += delegate (object sender, DataGridViewDataErrorEventArgs e) { };
            LoadDataSource();//加载数据源
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }

        private void LoadDataSource()
        {
            DataTable dtUser = ExecuteSQL.CallView(100);
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
                frmAddUser frm = new frmAddUser(0);
                frm.ShowDialog();
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

        private void btnEditReport_Click(object sender, EventArgs e)
        {
            try
            {
                ReportArgs reportArgs = new ReportArgs((int)1, (DataView)this.grdMain.DataSource, null);
                frmReport frm = new frmReport(reportArgs);
                LBShowForm.ShowDialog(frm);
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }
    }
}
