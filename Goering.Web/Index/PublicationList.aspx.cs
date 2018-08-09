using Goering.BLL.EVN;
using Goering.Model.Models.EVN;
using Goering.Utility.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Index
{
    public partial class PublicationList : System.Web.UI.Page
    {
        #region 自定义变量

        TNMONTHLYBLL bll = new TNMONTHLYBLL();        

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
                int count = 0;
                List<TNMONTHLYInfo> lst = bll.GetListByPage(AspNetPager.CurrentPageIndex, AspNetPager.PageSize, "CN_NUMBER DESC", out count).ToList();
                AspNetPager.RecordCount = count;
                rep.DataSource = lst;
                rep.DataBind();
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog("绑定月刊列表出错(Index/DynamicList):" + ex);
            }
        }
        #endregion

        #endregion

        #region 系统事件

        protected void Page_Load(object sender, EventArgs e)
        {
            top.MenuType = 6;
            left.BigClass = "Index";
            left.SmallClass = "PublicationList";
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

        #endregion

    }
}