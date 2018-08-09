using Goering.BLL.EVN;
using Goering.Common;
using Goering.Extensions;
using Goering.Model.Models.EVN;
using Goering.Utility.Utils;
using Goering.Web.Common;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Manager
{
    public partial class MonthlyMmagazine : BaseWebPage
    {
        protected override void PageInit()
        {
            base.PageInit();
            if (!IsPostBack)
            {
                this.BindList();
            }
        }

        private TNMONTHLYBLL bllTNMONTHLY = new TNMONTHLYBLL();
        protected void BindList()
        {
            int count = 0;
            var where = ExpressionExtension.CreateExpression<TNMONTHLYInfo>();
            if(txtMonthlyName.Text!="")
            {
                int number = Convert.ToInt32(txtMonthlyName.Text);
                where = where.And(t => t.CN_NUMBER == number);
            }
            List<TNMONTHLYInfo> lst = bllTNMONTHLY.GetListByPage(AspNetPager.CurrentPageIndex, AspNetPager.PageSize, where, "CN_CREATE_DATE DESC", out count).ToList();
            rep.DataSource = lst;
            rep.DataBind();
            AspNetPager.RecordCount = count;
        }

        private bool IsDataValid()
        {
            int number = Convert.ToInt32(txtNumber.Text);
            if (bllTNMONTHLY.IsExists(t => t.CN_NUMBER ==number ))
            {
                MessageBox.Show(this, "月刊期数已存在");
                return false;
            }
            return true;
        }

        /// <summary>
        /// 循环将图片放到各期目录
        /// </summary>
        /// <param name="dir"></param>
        private void CopyAllImageToMonthlyFolder(string dir)
        {
            DirectoryInfo theFolder = new DirectoryInfo(dir);
            DirectoryInfo[] dirInfo = theFolder.GetDirectories();
            foreach (DirectoryInfo NextFolder in dirInfo)
            {
                FileInfo[] fileInfo = NextFolder.GetFiles();
                foreach (FileInfo NextFile in fileInfo)
                {
                    File.Copy(NextFile.FullName, dir + NextFile.Name,true);
                }
            }
            foreach(DirectoryInfo NextFolder in dirInfo)
            {
                Directory.Delete(NextFolder.FullName, true);
            }
        }

        /// <summary>
        /// 获取第一张图片
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        private string GetFirstFileName(string dir)
        {
            DirectoryInfo theFolder = new DirectoryInfo(dir);
            var files = theFolder.GetFiles().Where(t => t.Name.ToUpper() == "输出页码1.JPG").OrderBy(t => t.Name).ToList();
            if (files.Count > 0)
            {
                return files[0].FullName;
            }
            return "";
        }

        /// <summary>
        /// 获取缩略图
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private string GetThumbnailName(string fileName)
        {
            FileInfo file = new FileInfo(fileName);
            return DateTime.Now.Ticks.ToString() + file.Extension;
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
                var monthly=bllTNMONTHLY.GetModelByID(id);
                bllTNMONTHLY.Delete(id);
                string dir=Server.MapPath("/upload/image_monthly/") + monthly.CN_NUMBER.ToString() + "/";
                if (Directory.Exists(dir))
                {
                    Directory.Delete(dir, true);
                }
                this.BindList();
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValid())
                    return;
                string loginId = Session["LoginID"].ToString();
                string fileExtension = Path.GetExtension(btnSelectFile.FileName).ToLower();
                string changeFileName = DateTime.Now.Ticks.ToString() + fileExtension;
                string filePath = Server.MapPath("/upload/image_monthly/") + changeFileName;
                string numPath = Server.MapPath("/upload/image_monthly/") + txtNumber.Text + @"\";
                if (!Directory.Exists(Server.MapPath("/upload/image_monthly/")))
                {
                    Directory.CreateDirectory(Server.MapPath("/upload/image_monthly/"));
                }
                if (!Directory.Exists(numPath))
                {
                    Directory.CreateDirectory(numPath);
                }
                btnSelectFile.SaveAs(filePath);
                FastZip fastZip = new FastZip();
                fastZip.ExtractZip(filePath, numPath);
                CopyAllImageToMonthlyFolder(numPath);
                string fisrtFileName = GetFirstFileName(numPath); 
                string thumbnailName = GetThumbnailName(fisrtFileName);
                string thumbnailFullName = numPath + thumbnailName;
                string thumbnailUrl = "/upload/image_monthly/" + txtNumber.Text + @"/" + thumbnailName;
                ImageHelper.GetPicThumbnail(fisrtFileName, thumbnailFullName, 200, 150, 100);
                //GetPicThumbnail(fisrtFileName, thumbnailFullName, 200, 150);
                File.Delete(filePath);
                TNMONTHLYInfo monthly = new TNMONTHLYInfo();
                monthly.CN_ID = Guid.NewGuid().ToString();
                monthly.CN_NUMBER = Convert.ToInt32(txtNumber.Text);
                monthly.CN_FIRST_PIC_URL = thumbnailUrl;
                monthly.CR_CREATE_USER_ID = loginId;
                monthly.CN_CREATE_DATE = DateTime.Now;
                bllTNMONTHLY.Add(monthly);
                BindList();
                MessageBox.Show(this, "上传成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "上传出错" + ex.Message);
            }
        }

        private void GetPicThumbnail(string sFile,string dFile,int dHeigh,int dWidth)
        {
            var imageFile = System.Drawing.Image.FromFile(sFile);
            System.Drawing.Bitmap image = new Bitmap(imageFile, new Size(dWidth, dHeigh));
            Graphics g = Graphics.FromImage(image);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            System.Drawing.Image imageFromMs = System.Drawing.Image.FromStream(ms);
            imageFromMs.Save(dFile);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindList();
        }
    }
}