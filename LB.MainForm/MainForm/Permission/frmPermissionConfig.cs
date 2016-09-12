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
    public partial class frmPermissionConfig : LBForm
    {
        private TreeNode mtnSelectedNode = null;
        public frmPermissionConfig()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BuildPermissionTree();
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

        #region -- 权限树 --

        private void BuildPermissionTree()
        {
            Dictionary<long, TreeNode> dictTreeNode = new Dictionary<long, TreeNode>();
            DataTable dtPermission = ExecuteSQL.CallView(103,"","", "ParentPermissionID asc");
            foreach(DataRow dr in dtPermission.Rows)
            {
                long lPermissionID = Convert.ToInt64(dr["PermissionID"]);
                long lParentPermissionID = dr["ParentPermissionID"]==DBNull.Value?
                    0: Convert.ToInt64(dr["ParentPermissionID"]);
                string strPermissionName = dr["PermissionName"].ToString().TrimEnd();
                TreeNode tnChild = new TreeNode(strPermissionName);
                tnChild.Tag = dr;
                if (dictTreeNode.ContainsKey(lParentPermissionID))
                {
                    dictTreeNode[lParentPermissionID].Nodes.Add(tnChild);
                }
                else
                {
                    this.tvPermission.Nodes.Add(tnChild);
                }
                dictTreeNode.Add(lPermissionID, tnChild);
            }
        }

        #endregion

        private void tvPermission_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tvPermission_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                this.mtnSelectedNode = e.Node;

                e.Node.ContextMenuStrip = this.cmsPermission;
                this.cmsPermission.Show();
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnAddPermission_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnDeletePermission_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void btnMovePermission_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void tvPermission_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }
    }
}
