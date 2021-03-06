﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LB.WinFunction;

namespace LB.MainForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                using (LB.Login.frmLogin login = new Login.frmLogin())
                {
                    Application.Run(login);
                    if (LoginInfo.IsVerifySuccess)
                    {
                        if (LoginInfo.UserType == 0)//地磅文员
                        {
                            using (WeightForm mainForm = new WeightForm())
                            {
                                Application.Run(mainForm);
                                if (!mainForm.bolIsCancel)
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            using (MainForm mainForm = new MainForm())
                            {
                                Application.Run(mainForm);
                                if (!mainForm.bolIsCancel)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

    }
}
