using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace LB.Controls
{
    public partial class LBUIPageBase : UserControl
    {
        public event FormClosingEventHandler FormClosing;
        public event FormClosedEventHandler FormClosed;
        private TabPage _RefTabPage;
        /// <summary>
        /// ShowMainPage情况下，记录该页面所属的TabPage页签
        /// </summary>
        public TabPage RefTabPage
        {
            get
            {
                return _RefTabPage;
            }
            set
            {
                _RefTabPage = value;
            }
        }

        private bool _PageAutoSize = false;
        [Description("页签是否自定义大小")]
        public bool PageAutoSize
        {
            get
            {
                return _PageAutoSize;
            }
            set
            {
                _PageAutoSize = value;
            }
        }


        private string _LBPageTitle = "";
        [Description("页面标题")]//
        public string LBPageTitle
        {
            get
            {
                return _LBPageTitle;
            }
            set
            {
                _LBPageTitle = value;
            }
        }

        public LBUIPageBase()
        {
            InitializeComponent();
        }

        public LBUIPageBase(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            
        }

        /// <summary>
        /// 关闭页面
        /// </summary>
        public void Close()
        {
            if (FormClosing != null)
            {
                FormClosingEventArgs closingArgs = new FormClosingEventArgs(CloseReason.None, false);
                FormClosing(this, closingArgs);
                if (closingArgs.Cancel)
                {
                    return;
                }
            }
            if (FormClosed != null)
            {
                FormClosedEventArgs closedArgs = new FormClosedEventArgs(CloseReason.None);
                FormClosed(this, closedArgs);
            }

        }

        /// <summary>
        /// LBForm关闭时调用
        /// </summary>
        /// <param name="bolCancel"></param>
        public void StartClose(out bool bolCancel)
        {
            bolCancel = false;
            if (FormClosing != null)
            {
                FormClosingEventArgs closingArgs = new FormClosingEventArgs(CloseReason.None, false);
                FormClosing(this, closingArgs);
                bolCancel = closingArgs.Cancel;
            }
        }
    }
}
