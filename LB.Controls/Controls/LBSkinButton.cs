using CCWin.SkinControl;
using LB.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace LB.Controls
{
    public partial class LBSkinButton : SkinButton
    {
        private string _LBPermissionCode = "";
        public LBSkinButton()
        {
            InitializeComponent();
        }

        public LBSkinButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// 权限校验码
        /// </summary>
       [Description("权限校验码")]
        public string LBPermissionCode
        {
            get
            {
                return _LBPermissionCode;
            }
            set
            {
                _LBPermissionCode = value;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            try
            {
                LBPermission.VerifyUserPermission(LBPermissionCode);
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
