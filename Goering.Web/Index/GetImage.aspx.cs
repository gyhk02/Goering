using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Goering.Web.Index
{
    public partial class GetImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string monthlyNumber = Request.QueryString["monthlyNumber"];
            string pageIndex= Request.QueryString["pageIndex"];
            GetImageStream(monthlyNumber, pageIndex);
        }

        private void GetImageStream(string monthlyNumber, string pageIndex)
        {
            string sFile = Server.MapPath("/upload/image_monthly/") + monthlyNumber + @"/输出页码" + pageIndex + ".JPG";
            var imageFile = Image.FromFile(sFile);
            System.Drawing.Bitmap image = new Bitmap(imageFile, new Size(1002, 1394));
            Graphics g = Graphics.FromImage(image);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            Response.Cache.SetNoStore();//这一句
            Response.ClearContent();
            Response.ContentType = "image/Jpeg";
            Response.BinaryWrite(ms.ToArray());
            g.Dispose();
            image.Dispose();
        }
    }
}