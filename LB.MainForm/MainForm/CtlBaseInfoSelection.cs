using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LB.Common;
using LB.WinFunction;
using static LB.Controls.Args.SelectedRowArgs;
using LB.Controls.Args;

namespace LB.MainForm
{
    public partial class CtlBaseInfoSelection : UserControl
    {
        public event SelectedRowEventHandle SelectedRowEvent;
        private enBaseInfoType _BaseInfoType= enBaseInfoType.None;
        public enBaseInfoType BaseInfoType
        {
            get
            {
                return _BaseInfoType;
            }
        }

        public CtlBaseInfoSelection()
        {
            InitializeComponent();

            this.grdCar.Visible = false;
            this.grdCustomer.Visible = false;
            this.grdItem.Visible = false;

            this.grdCar.CellClick += GrdCar_CellClick;
            this.grdCustomer.CellClick += GrdCustomer_CellClick;
            this.grdItem.CellClick += GrdItem_CellClick;
        }

        private void GrdItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (SelectedRowEvent != null)
                    {
                        DataRow drSelect = ((DataRowView)this.grdItem.Rows[e.RowIndex].DataBoundItem).Row;
                        SelectedRowArgs args = new SelectedRowArgs( enBaseInfoType.Item, drSelect);
                        SelectedRowEvent(args);
                    }
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void GrdCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (SelectedRowEvent != null)
                    {
                        DataRow drSelect = ((DataRowView)this.grdCustomer.Rows[e.RowIndex].DataBoundItem).Row;
                        SelectedRowArgs args = new SelectedRowArgs(enBaseInfoType.Customer, drSelect);
                        SelectedRowEvent(args);
                    }
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        private void GrdCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (SelectedRowEvent != null)
                    {
                        DataRow drSelect = ((DataRowView)this.grdCar.Rows[e.RowIndex].DataBoundItem).Row;
                        SelectedRowArgs args = new SelectedRowArgs(enBaseInfoType.Car, drSelect);
                        SelectedRowEvent(args);
                    }
                }
            }
            catch (Exception ex)
            {
                LB.WinFunction.LBCommonHelper.DealWithErrorMessage(ex);
            }
        }

        public void ChangeItemType(enBaseInfoType eBaseInfoType)
        {
            _BaseInfoType = eBaseInfoType;
            if (eBaseInfoType== enBaseInfoType.None)
            {
                //this.grdCar.Visible = false;
                //this.grdCustomer.Visible = false;
                //this.grdItem.Visible = false;
            }
            else if (eBaseInfoType == enBaseInfoType.Car)
            {
                this.grdCar.Visible = true;
                this.grdCar.Dock = DockStyle.Fill;
                this.grdCustomer.Visible = false;
                this.grdItem.Visible = false;
            }
            else if (eBaseInfoType == enBaseInfoType.Customer)
            {
                this.grdCar.Visible = false;
                this.grdCustomer.Visible = true;
                this.grdCustomer.Dock = DockStyle.Fill;
                this.grdItem.Visible = false;
            }
            else if (eBaseInfoType == enBaseInfoType.Item)
            {
                this.grdCar.Visible = false;
                this.grdCustomer.Visible = false;
                this.grdItem.Visible = true;
                this.grdItem.Dock = DockStyle.Fill;
            }
        }

        public void LoadDataSource(string strFilter)
        {
            if (_BaseInfoType == enBaseInfoType.Car)
            {
                DataTable dtData = ExecuteSQL.CallView(117, "", strFilter, "");
                this.grdCar.DataSource = dtData.DefaultView;
            }
            else if (_BaseInfoType == enBaseInfoType.Customer)
            {
                DataTable dtData = ExecuteSQL.CallView(112, "", strFilter, "");
                this.grdCustomer.DataSource = dtData.DefaultView;
            }
            else if (_BaseInfoType == enBaseInfoType.Item)
            {
                DataTable dtData = ExecuteSQL.CallView(203, "", strFilter, "");
                this.grdItem.DataSource = dtData.DefaultView;
            }
        }
    }
    
}
