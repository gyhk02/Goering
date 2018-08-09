<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BigFamily.aspx.cs" Inherits="Goering.Web.Job.BigFamily" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>荣诚大家庭-荣诚集团</title>
    <meta name="Keywords" content="荣诚大家庭，医，食，住，行，育，乐" />
    <meta name="Description" content="荣诚大家庭" />
    <link href="../Style/css/evervan.css" rel="stylesheet" />
    <script src="../Style/js/jquery.min.js"></script>
    <style type="text/css">
        .Img {
            width: 205px;
            vertical-align: top;
            text-align: right;
            padding-bottom: 10px;
        }

        .SalaryWelfareTitle {
            font-size: 15px;
            font-weight: bold;
            margin: 0px 0px 10px 0px;
        }
   
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <uc1:top runat="server" ID="top" />
            <uc1:topImg runat="server" ID="topImg" />
            <table style="width: 980px">
                <tr>
                    <td style="width: 263px; vertical-align: top;">
                        <uc1:left runat="server" ID="left" />
                    </td>
                    <td class="middleWidth"></td>
                    <td style="vertical-align: top;">
                        <div style="height: 50px; border-bottom: solid 1px #9CB6EC;">
                            <div style="height: 50px; line-height: 50px; font-size: 16px; font-weight: bold; background-color: #4571D9; color: white; float: left; border-radius: 5px 5px 0px 0px;">
                                <span style="letter-spacing: 10px; padding: 0px 60px;">荣诚大家庭</span>
                            </div>
                        </div>

                        <div style="margin-top: 10px;">
                            <div style="width: 66px; float: left;">
                                <img src="../Style/img/job/shi_01.png" />
                            </div>
                            <div style="float: left;width:300px; font-size: 15px; margin-left: 20px;text-align:left; margin-top: 48px; color: #808080;font-size:16px">
                                自选餐贴近员工生活
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img  src="../Style/img/dot.gif" />
                        </div>
                        <div style="margin-top: 10px;">
                            <div style="float: left;">
                                <img style="width:350px" src="../Style/img/job/shi_02.png" />
                            </div>
                            <div style="float: right;">
                                <img style="width:350px" src="../Style/img/job/shi_03.png" />
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img src="../Style/img/dot.gif" />
                        </div>


                        <div style="margin-top: 10px;">
                            <div style="width: 66px; float: left;">
                                <img  src="../Style/img/job/yi_01.png" />
                            </div>
                            <div style="float: left; font-size: 15px; width:400px; margin-left: 20px;text-align:left; margin-top: 48px; color: #808080;font-size:16px">
                                完善医疗设备，第一时间医疗保护员工健康
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img  src="../Style/img/dot.gif" />
                        </div>
                        <div style="margin-top: 10px;">
                            <div style="float: left;">
                                <img style="width:350px" src="../Style/img/job/yi_02.png" />
                            </div>
                            <div style="float: right;">
                                <img style="width:350px" src="../Style/img/job/yi_03.png" />
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img src="../Style/img/dot.gif" />
                        </div>


                        <div style="margin-top: 10px;">
                            <div style="width: 66px; float: left;">
                                <img src="../Style/img/job/zhu_01.png" />
                            </div>
                            <div style="float: left; font-size: 15px; margin-left: 20px;width:400px;text-align:left;  margin-top: 48px; color: #808080;font-size:16px">
                                齐全的软硬体宿舍环境，让员工有个安全舒适的后盾
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <div style="margin-top: 10px;">
                            <div style="float: left;">
                                <img style="width:350px" src="../Style/img/job/zhu_02.png" />
                            </div>
                            <div style="float: right;">
                                <img style="width:350px" src="../Style/img/job/zhu_03.png" />
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img src="../Style/img/dot.gif" />
                        </div>


                        <div style="margin-top: 10px;">
                            <div style="width: 66px; float: left;">
                                <img src="../Style/img/job/xing_01.png" />
                            </div>
                            <div style="float: left; font-size: 15px; margin-left: 20px;width:400px;text-align:left;  margin-top: 48px; color: #808080;font-size:16px">
                                宽敞明亮的办公室，让员工享有完整齐全的软硬设备
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <div style="margin-top: 10px;">
                            <div style="float: left;">
                                <img style="width:350px" src="../Style/img/job/xing_02.png" />
                            </div>
                            <div style="float: right;">
                                <img style="width:350px" src="../Style/img/job/xing_03.png" />
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        

                        <div style="margin-top: 10px;">
                            <div style="width: 66px; float: left;">
                                <img src="../Style/img/job/yu_01.png" />
                            </div>
                            <div style="float: left; font-size: 15px; margin-left: 20px;width:400px;text-align:left;  margin-top: 48px; color: #808080;font-size:16px">
                                不定期举办技能培训比赛，认可培训员工技术能力
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <div style="margin-top: 10px;">
                            <div style="float: left;">
                                <img style="width:350px" src="../Style/img/job/yu_02.png" />
                            </div>
                            <div style="float: right;">
                                <img style="width:350px" src="../Style/img/job/yu_03.png" />
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <div style="margin-top: 10px;">
                            <div style="float: left;">
                                <img style="width:350px" src="../Style/img/job/yu_04.png" />
                            </div>
                            <div style="float: right;">
                                <img style="width:350px" src="../Style/img/job/yu_05.png" />
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img style="width:350px" src="../Style/img/dot.gif" />
                        </div>
                        
                        
                        <div style="margin-top: 10px;">
                            <div style="width: 66px; float: left;">
                                <img  src="../Style/img/job/le_01.png" />
                            </div>
                            <div style="float: left; font-size: 15px; margin-left: 20px;width:400px;text-align:left;  margin-top: 48px; color: #808080;font-size:14px">
                                集团工会不定期举办活动，接近员工之间的互动默契
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <div style="margin-top: 10px;">
                            <div style="float: left;">
                                <img style="width:350px" src="../Style/img/job/le_02.png" />
                            </div>
                            <div style="float: right;">
                                <img style="width:350px" src="../Style/img/job/le_03.png" />
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <div style="margin-top: 10px;">
                            <div style="float: left;">
                                <img style="width:350px" src="../Style/img/job/le_04.png" />
                            </div>
                            <div style="float: right;">
                                <img style="width:350px" src="../Style/img/job/le_05.png" />
                            </div>
                        </div>
                        <div style="height: 1px; clear: both;">
                            <img src="../Style/img/dot.gif" />
                        </div>

                    </td>
                </tr>
            </table>
            <div style="height: 5px;">
                <img src="../Style/img/dot.gif" />
            </div>
            <uc1:end runat="server" ID="end" />
        </center>
    </form>
</body>
</html>
