<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Process.aspx.cs" Inherits="Goering.Web.Technology.Process" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>制鞋流程-荣诚集团</title>
    <link href="../Style/css/evervan.css" rel="stylesheet" />
    <style type="text/css">
        .CultureTitle {
            margin-top: 30px;
            margin-left: 2px;
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
                            <div style="height: 50px; line-height: 50px; font-size: 20px; font-weight: bold; background-color: #4571D9; color: white; float: left; border-radius: 5px 5px 0px 0px;">
                                <span style="letter-spacing: 10px; padding: 0px 60px;">制鞋流程</span>
                            </div>
                        </div>
                        <div style="background-color:#EAF1FB; margin:10px 0px; text-align:center; padding:30px 0px; ">
                            <div>
                                <object type="application/x-shockwave-flash" data="../Style/img/Technology/Process.swf" width="680" height="450" id="u7095_media">
                                    <param name="movie" value="../Style/img/Technology/Process.swf" />
                                    <param name="quality" value="high" />
                                    <param name="swfversion" value="6.0.65.0" />
                                    <param name="wmode" value="transparent" />
                                    <param name="expressinstall" value="Scripts/expressInstall.swf" />
                                    <object type="application/x-shockwave-flash" data="../Style/img/Technology/Process.swf" width="680" height="450">
                                        <param name="quality" value="high" />
                                        <param name="swfversion" value="6.0.65.0" />
                                        <param name="wmode" value="transparent" />
                                        <param name="expressinstall" value="Scripts/expressInstall.swf" />
                                        <div>
                                            <h4>Content on this page requires a newer version of Adobe Flash Player.</h4>
                                            <p><a href="http://www.adobe.com/go/getflashplayer">
                                                <img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="Get Adobe Flash player" width="112" height="33" /></a></p>
                                        </div>
                                    </object>
                                </object>

                            </div>
                        </div>
                    </td>
                </tr>
            </table>
            <uc1:end runat="server" ID="end" />
        </center>
    </form>
</body>
</html>
