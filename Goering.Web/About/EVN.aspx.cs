using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.About
{
    public partial class EVN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            top.MenuType = 2;
            left.BigClass = "About";
            left.SmallClass = "EVN";
        }
    }
}