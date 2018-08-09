using Goering.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Goering.BLL.EVN;
using Goering.Model.Models.EVN;
using Goering.Utility.Log;
using Goering.Common;

namespace Goering.Web.Manager
{
    public partial class UserList : BaseWebPage
    {
        protected override void PageInit()
        {
            base.PageInit();


            if (!IsPostBack)
            {
                this.BindList();
            }
            
        }

        private TSUSERBLL bllTSUSER = new TSUSERBLL();
        protected void BindList()
        {
            try
            {
                int count = 0;
                List<TSUSERInfo> lst = bllTSUSER.GetListByPage(AspNetPager.CurrentPageIndex, AspNetPager.PageSize, out count).ToList();
                rep.DataSource = lst;
                rep.DataBind();
                AspNetPager.RecordCount = count;
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog("绑定列表出错：" + ex.ToString());
                MessageBox.Show(this, "绑定列表出错：" + ex.Message);
            }
            
        }

        protected void AspNetPager_PageChanged(object src, EventArgs e)
        {
            this.BindList();
        }

        protected void rep_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                string aa = e.CommandName;
                string id = e.CommandArgument.ToString();
                if (e.CommandName == "Edit")
                {
                    Response.Redirect(string.Format("/Manager/UserEdit.aspx?UserID={0}", id));
                }
                if (e.CommandName == "Delete")
                {
                    new TRMENUUSERBLL().Delete(c => c.CR_USER_ID == id);
                    bllTSUSER.Delete(id);
                    this.BindList();
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog("操作失败：" + ex.ToString());
                MessageBox.Show(this, "操作失败：" + ex.Message);
            }
            
        }
    }
}