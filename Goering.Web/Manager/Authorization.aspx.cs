using Goering.BLL.EVN;
using Goering.Extensions;
using Goering.Model.Models.EVN;
using Goering.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Manager
{
    public partial class Authorization : BaseWebPage
    {
        protected override void PageInit()
        {
            base.PageInit();

            if (!IsPostBack)
            {
                this.BindList();
            }
        }

        private TSMENUBLL bllTSMENU = new TSMENUBLL();
        private TRMENUUSERBLL bllTRMENUUSER = new TRMENUUSERBLL();
        protected void BindList()
        {
            int count = 0;
            var where = ExpressionExtension.CreateExpression<TSMENUInfo>();
            where = where.And(t => t.CR_PARENT_ID != "0");
            List<TSMENUInfo> lst = bllTSMENU.GetListByPage(AspNetPager.CurrentPageIndex, AspNetPager.PageSize, where, "CN_SORT", out count).ToList();
            List<TRMENUUSERInfo> lstTRMENUUSERInfo = bllTRMENUUSER.GetAllList().ToList();
            foreach (var menu in lst)
            {
                if(lstTRMENUUSERInfo.Exists(t=>t.CR_MENU_ID==menu.CN_ID))
                {
                    var lstMenuUser = lstTRMENUUSERInfo.Where(t => t.CR_MENU_ID == menu.CN_ID).ToList().Select(a => a.TSUSER.CN_REALLY_NAME).ToList();
                    menu.UserListText = string.Join(",", lstMenuUser);
                }
            }
            rep.DataSource = lst;
            rep.DataBind();
            AspNetPager.RecordCount = count;
        }

        protected void AspNetPager_PageChanged(object src, EventArgs e)
        {
            this.BindList();
        }

        protected void rep_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string aa = e.CommandName;
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "SelectUser")
            {
                Response.Redirect(string.Format("/Manager/SelectUser.aspx?MenuID={0}", id));
            }
        }
    }
}