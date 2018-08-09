﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Goering.Web.Responsibility
{
    public partial class Activity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            top.MenuType = 4;
            left.BigClass = "Responsibility";
            left.SmallClass = "Activity";
        }
    }
}