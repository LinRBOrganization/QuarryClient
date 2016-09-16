using CCWin.SkinControl;
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
            this.EditMode = DataGridViewEditMode.EditOnEnter;
            this.AutoGenerateColumns = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ColumnFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.TitleBack = null;
            this.TitleBackColorBegin = System.Drawing.Color.White;
            this.TitleBackColorEnd = System.Drawing.SystemColors.ActiveBorder;
            this.EnableHeadersVisualStyles = false;
            this.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.HeadFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.LineNumberForeColor = System.Drawing.Color.MidnightBlue;
            this.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            System.Windows.Forms.DataGridViewCellStyle CellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            CellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.AlternatingRowsDefaultCellStyle = CellStyle1;

            System.Windows.Forms.DataGridViewCellStyle CellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            CellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            CellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            CellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            CellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            CellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            CellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            CellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnHeadersDefaultCellStyle = CellStyle2;

            System.Windows.Forms.DataGridViewCellStyle CellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            CellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            CellStyle3.BackColor = System.Drawing.Color.White;
            CellStyle3.Font = new System.Drawing.Font("宋体", 12F);
            CellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            CellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            CellStyle3.SelectionForeColor = System.Drawing.Color.White;
            CellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DefaultCellStyle = CellStyle3;

            System.Windows.Forms.DataGridViewCellStyle CellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            CellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            CellStyle4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            CellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            CellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            CellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.RowsDefaultCellStyle = CellStyle4;

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
