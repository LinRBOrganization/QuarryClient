﻿using CCWin.SkinControl;
using LB.WinFunction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace LB.Controls
{
    public partial class LBDataGridView : SkinDataGridView
    {
        public event DataGridViewCellEventHandler LBCellButtonClick;

        public LBDataGridView()
        {
            InitializeComponent();
            LBInitializeComponent();
        }

        public LBDataGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            LBInitializeComponent();
        }

        private void LBInitializeComponent()
        {
            this.CellClick += LBDataGridView_CellClick;
        }

        private void LBDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if(this[e.ColumnIndex,e.RowIndex] is DataGridViewButtonCell)
                {
                    if (LBCellButtonClick != null)
                        LBCellButtonClick(sender, e);
                }
            }
        }

        public void LBLoadConst()
        {
            foreach(DataGridViewColumn dc in this.Columns)
            {
                if(dc is LBDataGridViewComboBoxColumn)
                {
                    LBDataGridViewComboBoxColumn lbComboBox = dc as LBDataGridViewComboBoxColumn;
                    if(lbComboBox.FieldName!=""&& lbComboBox.FieldName != null)
                    {
                        try
                        {
                            lbComboBox.DataSource = GetConstData(lbComboBox.FieldName);
                            lbComboBox.DisplayMember = "ConstText";
                            lbComboBox.ValueMember = "ConstValue";
                            lbComboBox.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }

        private static DataTable GetConstData(string strFieldName)
        {
            DataTable dtConst = ExecuteSQL.CallView(101, "ConstValue,ConstText", "FieldName='" + strFieldName + "'", "");
            return dtConst;
        }
    }
}
