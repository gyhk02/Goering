using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goering.Web.Common
{
    public class BaseWebPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["ReallyName"] = "管理员";
            //Session["LoginID"] = "1";

            if (Session["LoginID"] == null)
            {

                Response.Redirect("/Manager/Login.aspx", true);
            }
            this.PageInit();
        }

        protected virtual void PageInit()
        {

        }
    }
}