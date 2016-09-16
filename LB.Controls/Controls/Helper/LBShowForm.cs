using LB.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace LB.Page.Helper
{
    public class LBShowForm
    {
        public static event EventHandler LBUIPageBaseAdded;
        /// <summary>
        /// 弹出页面
        /// </summary>
        /// <param name="page"></param>
        public static void ShowDialog(LBUIPageBase page)
        {
            LBForm form = new Controls.LBForm(page);
            form.ShowDialog();
        }

        /// <summary>
        /// 不弹出界面，在主界面显示
        /// </summary>
        /// <param name="page"></param>
        public static void ShowMainPage(LBUIPageBase page)
        {
            LBUIPageBaseAdded?.Invoke(page, null);
        }
    }
}
