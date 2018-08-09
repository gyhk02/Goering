using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Job
{
    public partial class SalaryWelfare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            top.MenuType = 5;
            left.BigClass = "Job";
            left.SmallClass = "SalaryWelfare";
        }
    }
}