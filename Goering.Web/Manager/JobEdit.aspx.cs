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
using Goering.Common;
namespace Goering.Web.Manager
{
    public partial class JobEdit : BaseWebPage
    {
        protected override void PageInit()
        {
            base.PageInit();
            
            if (!IsPostBack)
            {
                this.InitData();
                this.InitModel();
            }
        }

        TNWORKAREABLL bllWorkArea = new TNWORKAREABLL();
        TNEDUCATIONALREQUIREMENTSBLL bllRequirement = new TNEDUCATIONALREQUIREMENTSBLL();
        TNJOBBLL bllJob = new TNJOBBLL();

        private void InitData()
        {
            try
            {
                ddlWorkArea.DataTextField = "CN_NAME";
                ddlWorkArea.DataValueField = "CN_ID";
                ddlWorkArea.DataSource = bllWorkArea.GetAllList().ToList();
                ddlWorkArea.DataBind();

                ddlRequireMent.DataTextField = "CN_NAME";
                ddlRequireMent.DataValueField = "CN_ID";
                ddlRequireMent.DataSource = bllRequirement.GetAllList().ToList();
                ddlRequireMent.DataBind();

            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog("初始化数据出错：" + ex);
                MessageBox.Show(this, "初始化数据出错：" + ex.Message);
            }
        }

        private void InitModel()
        {
            string Id = Request["ID"];

            
            if (!string.IsNullOrEmpty(Id))
            {
                TNJOBInfo model =bllJob.GetModelByID(Id) ;
                if (model!=null)
                {
                    txtAGE.Text = model.CN_AGE;
                    txtCONTACT.Text = model.CN_CONTACT;
                    txtEXPIRY_DATE.Text = model.CN_EXPIRY_DATE.Value.ToString("yyyy-MM-dd");
                    txtMONTHLY_PAY.Text = model.CN_MONTHLY_PAY;
                    txtName.Text = model.CN_NAME;
                    txtRECRUITIMENT_NUMBER.Text = model.CN_RECRUITIMENT_NUMBER.ToString();
                    txtREQUIREMENT_DETAIL.Value = model.CN_REQUIREMENT_DETAIL;
                    txtWORK_EXPERIENCE.Text = model.CN_WORK_EXPERIENCE;
                    ddlRequireMent.SelectedValue = model.CN_EDUCATIONAL_REQUIREMENTS_ID;
                    ddlWorkArea.SelectedValue = model.CN_WORK_EXPERIENCE;
                    chkIS_RESUME.Checked = model.CN_IS_RESUME.Value;
                    txtCN_PUT_UP.Text = model.CN_PUT_UP;

                }
            }
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            try
            {
                string Id = Request["ID"];
                TNJOBInfo model = new TNJOBInfo();
                if (!string.IsNullOrEmpty(Id))
                {
                    model = bllJob.GetModelByID(Id);
                }

                model.CN_AGE = txtAGE.Text.Trim();
                model.CN_CONTACT = txtCONTACT.Text.Trim();
                
                model.CN_EDUCATIONAL_REQUIREMENTS_ID = ddlRequireMent.SelectedValue.ToString();
                model.CN_EXPIRY_DATE = DateTime.Parse(txtEXPIRY_DATE.Text.Trim());
                model.CN_IS_RESUME = chkIS_RESUME.Checked;
                model.CN_MONTHLY_PAY = txtMONTHLY_PAY.Text.Trim();
                model.CN_NAME = txtName.Text.Trim();
                model.CN_PUBLISHED_DATE = DateTime.Now;
                model.CN_RECRUITIMENT_NUMBER = int.Parse(txtRECRUITIMENT_NUMBER.Text.Trim());
                model.CN_REQUIREMENT_DETAIL = txtREQUIREMENT_DETAIL.Value.Trim();
                model.CN_WORK_EXPERIENCE = txtWORK_EXPERIENCE.Text.Trim();
                model.CR_WORK_AREA_ID = ddlWorkArea.SelectedValue.ToString();
                model.CN_MODIFY_DATE = DateTime.Now;
                model.CR_MODIFY_USER_ID = Session["LoginID"].ToString();
                model.CN_PUT_UP = txtCN_PUT_UP.Text.Trim();
                if (!string.IsNullOrEmpty(Id))
                {
                    bllJob.Update(model);
                }
                else
                {
                    model.CN_ID = Guid.NewGuid().ToString();
                    model.CR_CREATE_USER_ID = Session["LoginID"].ToString();
                    model.CN_CREATE_DATE = DateTime.Now;
                    bllJob.Add(model);
                }
                MessageBox.ShowAndRedirect(this, "保存成功", "JobList.aspx");
                
                
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog("保存出错：" + ex.ToString());
                MessageBox.Show(this,"保存出错：" + ex.Message);
            }
        }
    }
}