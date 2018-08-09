using Goering.BLL.EVN;
using Goering.Common;
using Goering.Extensions;
using Goering.Model.Models.EVN;
using Goering.Utility.Log;
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
    public partial class NewsVideo : BaseWebPage
    {
        protected override void PageInit()
        {
            base.PageInit();
            if (!IsPostBack)
            {
                this.BindList();
            }
        }

        private TNNEWSVIDEOBLL bllTNNEWSVIDEO = new TNNEWSVIDEOBLL();
        private TNNEWSBLL bllTNNEWS = new TNNEWSBLL();
        protected void BindList()
        {
            int count = 0;
            string newsId = Request.QueryString["NewsID"];
            if (newsId == null)
                return;
            var news = bllTNNEWS.GetModelByID(newsId);
            lblVideoTitle.Text = news.CN_TITLE;
            var where = ExpressionExtension.CreateExpression<TNNEWSVIDEOInfo>();
            where = where.And(t => t.CR_NEWS_ID == newsId);
            List<TNNEWSVIDEOInfo> lst = bllTNNEWSVIDEO.GetListByPage(AspNetPager.CurrentPageIndex, AspNetPager.PageSize, where, "CN_CREATE_DATE DESC", out count).ToList();
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
            if (e.CommandName == "Delete")
            {
                try
                {
                    TNNEWSVIDEOInfo model = bllTNNEWSVIDEO.GetModelByID(id);
                    string path = Server.MapPath(model.CN_VIDEO_PATH);
                    File.Delete(path);
                    bllTNNEWSVIDEO.Delete(id);
                    this.BindList();
                }
                catch (Exception ex)
                {
                    LogHelper.WriteErrorLog("删除视频出错：" + ex);
                    MessageBox.Show(this,"删除视频出错");
                }
                
            }
        }



        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string newsId = Request.QueryString["NewsID"];
                if (newsId == null)
                {
                    MessageBox.Show(this, "没有对应的公司动态，无法上传视频");
                    return;
                }
                string fileExtension = Path.GetExtension(btnSelectFile.FileName).ToLower();
                string loginId = Session["LoginID"].ToString();
                string changeFileName = DateTime.Now.Ticks.ToString() + fileExtension;
                string filePath = Server.MapPath("/upload/video/") + changeFileName;
                string fileUrl = "/upload/video/" + changeFileName;
                if (!Directory.Exists(Server.MapPath("/upload/video/")))
                {
                    Directory.CreateDirectory(Server.MapPath("/upload/video/"));
                }
                btnSelectFile.SaveAs(filePath);
                TNNEWSVIDEOInfo newsVideo = new TNNEWSVIDEOInfo();
                newsVideo.CN_ID = Guid.NewGuid().ToString();
                newsVideo.CN_NAME = btnSelectFile.FileName;
                newsVideo.CR_NEWS_ID = newsId;
                newsVideo.CN_VIDEO_PATH = fileUrl;
                newsVideo.CR_CREATE_USER_ID = loginId;
                newsVideo.CN_CREATE_DATE = DateTime.Now;
                bllTNNEWSVIDEO.Add(newsVideo);
                BindList();
                MessageBox.Show(this, "上传成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "导入报错"+ex.Message);
            }
        }
    }
}