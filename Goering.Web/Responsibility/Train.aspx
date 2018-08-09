<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Train.aspx.cs" Inherits="Goering.Web.Responsibility.Train" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>员工培育-荣诚集团</title>
    <meta name="Keywords" content="员工培训" />
    <meta name="Description" content="员工培训" />
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
                                <span style="letter-spacing: 10px; padding: 0px 60px;">员工培育</span>
                            </div>
                        </div>

                        <div style="height: 10px;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <div style="width:100%;font-size:20px;font-weight:bold;text-align:left;margin:20px 0 20px 0">集团培育体系</div>
                        <img src="../Style/img/Responsibility/train1.png" />

                        <div style="width:100%;font-size:20px;font-weight:bold;text-align:left;margin:20px 0 20px 0">e&ensp;学院学习平台介绍</div>
                        <img src="../Style/img/Responsibility/train2.png" />
                        <div style="width:100%;font-size:20px;font-weight:bold;text-align:left;margin:20px 0 20px 0">各类实地培训</div>
                        <img src="../Style/img/Responsibility/train3.png" />
                    </td>
                </tr>
            </table>
            <uc1:end runat="server" ID="end" />
        </center>
    </form>
</body>
</html>