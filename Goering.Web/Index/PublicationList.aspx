<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PublicationList.aspx.cs" Inherits="Goering.Web.Index.PublicationList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="pager" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>月刊列表-荣诚集团</title>
    <meta name="Keywords" content="荣诚月刊" />
    <meta name="Description" content="荣诚月刊" />
    <link href="../Style/css/evervan.css" rel="stylesheet" />
    <style type="text/css">
        .monthlyPublication {
            margin: 0;
            float: left;
            width: 190px;
            padding:10px;
            text-align:center;
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        
            <uc1:top runat="server" ID="top" />
            <uc1:topImg runat="server" ID="topImg" />
            <table style="width: 980px;">
                <tr>
                    <td style="width: 263px; vertical-align: top;">
                        <uc1:left runat="server" ID="left" />
                    </td>
                    <td class="middleWidth"></td>
                    <td style="vertical-align: top;">
                        <div style="height: 50px; border-bottom: solid 1px #9CB6EC;">
                            <div style="height: 50px; line-height: 50px; font-size: 16px; font-weight: bold; background-color: #4571D9; color: white; float: left; border-radius: 5px 5px 0px 0px;">
                                <span style="letter-spacing: 10px; padding: 0px 60px;">月刊列表</span>
                            </div>
                        </div>
                        <div style="height: 25px;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <div style="margin: 0px 10px;">

                            <asp:Repeater ID="rep" runat="server">
                                <ItemTemplate>
                                    <div class="monthlyPublication">
                                        <a href="Publication.aspx?id=<%#Eval("CN_ID").ToString()%>">
                                            <img style="width: 150px;border-width:0" src="<%#Eval("CN_FIRST_PIC_URL").ToString()%>" /></a>
                                        <div style="text-align: center; height: 35px; line-height: 35px;width:100%">
                                            <a href="Publication.aspx?id=<%#Eval("CN_ID").ToString()%>" class="aColorBlank">荣诚月刊第<%#Eval("CN_NUMBER").ToString()%>期</a>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>

                        </div>
                        <div class="DynamicListPage">
                            <pager:AspNetPager ID="AspNetPager" runat="server" Width="100%" 
                                ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="跳转: "
                                HorizontalAlign="right" PageSize="8" OnPageChanged="AspNetPager_PageChanged"
                                EnableTheming="true" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                                PrevPageText="上一页">
                            </pager:AspNetPager>
                        </div>
                    </td>
                </tr>
            </table>

            <uc1:end runat="server" ID="end" />
        
            </center>
    </form>
</body>
</html>
