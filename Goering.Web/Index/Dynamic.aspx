<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dynamic.aspx.cs" Inherits="Goering.Web.Index.Dynamic" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>公司动态详情-荣诚集团</title>
    <link href="../Style/css/evervan.css" rel="stylesheet" />
    <script type="text/javascript" src="../Style/ckplayer/ckplayer.js" charset="UTF-8"></script>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div style="width:980px">
            <uc1:top runat="server" ID="top" />
            <uc1:topImg runat="server" ID="topImg" />

            <div style="height: 50px; border-bottom: solid 1px #9CB6EC;">
                <div style="height: 50px; line-height: 50px; font-size: 16px; font-weight: bold; background-color: #4571D9; color: white; float: left; border-radius: 5px 5px 0px 0px;">
                    <span style="letter-spacing: 10px; padding: 0px 60px;">动态详情</span>
                </div>
            </div>
            <div style="font-size: 18px; text-align: center; font-weight: bold; margin: 20px 0px;">
                <h2> <asp:Label ID="labTitle" runat="server" Text="2017清新区庆“五一”职工运动会"></asp:Label></h2>
            </div>
            <div style="text-align: center; margin: 10px 0px 20px 0px;">
                <asp:Label ID="labTime" runat="server" Text="上传日期：2017年2月"></asp:Label>
            </div>
            <div id="divVideo" runat="server" style="background-color: #EAF1FB; text-align: center; padding: 20px;">
                <%--<img src="../Style/img/index/Dynamic_01.jpg" />--%>

                <div id="video"  runat="server" style="width: 750px; margin:0px auto; ">
                    
                </div>
            </div>
            <div id="divContent" runat="server" style="line-height: 25px;width:978px;text-align:left">
            </div>
            <div style="height: 5px;">
                <img src="../Style/img/dot.gif" />
            </div>

            <uc1:end runat="server" ID="end" />
        </div>
            </center>
    </form>
</body>
</html>
