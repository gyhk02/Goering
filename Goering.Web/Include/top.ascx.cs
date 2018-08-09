using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Goering.Web.Include
{
    public partial class top1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindMenuList();
        }

        public int MenuType = 1;

        private void BindMenuList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<ul>");
            if (MenuType == 1)
            {
                sb.Append("<li id='m1' style='background-color:#4571D9;' ><a id='a1' style='color:white'  href='/Default.aspx'>首页</a></li>");
            }
            else
            {
                sb.Append("<li id='m1'  ><a id='a1'   href='/Default.aspx'>首页</a></li>");
            }


            if (MenuType == 2)
            {
                sb.Append("<li id='m2' style='background-color:#4571D9;'><a id='a2'style='color:white' href='/About/Introduction.aspx'>关于荣诚</a></li>");
            }
            else
            {
                sb.Append("<li id='m2'><a id='a2' href='/About/Introduction.aspx'>关于荣诚</a></li>");
            }

            if (MenuType == 4)
            {
                sb.Append("<li id='m4' style='background-color:#4571D9;'><a id='a4' style='color:white' href='/Responsibility/Activity.aspx'>企业社会责任</a></li>");
            }
            else
            {
                sb.Append("<li id='m4'><a id='a4' href='/Responsibility/LabourUnion.aspx'>企业社会责任</a></li>");
            }


            //if (MenuType == 3)
            //{
            //    sb.Append("<li id='m3' style='background-color:#4571D9;'><a id='a3' style='color:white' href='/Technology/TPUPowder.aspx'>核心技术</a></li>");
            //}
            //else
            //{
            //    sb.Append("<li id='m3'><a id='a3' href='/Technology/machine.aspx'>核心技术</a></li>");
            //}


            if (MenuType == 6)
            {
                sb.Append("<li id='m6' style='background-color:#4571D9;'><a id='a6' style='color:white' href='/Index/PublicationList.aspx'>荣诚月刊</a></li>");
            }
            else
            {
                sb.Append("<li id='m6'><a id='a6' href='/Index/PublicationList.aspx'>荣诚月刊</a></li>");
            }


            if (MenuType == 5)
            {
                sb.Append("<li id='m5' style='background-color:#4571D9;'><a id='a5' style='color:white' href='/Job/JobOpenings.aspx'>人才招聘</a></li>");
            }
            else
            {
                sb.Append("<li id='m5'><a id='a5' href='/Job/JobOpenings.aspx'>人才招聘</a></li>");
            }
            sb.Append("<li><a class='language' href='"+ ResolveUrl("~/EN/Default.aspx") +"'>English</a></li>");
            sb.Append("</ul>");

            

            menu.InnerHtml = sb.ToString();
        }
    }
}