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
using Goering.Utility.Secrecy;
using Goering.Common;

namespace Goering.Web.Manager
{
    public partial class ModifyPwd : BaseWebPage
    {
       

        protected override void PageInit()
        {
            base.PageInit();
            if (!IsPostBack)
            {
                txtLoginName.Text = Session["LoginName"].ToString();
            }
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid == false)
                    return;
                string id = Session["LoginID"].ToString();
                string pwd=DEncrypt.Encrypt(txtPassword1.Text.Trim());
                new TSUSERBLL().Update(c => c.CN_ID == id, t => new TSUSERInfo { CN_PASSWORD = pwd });
                MessageBox.Show(this, "保存成功");
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog(ex);
                MessageBox.Show(this, "修改密码出错:" + ex.Message);
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                var where = ExpressionExtension.CreateExpression<TSUSERInfo>();
                string id=Session["LoginID"].ToString();
                TSUSERInfo model = new TSUSERBLL().GetModelByID(id);

                if (model.CN_PASSWORD!=DEncrypt.Encrypt(txtOldPwd.Text.Trim()))
                {
                    args.IsValid = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog(ex);
                MessageBox.Show(this,"验证出错:" + ex.Message);
            }
        }
    }
}