using LB.Controls;
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
    public partial class frmAddUser : LBForm
    { 
        private long _UserID = 0;//用户ID号
        public frmAddUser(long lUserID)
        {
            InitializeComponent();
            _UserID = lUserID;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.txtUserType.DataSource = LB.Common.LBConst.GetConstData("UserType");//读取用户类型常量列表
            this.txtUserType.DisplayMember = "ConstText";
            this.txtUserType.ValueMember = "ConstValue";

            this.txtUserSex.DataSource = LB.Common.LBConst.GetConstData("UserSex");//读取用户类型常量列表
            this.txtUserSex.DisplayMember = "ConstText";
            this.txtUserSex.ValueMember = "ConstValue";
        }

        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveUser();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }
        
        //删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (LB.WinFunction.LBCommonHelper.ConfirmMessage("是否确认删除该用户？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteUser();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        //关闭
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

        //添加保存或者保存修改用户信息
        private void SaveUser()
        {
            int iSPType = 0;

            if (_UserID == 0)
            {
                iSPType = 10000;//DBUser_Insert
            }
            else
            {
                iSPType = 10001;//DBUser_Insert
            }
            
            DataTable dtSPIN = new DataTable();
            dtSPIN.Columns.Add("UserID", typeof(long));
            dtSPIN.Columns.Add("LoginName", typeof(string));
            dtSPIN.Columns.Add("UserName", typeof(string));
            dtSPIN.Columns.Add("UserPassword", typeof(string));
            dtSPIN.Columns.Add("UserSex", typeof(int));
            dtSPIN.Columns.Add("UserType", typeof(int));
            DataRow drNew = dtSPIN.NewRow();
            drNew["UserID"] = _UserID;
            drNew["LoginName"] = this.txtLoginName.Text;
            drNew["UserName"] = this.txtUserName.Text;
            drNew["UserPassword"] = this.txtUserPassword.Text;
            drNew["UserSex"] = this.txtUserSex.SelectedValue;
            drNew["UserType"] = this.txtUserType.SelectedValue;
            dtSPIN.Rows.Add(drNew);

            DataSet dsReturn;
            DataTable dtResult;
            ExecuteSQL.CallSP(iSPType, dtSPIN, out dsReturn, out dtResult);
            if(dtResult!=null&& dtResult.Rows.Count > 0)
            {
                long.TryParse(dtResult.Rows[0]["UserID"].ToString(), out _UserID);
            }
            LB.WinFunction.LBCommonHelper.ShowCommonMessage("保存成功！");
        }

        //删除该用户
        private void DeleteUser()
        {
            int iSPType = 10002;

            DataTable dtSPIN = new DataTable();
            dtSPIN.Columns.Add("UserID", typeof(long));
            DataRow drNew = dtSPIN.NewRow();
            drNew["UserID"] = _UserID;
            dtSPIN.Rows.Add(drNew);

            DataSet dsReturn;
            DataTable dtResult;
            ExecuteSQL.CallSP(iSPType, dtSPIN, out dsReturn, out dtResult);
            LB.WinFunction.LBCommonHelper.ShowCommonMessage("删除成功！");
        }
    }
}
