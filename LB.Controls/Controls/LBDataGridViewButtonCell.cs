using LB.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LB.Controls
{
    public class LBDataGridViewButtonCell: DataGridViewButtonCell
    {
        protected override void OnContentClick(DataGridViewCellEventArgs e)
        {
            base.OnContentClick(e);
        }

        protected override void OnClick(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                DataGridViewColumn dc = this.DataGridView.Columns[e.ColumnIndex];
                if (dc is LBDataGridViewButtonColumn)
                {
                    LBDataGridViewButtonColumn buttonColumn = dc as LBDataGridViewButtonColumn;
                    if (buttonColumn.LBPermissionCode != "")
                    {
                        try
                        {
                            LBPermission.VerifyUserPermission(buttonColumn.LBPermissionCode);
                            //LBLog.InsertSysLog(buttonColumn.LBPermissionCode);
                        }
                        catch (Exception ex)
                        {
                            LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
                            return;
                        }
                        base.OnClick(e);
                    }
                }
            }
        }
    }
}
