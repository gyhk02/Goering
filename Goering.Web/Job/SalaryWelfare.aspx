<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalaryWelfare.aspx.cs" Inherits="Goering.Web.Job.SalaryWelfare" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>薪资福利-荣诚集团</title>
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
                                <span style="letter-spacing: 10px; padding: 0px 60px;">薪资福利</span>
                            </div>
                        </div>
                            <div style="width:100%;font-size:20px;font-weight:bold;text-align:left;margin:20px 0 20px 0">
                            实发工资 = 应发工资 - 应减费用
                                </div>
                        <img src="../Style/img/job/xin1.png" />
                        <img src="../Style/img/job/xin7.png" />
                        <div style="width:100%;font-size:20px;font-weight:bold;text-align:left;margin:20px 0 20px 0">
                            薪资计算标准说明：
                                </div>
                        <img src="../Style/img/job/xin2.png" />
                        <div style="line-height: 25px;font-size:16px;text-align:left;margin:20px 0 20px 0">
                            建立合理有效的激励奖金制度，有利于充分调动员工积极性，及激励员工的努力意愿，员工努力的各项结果都能获的相对应的报酬。
                            </div>
                        <img src="../Style/img/job/xin3.png" />
                        <img src="../Style/img/job/xin4.png" />
                        <img src="../Style/img/job/xin5.png" />
                        <img src="../Style/img/job/xin6.png" />

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
