using Goering.BLL.EVN;
using Goering.Model.Models.EVN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Goering.Utility.Log;
using Goering.Common;

namespace Goering.Web.Index
{
    public partial class Dynamic : System.Web.UI.Page
    {
        #region 自定义变量

        TNNEWSBLL bll = new TNNEWSBLL();
        //TNNEWSVIDEOBLL bllVideo = new TNNEWSVIDEOBLL();

        #endregion

        

        #region 系统事件

        protected void Page_Load(object sender, EventArgs e)
        {
            top.MenuType = 1;
            if (IsPostBack == false)
            {
                //divVideo.Visible = false;

                //top.BigClass = "Index";
                this.BindContent();
                
            }
        }

        private void BindContent()
        {
            try
            {
                string id = Request["id"];
                if (id != null)
                {
                    TNNEWSInfo info = bll.GetModelByID(id);
                    if (info != null)
                    {
                        labTitle.Text = info.CN_TITLE;
                        labTime.Text = "上传日期：" + DateTime.Parse(info.CN_CREATE_DATE.ToString()).ToString("yyyy-MM-dd");
                        divContent.InnerHtml = info.CN_CONTENT;

                        if (info.ListTNNEWSVIDEO!=null&&info.ListTNNEWSVIDEO.Count>0)
                        {
                            divVideo.Visible = true;
                            StringBuilder sb = new StringBuilder();
                            StringBuilder sb1 = new StringBuilder();
                            foreach(var item in info.ListTNNEWSVIDEO)
                            {
                                sb.Append("<div style='margin:10px' id='" + item.CN_ID + "'></div>");
                                sb1.Append("CKobject.embed('../Style/ckplayer/ckplayer.swf', '" + item.CN_ID + "', 'ckplayer_" + item.CN_ID + "', '750', '450', true, { f: '" + item.CN_VIDEO_PATH + "', c: 0, b: 1, i: '' }, ['" + item.CN_VIDEO_PATH + "']);");
                            }
                            StringBuilder result = new StringBuilder();
                            result.Append(sb.ToString());
                            result.Append("<script type='text/javascript'>");
                            result.Append(sb1.ToString());
                            result.Append("</script>");

                            video.InnerHtml = result.ToString();
                            
                        }
                        else
                        {
                            divVideo.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteErrorLog(ex);
                MessageBox.Show(this, ex.Message);
            }
        }

        #endregion

        


    }
}