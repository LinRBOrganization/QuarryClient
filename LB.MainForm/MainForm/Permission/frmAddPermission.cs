using LB.Controls;
using LB.WinFunction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LB.MainForm.Permission
{
    public partial class frmAddPermission : LBForm
    {
        private long mPermissionID;
        public frmAddPermission(long lPermissionID)
        {
            mPermissionID = lPermissionID;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadPermission();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        /// <summary>
        /// 查询权限名称
        /// </summary>
        private void LoadPermission()
        {
            DataTable dtPerm = ExecuteSQL.CallView(103, "*", "PermissionID=" + this.mPermissionID.ToString(), "");
            if (dtPerm.Rows.Count > 0)
            {
                this.txtPermissionName.Text = dtPerm.Rows[0]["PermissionName"].ToString().TrimEnd();
            }
        }
    }
}
