using Goering.BLL.EVN;
using Goering.Common;
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
    public partial class ImageSwitcherList : BaseWebPage
    {
        protected override void PageInit()
        {
            base.PageInit();


            if (!IsPostBack)
            {
                this.BindList();
            }

        }

        private TNFLASHSCREENBLL bllTNFLASHSCREEN = new TNFLASHSCREENBLL();
        protected void BindList()
        {
            int count = 0;
            List<TNFLASHSCREENInfo> lst = bllTNFLASHSCREEN.GetListByPage(AspNetPager.CurrentPageIndex, AspNetPager.PageSize, "CN_CREATE_DATE DESC", out count).ToList();
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
            if (e.CommandName == "View")
            {
                var flashScreen = bllTNFLASHSCREEN.GetModelByID(id);
                Response.Redirect(flashScreen.CN_URL);
            }
            if (e.CommandName == "Delete")
            {
                bllTNFLASHSCREEN.Delete(id);
                this.BindList();
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                bool fileOK = false;
                if (btnSelectFile.HasFile)
                {
                    string fileExtension = Path.GetExtension(btnSelectFile.FileName).ToLower();
                    string[] allowedExtensions = { ".jpeg", ".jpg",".png",".bmp",".gif" };
                    for (int i = 0; i < allowedExtensions.Length; i++)
                    {
                        if (fileExtension == allowedExtensions[i])
                        {
                            fileOK = true;
                            break;
                        }
                    }
                    if (fileOK)
                    {
                        string loginId = Session["LoginID"].ToString();
                        string changeFileName=DateTime.Now.Ticks.ToString() + fileExtension;
                        string filePath = Server.MapPath("/upload/image_switch/") + changeFileName;
                        string fileUrl = "/upload/image_switch/" + changeFileName;

                        if (!Directory.Exists(Server.MapPath("/upload/image_switch/")))
                        {
                            Directory.CreateDirectory(Server.MapPath("/upload/image_switch/"));
                        }
                        btnSelectFile.SaveAs(filePath);
                        TNFLASHSCREENInfo flashScreen = new TNFLASHSCREENInfo();
                        flashScreen.CN_ID = Guid.NewGuid().ToString();
                        flashScreen.CN_NAME = btnSelectFile.FileName;
                        flashScreen.CN_URL = fileUrl;
                        flashScreen.CR_CREATE_USER_ID = loginId;
                        flashScreen.CN_CREATE_DATE = DateTime.Now;
                        bllTNFLASHSCREEN.Add(flashScreen);
                        BindList();
                        MessageBox.Show(this, "上传成功");
                    }
                    else
                    {
                        Response.Write("<script>alert('请选择图片文件');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('请选择文件');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write(string.Format("<script>alert('导入报错{0}');</script>", ex.Message));
            }
        }
    }
}