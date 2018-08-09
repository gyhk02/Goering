using Goering.BLL.EVN;
using Goering.Extensions;
using Goering.Model.Models.EVN;
using Goering.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Manager
{
    public partial class SelectUser : BaseWebPage
    {
        protected override void PageInit()
        {
            base.PageInit();

            if (!IsPostBack)
            {
                this.BindList();
            }
        }

        private TSUSERBLL bllTSUSER = new TSUSERBLL();
        private TSMENUBLL bllTSMENU = new TSMENUBLL();
        private TRMENUUSERBLL bllTRMENUUSER = new TRMENUUSERBLL();
        protected void BindList()
        {
            string menuId = Request.QueryString["MenuID"];
            var where = ExpressionExtension.CreateExpression<TRMENUUSERInfo>();
            where = where.And(t => t.CR_MENU_ID == menuId);
            List<TRMENUUSERInfo> lstTRMENUUSERInfo = bllTRMENUUSER.GetListByWhere(t => t.CR_MENU_ID == menuId).ToList();
            List<TSUSERInfo> lst = bllTSUSER.GetAllList().ToList();
            foreach (var user in lst)
            {
                if (lstTRMENUUSERInfo.Exists(t => t.CR_USER_ID == user.CN_ID))
                {
                    user.Selected = true;
                }
                else
                {
                    user.Selected = false;
                }
            }
            rep.DataSource = lst;
            rep.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string menuId = Request.QueryString["MenuID"];
            //var where = ExpressionExtension.CreateExpression<TRMENUUSERInfo>();
            //where = where.And(t => t.CR_MENU_ID == menuId);
            //List<TRMENUUSERInfo> lstTRMENUUSERInfo = bllTRMENUUSER.GetListByWhere(t => t.CR_MENU_ID == menuId).ToList();
            List<TSMENUInfo> lstTSMENUInfo = bllTSMENU.GetAllList().ToList();
            List<TRMENUUSERInfo> lstTRMENUUSERInfoAll=bllTRMENUUSER.GetAllList().ToList();
            

            foreach (RepeaterItem item in rep.Items)
            {
                CheckBox cb = (CheckBox)item.FindControl("CheckBox1");
                HiddenField hf = (HiddenField)item.FindControl("HiddenField1");
                string userId = hf.Value;
                if(cb.Checked)
                {
                    if (!lstTRMENUUSERInfoAll.Exists(t =>t.CR_MENU_ID==menuId && t.CR_USER_ID == userId))
                    {
                        //加上父菜单
                        string parentMenuId = lstTSMENUInfo.Find(t => t.CN_ID == menuId).parent.CN_ID;
                        if(!lstTRMENUUSERInfoAll.Exists(t=>t.CR_MENU_ID==parentMenuId && t.CR_USER_ID==userId))
                        {
                            TRMENUUSERInfo menuUserParent = new TRMENUUSERInfo();
                            menuUserParent.CN_ID = Guid.NewGuid().ToString();
                            menuUserParent.CR_MENU_ID = parentMenuId;
                            menuUserParent.CR_USER_ID = userId;
                            bllTRMENUUSER.Add(menuUserParent);
                        }
                        TRMENUUSERInfo menuUser = new TRMENUUSERInfo();
                        menuUser.CN_ID = Guid.NewGuid().ToString();
                        menuUser.CR_MENU_ID = menuId;
                        menuUser.CR_USER_ID = userId;
                        bllTRMENUUSER.Add(menuUser);
                    }
                }
                else
                {
                    if (lstTRMENUUSERInfoAll.Exists(t => t.CR_MENU_ID == menuId && t.CR_USER_ID == userId))
                    {
                        TRMENUUSERInfo menuUser = lstTRMENUUSERInfoAll.Find(t => t.CR_MENU_ID == menuId && t.CR_USER_ID == userId);
                        bllTRMENUUSER.Delete(menuUser.CN_ID);
                    }
                    //如果全部子菜单都已删除，则将父菜单也删除
                    string parentMenuId = lstTSMENUInfo.Find(t => t.CN_ID == menuId).parent.CN_ID;
                    if (!bllTRMENUUSER.IsExists(t => t.TSMENU.CR_PARENT_ID == parentMenuId && t.CR_USER_ID == userId) && lstTRMENUUSERInfoAll.Exists(t=>t.CR_MENU_ID==parentMenuId && t.CR_USER_ID==userId))
                    {
                        TRMENUUSERInfo menuUserParent = lstTRMENUUSERInfoAll.Find(t => t.CR_MENU_ID == parentMenuId && t.CR_USER_ID == userId);
                        bllTRMENUUSER.Delete(menuUserParent.CN_ID);
                    }
                }
            }
            Response.Redirect("/Manager/Authorization.aspx", true);
        }
    }
}