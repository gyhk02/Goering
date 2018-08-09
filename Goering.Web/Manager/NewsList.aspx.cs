using Goering.BLL.EVN;
using Goering.Extensions;
using Goering.Model.Models.EVN;
using Goering.Web.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Manager
{
    public partial class News : BaseWebPage
    {
        protected override void PageInit()
        {
            base.PageInit();
            if (!IsPostBack)
            {
                this.BindList();
            }
        }

        private TNNEWSBLL bllTNNEWS = new TNNEWSBLL();
        private TNNEWSVIDEOBLL bllTNNEWSVIDEO = new TNNEWSVIDEOBLL();
        protected void BindList()
        {
            int count = 0;
            var where = ExpressionExtension.CreateExpression<TNNEWSInfo>();
            if (txtMonthlyName.Text != "")
            {
                where = where.And(t => t.CN_TITLE.Contains(txtMonthlyName.Text));
            }
            List<TNNEWSInfo> lst = bllTNNEWS.GetListByPage(AspNetPager.CurrentPageIndex, AspNetPager.PageSize, where, "CN_CREATE_DATE DESC", out count).ToList();
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
            if (e.CommandName == "Edit")
            {
                Response.Redirect(string.Format("/Manager/NewsEdit.aspx?NewsID={0}", id));
            }
            if (e.CommandName == "Video")
            {
                Response.Redirect(string.Format("/Manager/NewsVideo.aspx?NewsID={0}", id));
            }
            if (e.CommandName == "Delete")
            {
                var newsVideos = bllTNNEWSVIDEO.GetListByWhere(t => t.CR_NEWS_ID == id).ToList();
                bllTNNEWSVIDEO.Delete(a => a.CR_NEWS_ID == id);
                bllTNNEWS.Delete(id);
                foreach(var newVideo in newsVideos)
                {
                    string fileName = Server.MapPath("/") + newVideo.CN_VIDEO_PATH;
                    if(File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }
                }
                this.BindList();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindList();
        }
    }
}