using Goering.BLL.EVN;
using Goering.Common;
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
    public partial class NewsEdit : BaseWebPage
    {
        protected override void PageInit()
        {
            base.PageInit();
            if (!IsPostBack)
            {
                this.GetNewsInfo();
            }
        }

        private TNNEWSBLL bllTNNEWS = new TNNEWSBLL();
        private void GetNewsInfo()
        {
            string newsId = Request.QueryString["NewsID"];
            if (newsId != null)
            {
                this.Title = "编辑公司动态";
                var news = bllTNNEWS.GetModelByID(newsId);
                txtTitle.Text = news.CN_TITLE;
                myEditor.InnerHtml = news.CN_CONTENT;
            }
            else
            {
                this.Title = "新增公司动态";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string newsId = Request.QueryString["NewsID"];
                string loginId = Session["LoginID"].ToString();
                TNNEWSInfo news = new TNNEWSInfo();
                news.CN_MODIFY_DATE = DateTime.Now;
                news.CR_MODIFY_USER_ID = loginId;
                news.CN_CREATE_DATE = DateTime.Now;
                news.CR_CREATE_USER_ID = loginId;
                if (newsId != null)
                {
                    news = bllTNNEWS.GetModelByID(newsId);
                    news.CN_TITLE = txtTitle.Text;
                    news.CN_CONTENT = Server.HtmlDecode(myEditor.InnerHtml);
                    
                    bllTNNEWS.Update(news);
                }
                else
                {
                    
                    news.CN_ID = Guid.NewGuid().ToString();
                    news.CN_TITLE = txtTitle.Text;
                    news.CN_CONTENT = Server.HtmlDecode(myEditor.InnerHtml);
                    
                    bllTNNEWS.Add(news);
                }
                MessageBox.ShowAndRedirect(this, "保存成功", "NewsList.aspx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "保存出错" + ex.Message);
            }
        }
    }
}