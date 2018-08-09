using Goering.BLL.EVN;
using Goering.Common;
using Goering.Utility.Secrecy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Manager
{
    public partial class Login : System.Web.UI.Page
    {
        private TSUSERBLL bllTSUSER = new TSUSERBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ViewState["GUID"] = System.Guid.NewGuid().ToString();
                this.lblGUID.Text = this.ViewState["GUID"].ToString();


            }
        }

        protected void btnLogin_Click(object sender, ImageClickEventArgs e)
        {
            #region 检查验证码
            if ((Session["CheckCode"] != null) && (Session["CheckCode"].ToString() != ""))
            {
                if (Session["CheckCode"].ToString().ToLower() != this.CheckCode.Value.ToLower())
                {
                    this.lblMsg.Text = "所填写的验证码与所给的不符 !";
                    Session["CheckCode"] = null;
                    return;
                }
                else
                {
                    Session["CheckCode"] = null;
                }
            }
            else
            {
                Response.Redirect("/Manager/Login.aspx");
            }
            #endregion

            string userName = PageValidate.InputText(txtUsername.Value.Trim(), 30);
            string password = PageValidate.InputText(txtPass.Value.Trim(), 30);
            string passwordDencrypt = DEncrypt.Encrypt(password);
            try
            {
                var model = bllTSUSER.GetModelByWhere(t => t.CN_LOGIN_NAME == userName && t.CN_PASSWORD == passwordDencrypt);
                if (model == null)
                {
                    this.lblMsg.Text = "登陆失败： " + userName;
                }
                else
                {
                    Session["UserInfo"] = model;
                    Session["ReallyName"] = model.CN_REALLY_NAME;
                    Session["LoginID"] = model.CN_ID;
                    Session["LoginName"] = model.CN_LOGIN_NAME;
                    Response.Redirect("/Manager/Main.aspx", true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
            finally
            {

            }
        }
    }
}