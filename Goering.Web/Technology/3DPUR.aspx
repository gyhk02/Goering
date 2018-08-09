<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3DPUR.aspx.cs" Inherits="Goering.Web.Technology._3DPUR" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>3DPUR-荣诚集团</title>
    <link href="../Style/css/evervan.css" rel="stylesheet" />
    <script type="text/javascript" src="/Style/ckplayer/ckplayer.js" charset="UTF-8"></script>
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
                                <span style="letter-spacing: 10px; padding: 0px 60px;">3DPUR</span>
                            </div>
                        </div>
                        <div style="background-color: #EAF1FB; margin: 10px 0px; text-align: center; padding: 30px 0px;">

                            <div style="width: 100%; text-align: center">
                                <div style='margin: 10px' id='v1'>
                                    <script type='text/javascript'>
                                        CKobject.embed('../Style/ckplayer/ckplayer.swf', 'v1', 'ckplayer_a1', '680', '450', true, { f: '/Style/img/Technology/3DPUR.mp4', c: 0, b: 1, i: '' }, ['/Style/img/Technology/3DPUR.mp4']);
                                    </script>
                                </div>
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
