using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Goering.BLL.EVN;
using Goering.Model.Models.EVN;
using Goering.Extensions;
using Goering.Utility.Log;
using Goering.Common;

namespace Goering.Web.Job
{
    public partial class JobOpenings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                top.MenuType = 5;
                left.BigClass = "Job";
                left.SmallClass = "JobOpenings";
                this.BindList();
            }

        }


        #region 绑定列表

        private void BindList()
        {
            try
            {
                var where = ExpressionExtension.CreateExpression<TNJOBInfo>();
                DateTime dt = DateTime.Now;
                where = where.And(c => c.CN_EXPIRY_DATE > dt && c.CN_PUBLISHED_DATE < dt);
                var lst = new TNJOBBLL().GetListByWhere(where, "CN_MODIFY_DATE DESC").ToList();
                rep.DataSource = lst;
                rep.DataBind();
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog("绑定列表出错：" + ex);
                MessageBox.Show(this, ex.Message);
            }
        }
        #endregion
    }
}