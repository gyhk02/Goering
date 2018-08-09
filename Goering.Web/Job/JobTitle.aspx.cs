using Goering.BLL.EVN;
using Goering.Common;
using Goering.Model.Models.EVN;
using Goering.Web.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Job
{
    public partial class JobTitle : System.Web.UI.Page
    {
        private TNJOBBLL bllTNJOB = new TNJOBBLL();
        private TNAPPLYFORBLL bllTNAPPLYFOR = new TNAPPLYFORBLL();

        

        protected void Page_Load(object sender, EventArgs e)
        {

            top.MenuType = 5;
            left.BigClass = "Job";
            left.SmallClass = "JobOpenings";

            if (!IsPostBack)
            {
               
                this.BindList();
            }

        }

        private void BindList()
        {
            string jobId = Request.QueryString["JobID"];
            if (jobId != null)
            {
                var job = bllTNJOB.GetModelByID(jobId);
                lblJobName.Text = job.CN_NAME;
                if (job.CN_IS_RESUME == true)
                {
                    resume.Attributes.Remove("hidden");
                }
                else
                {
                    resume.Attributes.Add("hidden", "hidden");
                }
            }
        }

        protected void btnSumit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid == false)
                    return;

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

                string jobId = Request.QueryString["JobID"];
                if (jobId != null)
                {
                    var job = bllTNJOB.GetModelByID(jobId);
                    TNAPPLYFORInfo applyFor = new TNAPPLYFORInfo();
                    applyFor.CN_ID = Guid.NewGuid().ToString();
                    applyFor.CN_NAME = txtName.Text;
                    applyFor.CN_PHONE_NUMBER = txtPhoneNumber.Text;
                    applyFor.CN_IDENTITY_CARD = txtIdentityCard.Text;
                    applyFor.CN_REMARK = txtRemark.Text;
                    if (job.CN_IS_RESUME == true)
                    {
                        if (btnSelectFile.FileName == "")
                        {
                            MessageBox.Show(this, "该职位要求上传简历，请上传简历！");
                            return;
                        }
                        string fileExtension = Path.GetExtension(btnSelectFile.FileName).ToLower();
                        List<string> allowedExtensions = new List<string>() { ".doc", ".docx",".xls",".xlsx" };
                        if(!allowedExtensions.Exists(t=>t==fileExtension))
                        {
                            MessageBox.Show(this, "请上传Word或Excel简历，可从本页面下载简历模版！");
                            return;

                        }
                        string changeFileName = DateTime.Now.Ticks.ToString() + fileExtension;
                        string filePath = Server.MapPath("/upload/resume/") + changeFileName;
                        if (!Directory.Exists(Server.MapPath("/upload/resume/")))
                        {
                            Directory.CreateDirectory(Server.MapPath("/upload/resume/"));
                        }
                        btnSelectFile.SaveAs(filePath);
                        applyFor.CN_RESUME_PATH = "/upload/resume/" + changeFileName;
                    }
                    applyFor.CR_JOB_ID = jobId;
                    applyFor.CN_CREATE_DATE = DateTime.Now;
                    applyFor.CN_IS_LOOK = false;
                    bllTNAPPLYFOR.Add(applyFor);
                    MessageBox.ShowAndRedirect(this, "提交简历成功", "JobOpenings.aspx");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "提交简历出错" + ex.Message);
            }
        }
    }
}