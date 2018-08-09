using Goering.BLL.EVN;
using Goering.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Manager
{
    public partial class Main : BaseWebPage
    {
        
        private TRMENUUSERBLL bllTRMENUUSER = new TRMENUUSERBLL();
        

        protected override void PageInit()
        {
            base.PageInit();
            if (!IsPostBack)
            {
                this.BindUserMenu();
            }
        }

        private void BindUserMenu()
        {
            string userID = Session["LoginID"].ToString();
            StringBuilder innerHtml = new StringBuilder();
            var lstUserMenu = bllTRMENUUSER.GetListByWhere(t => t.CR_USER_ID == userID && t.TSMENU.CR_PARENT_ID == "0").ToList();
            var lstUserMenuAll = bllTRMENUUSER.GetListByWhere(t => t.CR_USER_ID == userID).ToList();
            foreach (var userMenu in lstUserMenu)
            {
                innerHtml.Append(string.Format("<a href=\"#\" class=\"list-group-item active\">{0}</a>", userMenu.TSMENU.CN_NAME));
                foreach (var child in userMenu.TSMENU.children)
                {
                    if (lstUserMenuAll.Exists(t => t.CR_MENU_ID == child.CN_ID))
                    {
                        innerHtml.Append(string.Format("<a href=\"javascript:void(0)\" onclick=\"AddPage('{0}')\" class=\"list-group-item\">{1}</a>", child.CN_LINK_URL, child.CN_NAME));
                    }
                }
            }
            this.menu.InnerHtml = innerHtml.ToString();
        }
    }
}