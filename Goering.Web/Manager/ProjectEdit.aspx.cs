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
    public partial class ProjectEdit : BaseWebPage
    {
        private TNPROJECTBLL bllTNPROJECT = new TNPROJECTBLL();
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
            string userId = Request.QueryString["ID"];
            if (userId != null)
            {
                this.Title = "编辑项目";
                txtProjectName.Attributes.Add("readonly", "true");
                var user = bllTNPROJECT.GetModelByID(userId);
                txtProjectName.Text = user.CN_NAME;
                txtURL.Text = user.CN_URL;
                txtSort.Text = user.CN_SORT.ToString();
                cbxIsEnable.Checked = user.CN_IS_ENABLE;
            }
            else
            {
                this.Title = "新增项目";
                txtProjectName.Attributes.Remove("readonly");
            }
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            if (Page.IsValid == false)
                return;
            try
            {
                string userId = Request.QueryString["ID"];
                string loginId = Session["LoginID"].ToString();
                if (userId != null)
                {
                    var user = bllTNPROJECT.GetModelByID(userId);
                    user.CN_URL = txtURL.Text;
                    user.CN_SORT = int.Parse(txtSort.Text);
                    user.CN_IS_ENABLE = cbxIsEnable.Checked;
                    user.CN_MODIFY_DATE = DateTime.Now;
                    user.CR_MODIFY_USER_ID = loginId;
                    bllTNPROJECT.Update(user);
                }
                else
                {
                    TNPROJECTInfo user = new TNPROJECTInfo();
                    user.CN_ID = Guid.NewGuid().ToString();
                    user.CN_NAME = txtProjectName.Text;
                    user.CN_URL = txtURL.Text;
                    user.CN_SORT = int.Parse(txtSort.Text);
                    user.CN_IS_ENABLE = cbxIsEnable.Checked;
                    user.CN_CREATE_DATE = DateTime.Now;
                    user.CR_CREATE_USER_ID = loginId;
                    bllTNPROJECT.Add(user);
                }
                Response.Redirect("/Manager/ProjectList.aspx");
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
                string userId = Request.QueryString["ID"];
                var where = ExpressionExtension.CreateExpression<TNPROJECTInfo>();
                where = where.And(c => c.CN_NAME.ToLower() == txtProjectName.Text.Trim().ToLower());
                if (userId != null)
                {
                    where = where.And(c => c.CN_ID != userId);
                }

                if (bllTNPROJECT.IsExists(where))
                {
                    args.IsValid = false;
                    CustomValidator1.ErrorMessage = "项目名重复";
                    return;
                }
            }
            catch(Exception)
            { }
        }

       
    }
}