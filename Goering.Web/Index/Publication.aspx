<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Publication.aspx.cs" Inherits="Goering.Web.Index.Publication" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="pager" %>
<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>月刊详情-荣诚集团</title>
    <link href="../Style/css/evervan.css" rel="stylesheet" />
    <style type="text/css"">
        #AspNetPager
        {
            font-size:18px;
        }
        #AspNetPager a
        {
            font-size:18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div style="width:980px">
            <uc1:top runat="server" ID="top" />
            <uc1:topImg runat="server" ID="topImg" />

            <div style="height: 50px; border-bottom: solid 1px #9CB6EC;">
                <div style="height: 50px; line-height: 50px; font-size: 16px; font-weight: bold; background-color: #4571D9; color: white; float: left; border-radius: 5px 5px 0px 0px;">
                    <span style="letter-spacing: 10px; padding: 0px 60px;">月刊详情</span>
                </div>
            </div>
            <div style="height: 25px;">
                <img src="../Style/img/dot.gif" />
            </div>
            <div id="MonthlyDetail" style="margin: 0px 2px;" runat="server">
                <div style="font-size: 14px; text-align: center; font-weight: bold; margin: 20px 0px;"><h2>荣诚月刊第<asp:Label ID="lblNumber" runat="server" Text="Label"></asp:Label>期</h2></div>
            <div style="text-align: center; margin: 10px 0px 20px 0px;">上传日期：<asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label></div>
                <div style="height: 10px;"><img src="/Style/img/dot.gif" /></div>
                <div>
                    <asp:Image ID="Image1" Width="978px" runat="server"></asp:Image>
                    
                      </div>
            </div>
            <div class="DynamicListPage"  style="padding:5px;">
                <pager:AspNetPager ID="AspNetPager" runat="server" Width="100%"
                    ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="跳转: "
                    HorizontalAlign="right" PageSize="1" OnPageChanged="AspNetPager_PageChanged"
                    EnableTheming="true" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                    PrevPageText="上一页" ButtonImageExtension=".png" ShowMoreButtons="False" ShowPageIndex="False">
                </pager:AspNetPager>
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
