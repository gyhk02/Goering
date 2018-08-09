using Goering.BLL.EVN;
using Goering.Model.Models.EVN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Goering.Utility.Log;
using Goering.Common;

namespace Goering.Web
{
    public partial class Default : System.Web.UI.Page
    {
        #region 自定义变量

        TNMONTHLYBLL bllMonthly = new TNMONTHLYBLL();

        #endregion

        

        #region 系统事件

        protected void Page_Load(object sender, EventArgs e)
        {
            top.MenuType = 1;
            if (!IsPostBack)
            {

                this.BindFlashScreen();
                this.BindNewsList();
            }
        }

        #endregion

        #region 公司动态

        private void BindNewsList()
        {
            try
            {
                TNNEWSBLL bllNews = new TNNEWSBLL();
                int count = 0;
                List<TNNEWSInfo> lst = bllNews.GetListByPage(1, 8, "CN_MODIFY_DATE DESC", out count).ToList();
                repNews.DataSource = lst;
                repNews.DataBind();
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog("绑定动态出错：" + ex);
                MessageBox.Show(this, ex.Message);
            }

        }
        #endregion

        #region 图片切换

        private void BindFlashScreen()
        {
            try
            {
                int count = 0;




                List<TNFLASHSCREENInfo> lst = new TNFLASHSCREENBLL().GetListByPage(1, 5, "CN_CREATE_DATE DESC", out count).ToList();


                if (lst.Count > 0)
                {
                    string str = string.Empty;
                    for (int i = 0; i < lst.Count; i++)
                    {
                        //选中第一张图片
                        if (i == 0)
                        {
                            str += "<a class=\"trigger imgSelected\" href=\"javascript:void(0)\">" + (i + 1) + "</a>";
                        }
                        else
                        {
                            str += "<a class=\"trigger\" href=\"javascript:void(0)\">" + (i + 1) + "</a>";
                        }
                    }
                    

                    repFalsh.DataSource = lst;
                    repFalsh.DataBind();
                    spanTab.InnerHtml = str;
                }
                else
                {
                    jsNav.Style["display"] = "none";
                }




            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog("绑定切换图片出错：" + ex);
                MessageBox.Show(this, ex.Message);
            }
        }
        #endregion




    }
}