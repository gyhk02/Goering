<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LaborSafety.aspx.cs" Inherits="Goering.Web.Responsibility.LaborSafety" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>职业安全-荣诚集团</title>
    <meta name="Keywords" content="职业安全" />
    <meta name="Description" content="职业安全" />
    <link href="../Style/css/evervan.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <uc1:top runat="server" ID="top" />
            <uc1:topImg runat="server" id="topImg" />
            <table style="width: 980px;">
                <tr>
                    <td style="width: 263px; vertical-align: top;">
                        <uc1:left runat="server" id="left" />
                    </td>
                    <td class="middleWidth"></td>
                    <td style="vertical-align: top;">
                        <div style="height: 50px; border-bottom: solid 1px #9CB6EC;">
                            <div style="height: 50px; line-height: 50px; font-size: 16px; font-weight: bold; background-color: #4571D9; color: white; float: left; border-radius: 5px 5px 0px 0px;">
                                <span style="letter-spacing: 10px; padding: 0px 60px;">职业安全</span>
                            </div>
                        </div>
                        <div style="height: 10px;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <img src="../Style/img/Responsibility/safe1.png" />
                        <div style="width:100%;margin: 10px 0 10px 5px;font-size:20px;font-weight:bold">六项主要工作</div>
                        <table>
                            <tr>
                                <td>
                                    <img src="../Style/img/Responsibility/safe2.png" />
                                </td>
                                <td>
                                    <img src="../Style/img/Responsibility/safe3.png" />
                                </td>
                                <td>
                                    <img src="../Style/img/Responsibility/safe4.png" />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:center;height:20px;vertical-align:middle">
                                    法规复查与更新
                                </td>
                                <td style="text-align:center;vertical-align:middle">
                                    日常&ensp;HSE&ensp;车间稽查
                                </td>
                                <td style="text-align:center;vertical-align:middle">
                                    HSE训练
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <img src="../Style/img/Responsibility/safe5.png" />
                                </td>
                                <td>
                                    <img src="../Style/img/Responsibility/safe6.png" />
                                </td>
                                <td>
                                    <img src="../Style/img/Responsibility/safe7.png" />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:center;height:20px;vertical-align:middle">
                                    电器安全稽查
                                </td>
                                <td style="text-align:center;vertical-align:middle">
                                    季度HSE审查会议
                                </td>
                                <td style="text-align:center;vertical-align:middle">
                                    工伤事故调查
                                </td>
                            </tr>
                        </table>
                        <div style="height: 1px; clear: both;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                    </td>
                </tr>
            </table>
            <uc1:end runat="server" ID="end" />
        </center>
    </form>
</body>
</html>
