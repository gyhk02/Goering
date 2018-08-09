using Goering.BLL.EVN;
using Goering.Common;
using Goering.Model.Models.EVN;
using Goering.Utility.Log;
using Goering.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;

namespace Goering.Web.Manager
{
    public partial class ProjectList : BaseWebPage
    {
        protected override void PageInit()
        {
            base.PageInit();


            if (!IsPostBack)
            {
                this.BindList();
            }

        }

        private TNPROJECTBLL bllTNPROJECT = new TNPROJECTBLL();
        protected void BindList()
        {
            try
            {
                int count = 0;
                List<TNPROJECTInfo> lst = bllTNPROJECT.GetListByPage(AspNetPager.CurrentPageIndex, AspNetPager.PageSize, out count).ToList();
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
                    Response.Redirect(string.Format("/Manager/ProjectEdit.aspx?ID={0}", id));
                }
                if (e.CommandName == "Delete")
                {
                    new TNPROJECTBLL().Delete(c => c.CN_ID == id);
                    bllTNPROJECT.Delete(id);
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