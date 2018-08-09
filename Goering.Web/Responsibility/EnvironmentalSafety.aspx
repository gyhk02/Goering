﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnvironmentalSafety.aspx.cs" Inherits="Goering.Web.Responsibility.EnvironmentalSafety" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>绿色生产-荣诚集团</title>
    <link href="../Style/css/evervan.css" rel="stylesheet" />
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
                    <td style="vertical-align: top;text-align:left">
                        <div style="height: 50px; border-bottom: solid 1px #9CB6EC;">
                            <div style="height: 50px; line-height: 50px; font-size: 16px; font-weight: bold; background-color: #4571D9; color: white; float: left; border-radius: 5px 5px 0px 0px;">
                                <span style="letter-spacing: 10px; padding: 0px 60px;">绿色生产</span>
                            </div>
                        </div>

                        <div style="height: 10px;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <div style="width:100%;font-size:16px;font-weight:bold;text-align:left">变废为宝、绿色生产、爱护地球、人人有责</div>
                      <div style="width:100%;margin: 10px 0 10px 5px;font-size:14px;font-weight:bold;margin-top:10px">节能减碳</div>
                        <img src="../Style/img/Responsibility/green1.png" />
                        <div style="width:100%;margin: 10px 0 10px 5px;font-size:14px;font-weight:bold;margin-top:10px">变废为宝</div>
                        <img src="../Style/img/Responsibility/green2.png" />
                    </td>
                </tr>
            </table>
            <uc1:end runat="server" ID="end" />
        </center>
    </form>
</body>
</html>
