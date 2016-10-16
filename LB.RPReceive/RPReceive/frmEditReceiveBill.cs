using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LB.Controls;

namespace LB.RPReceive
{
    public partial class frmEditReceiveBill : LBUIPageBase
    {
        private long mlReceiveBillHeaderID;
        public frmEditReceiveBill(long lReceiveBillHeaderID)
        {
            InitializeComponent();
            mlReceiveBillHeaderID = lReceiveBillHeaderID;
        }

        #region -- 根据单据状态显示或者隐藏相关按钮 --

        private void SetButtonStatus()
        {

        }

        #endregion
    }
}
