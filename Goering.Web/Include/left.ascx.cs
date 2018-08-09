using Goering.Model.Vo;
using Goering.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Include
{
    public partial class left : System.Web.UI.UserControl
    {
        DirectoryList classDir = new DirectoryList();

        private string _BigClass = "";
        public string BigClass
        {
            get { return _BigClass; }
            set { _BigClass = value; }
        }

        private string _SmallClass = "";
        public string SmallClass
        {
            get { return _SmallClass; }
            set { _SmallClass = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            List<LeftDirectoryVo> lstSmallClass = classDir.GetList(_BigClass);

            string htmlStr = "";
            string cssLink = "";
            string cssBgImg = "";

            List<string> lstAboutChilds = new List<string>();
            lstAboutChilds.Add("EVN");
            lstAboutChilds.Add("EVH");
            lstAboutChilds.Add("EVL");
            lstAboutChilds.Add("PRB");
            lstAboutChilds.Add("EVC");
            lstAboutChilds.Add("EVM");

            foreach (LeftDirectoryVo vo in lstSmallClass)
            {
                if (_SmallClass == vo.SmallClass)
                {
                    cssLink = "leftItemSelectedByA";
                    cssBgImg = "leftItemSelectedByBgImg";
                }
                else
                {
                    cssLink = "leftItemDefaultByLink";
                    cssBgImg = "";
                }

                if (lstAboutChilds.Contains(vo.SmallClass) == true)
                {
                    htmlStr = htmlStr + @"
        <div style='height: 1px;'>
            <img src='../Style/img/dot.gif' />
        </div>";
                    //htmlStr = htmlStr + "";
                }
                else
                {
                    htmlStr = htmlStr + @"
        <div style='height: 15px;'>
            <img src='../Style/img/dot.gif' />
        </div>";
                }

                htmlStr = htmlStr +
@"
        <table>
            <tr>
                <td style='width: 60px;'>&nbsp;</td>
                <td style='height: 25px; line-height: 25px;'><a class='" + cssLink + "' href='../" + vo.BigClass + "/" + vo.SmallClass + ".aspx'>" + classDir.GetChinese(vo.SmallClass)
                                                                                                                               + @"</a></td>
                <td style='width: 3px; height: 25px; line-height: 25px;'>
                    <img src='../Style/img/dot.gif' /></td>
                <td class='" + cssBgImg
                            + @"'>
                    <img src='../Style/img/dot.gif' width='16' />
                </td>
            </tr>
        </table>
";
            }

            divLeft.InnerHtml = htmlStr;

            if (_BigClass == "Index")
            {
                divLeftTitle.Style.Add("display", "none");
            }

            spanLeftTitle.InnerText = classDir.GetChinese(_BigClass);
        }
    }
}