using Goering.BLL.EVN;
using Goering.Model.Models.EVN;
using Goering.Utility.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Index
{
    public partial class DynamicList : System.Web.UI.Page
    {
        #region 自定义变量

        TNNEWSBLL bll = new TNNEWSBLL();

        #endregion

        #region 自定义事件

        #region 绑定数据
        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BindList()
        {
            try
            {
                string title = txtTitle.Text.Trim();
                if (title == "标题")
                {
                    title = "";
                }

                Expression<Func<TNNEWSInfo, bool>> wheres = null;
                if (string.IsNullOrEmpty(title) == false)
                {
                    wheres = c => c.CN_TITLE.Contains(title);
                }

                int count = 0;
                List<TNNEWSInfo> lst = bll.GetListByPage(AspNetPager.CurrentPageIndex, AspNetPager.PageSize, wheres, "CN_CREATE_DATE DESC", out count).ToList();
                AspNetPager.RecordCount = count;

                if (string.IsNullOrEmpty(title) == false)
                {
                    foreach (TNNEWSInfo info in lst)
                    {
                        info.CN_TITLE = info.CN_TITLE.Replace(title, "<span style='color:red;'>" + title + "</span>");
                    }
                }

                rep.DataSource = lst;
                rep.DataBind();
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog("绑定动态列表出错(Index/DynamicList):" + ex);
            }
        }
        #endregion

        #endregion

        #region 系统事件

        protected void Page_Load(object sender, EventArgs e)
        {
            //top.BigClass = "Index";

            left.BigClass = "Index";
            left.SmallClass = "DynamicList";


            if (IsPostBack == false)
            {
                BindList();
            }
        }

        #endregion

        #region 按钮

        #region 换页
        /// <summary>
        /// 换页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager_PageChanged(object sender, EventArgs e)
        {
            BindList();
        }
        #endregion

        #region 查询
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindList();
        }
        #endregion

        #endregion
    }
}