using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Technology
{
    public partial class Process : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            top.MenuType = 3;
            left.BigClass = "Technology";
            left.SmallClass = "Process";
        }
    }
}