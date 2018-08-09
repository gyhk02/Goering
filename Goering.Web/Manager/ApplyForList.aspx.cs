using Goering.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Goering.BLL.EVN;
using Goering.Model.Models.EVN;
using Goering.Utility.Log;
using Goering.Extensions;

namespace Goering.Web.Manager
{
    public partial class ApplyForList : BaseWebPage
    {
        protected override void PageInit()
        {
            base.PageInit();
            this.BindList();
        }

        TNAPPLYFORBLL bllApplyFor = new TNAPPLYFORBLL();

        private void BindList()
        {
            try
            {
                var where = ExpressionExtension.CreateExpression<TNAPPLYFORInfo>();
                if (!string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    where = where.And(c => c.TNJOB.CN_NAME.Contains(txtName.Text.Trim()));

                }
                if (ddlState.SelectedValue.ToString()!="-1")
                {
                    if (ddlState.SelectedValue.ToString()=="1")
                    {
                        where = where.And(c => c.CN_IS_LOOK == true);
                    }
                    else
                    {
                        where = where.And(c => c.CN_IS_LOOK == false);
                    }
                }
                int count = 0;
                var lst = bllApplyFor.GetListByPage(AspNetPager.CurrentPageIndex, AspNetPager.PageSize, where, "CN_CREATE_DATE DESC,CR_JOB_ID DESC", out count).ToList();
                rep.DataSource = lst;
                rep.DataBind();
                AspNetPager.RecordCount = count;
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog("绑定数据失败：" + ex.Message);
            }
        }

        public string GetStateName(bool value)
        {
            return value==true?"已查看":"未查看";
        }

        protected void rep_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "Look")
            {
                TNAPPLYFORInfo model = bllApplyFor.GetModelByID(id);
                model.CN_IS_LOOK = !model.CN_IS_LOOK;
                bllApplyFor.Update(model);
                this.BindList();
            }
            if (e.CommandName == "Delete")
            {
                bllApplyFor.Delete(id);
                this.BindList();
            }
        }

        protected void AspNetPager_PageChanged(object src, EventArgs e)
        {
            this.BindList();
        }
    }
}