using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Goering.BLL.EVN;

namespace Goering.Web
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //TSUSERBLL bll = new TSUSERBLL();
                //var lst = bll.GetAllList().ToList();
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
}