using Goering.BLL.EVN;
using Goering.Extensions;
using Goering.Model.Models.EVN;
using Goering.Web.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Index
{
    public partial class Publication : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            top.MenuType = 6;
            if (!IsPostBack)
            {
                this.BindList();
            }
        }

        //private List<MonthlyPicture> GetMonlyPicture(int pageIndex, int pageSize, int monlyNumber, DateTime createDate,string skipFirstPicturUrl, string dir, out int count)
        //{
        //    List<MonthlyPicture> lstMonthlyPicture = new List<MonthlyPicture>();
        //    DirectoryInfo theFolder = new DirectoryInfo(dir);
        //    var files = theFolder.GetFiles().OrderBy(t => t.Name).ToList();
        //    foreach (var file in files)
        //    {
        //        if (skipFirstPicturUrl == "/upload/image_monthly/" + monlyNumber.ToString() + @"/" + file.Name)
        //            continue;
        //        MonthlyPicture mp = new MonthlyPicture();
        //        mp.MonthlyNumber = monlyNumber;
        //        mp.CreateDate = createDate;
        //        mp.PictureURL = "/upload/image_monthly/" + monlyNumber.ToString() + @"/输出页码" + pageIndex + ".JPG";
        //        lstMonthlyPicture.Add(mp);
        //    }
        //    count = lstMonthlyPicture.Count;
        //    return lstMonthlyPicture.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        //}


        private TNMONTHLYBLL bllTNMONTHLY = new TNMONTHLYBLL();
        protected void BindList()
        {
            int count = 0;
            string monthlyId = Request.QueryString["id"];
            if (monthlyId == null)
                return;
            var monthly = bllTNMONTHLY.GetModelByID(monthlyId);
            string dir = Server.MapPath("/upload/image_monthly/") + monthly.CN_NUMBER.ToString() + @"/";
            lblNumber.Text = monthly.CN_NUMBER.ToString();
            lblDate.Text = monthly.CN_CREATE_DATE.ToString("yyyy-MM-dd");
            string url = string.Format("GetImage.aspx?monthlyNumber={0}&pageIndex={1}", monthly.CN_NUMBER, AspNetPager.CurrentPageIndex);
            
            Image1.ImageUrl = url;
            DirectoryInfo theFolder = new DirectoryInfo(dir);
            var files = theFolder.GetFiles().Where(t => !monthly.CN_FIRST_PIC_URL.Contains(t.Name) && t.Extension.ToLower() == ".jpg").OrderBy(t => t.Name).ToList();
            count = files.Count;
            AspNetPager.RecordCount = count;
        }

        protected void AspNetPager_PageChanged(object src, EventArgs e)
        {
            this.BindList();
        }
    }

    internal class MonthlyPicture
    {
        public int MonthlyNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public string PictureURL { get; set; }
    }
}