using Goering.BLL.EVN;
using Goering.Model.Models.EVN;
using Goering.Utility.Secrecy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Goering.Extensions;
using Goering.Web.Common;
using Goering.Common;

namespace Goering.Web.Manager
{
    public partial class UserEdit : BaseWebPage
    {
        private TSUSERBLL bllTSUSER = new TSUSERBLL();
        protected override void PageInit()
        {
            base.PageInit();
            if (!IsPostBack)
            {
                this.GetUserInfo();
            }
        }

        private void GetUserInfo()
        {
            string userId = Request.QueryString["UserID"];
            if (userId != null)
            {
                this.Title = "编辑用户";
                txtLoginName.Attributes.Add("readonly", "true");
                var user = bllTSUSER.GetModelByID(userId);
                txtLoginName.Text = user.CN_LOGIN_NAME;
                txtPassword.Text = DEncrypt.Decrypt(user.CN_PASSWORD);
                txtEmployeeNo.Text = user.CN_EMPLOYEE_NO;
                txtReallyName.Text = user.CN_REALLY_NAME;
            }
            else
            {
                this.Title = "新增用户";
                txtLoginName.Attributes.Remove("readonly");
            }
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            if (Page.IsValid == false)
                return;
            try
            {
                string userId = Request.QueryString["UserID"];
                string loginId = Session["LoginID"].ToString();
                if (userId != null)
                {
                    var user = bllTSUSER.GetModelByID(userId);
                    user.CN_PASSWORD = DEncrypt.Encrypt(txtPassword.Text);
                    user.CN_EMPLOYEE_NO = txtEmployeeNo.Text;
                    user.CN_REALLY_NAME = txtReallyName.Text;
                    user.CN_MODIFY_DATE = DateTime.Now;
                    user.CR_MODIFY_USER_ID = loginId;
                    bllTSUSER.Update(user);
                }
                else
                {
                    TSUSERInfo user = new TSUSERInfo();
                    user.CN_ID = Guid.NewGuid().ToString();
                    user.CN_LOGIN_NAME = txtLoginName.Text;
                    user.CN_PASSWORD = DEncrypt.Encrypt(txtPassword.Text);
                    user.CN_EMPLOYEE_NO = txtEmployeeNo.Text;
                    user.CN_REALLY_NAME = txtReallyName.Text;
                    user.CN_CREATE_DATE = DateTime.Now;
                    user.CR_CREATE_USER_ID = loginId;
                    bllTSUSER.Add(user);
                }
                Response.Redirect("/Manager/UserList.aspx");
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "保存出错" + ex.Message);
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                string userId = Request.QueryString["UserID"];
                var where = ExpressionExtension.CreateExpression<TSUSERInfo>();
                where = where.And(c => c.CN_LOGIN_NAME.ToLower() == txtLoginName.Text.Trim().ToLower());
                if (userId != null)
                {
                    where = where.And(c => c.CN_ID != userId);
                }
                

                if (bllTSUSER.IsExists(where))
                {
                    args.IsValid = false;
                    CustomValidator1.ErrorMessage = "登录名重复";
                    return;
                }
            }
            catch(Exception)
            { }
        }

       
    }
}