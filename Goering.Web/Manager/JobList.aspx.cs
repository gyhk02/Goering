using Goering.Web.Common;
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

namespace Goering.Web.Manager
{
    public partial class JobList : BaseWebPage
    {
        protected override void PageInit()
        {
            base.PageInit();
            if (!IsPostBack)
            {
                this.BindList();
            }
        }

        TNJOBBLL bll = new TNJOBBLL();

        private void BindList()
        {
            try
            {
                var where = ExpressionExtension.CreateExpression<TNJOBInfo>();

                if (!string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    where = where.And(c => c.CN_NAME.Contains(txtName.Text.Trim()));
                }
                int count=0;
                var lst = bll.GetListByPage(AspNetPager.CurrentPageIndex, AspNetPager.PageSize, "CN_CREATE_DATE DESC", out count).ToList();
                AspNetPager.RecordCount = count;
                rep.DataSource = lst;
                rep.DataBind();
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog("绑定职位列表出错:" + ex);
                MessageBox.Show(this, "绑定职位列表出错：" + ex.Message);
            }
        }

        protected void AspNetPager_PageChanged(object src, EventArgs e)
        {
            this.BindList();
        }

        public bool GetCheck(bool? value)
        {
            return value.Value;
        }

        protected void rep_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string aa = e.CommandName;
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "Edit")
            {
                Response.Redirect(string.Format("/Manager/JobEdit.aspx?ID={0}", id));
            }
            if (e.CommandName == "Delete")
            {
                new TNAPPLYFORBLL().Delete(c => c.CR_JOB_ID == id);
                bll.Delete(id);
                this.BindList();
            }
        }
    }
}