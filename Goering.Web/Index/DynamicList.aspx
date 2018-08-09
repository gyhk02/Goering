<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicList.aspx.cs" Inherits="Goering.Web.Index.DynamicList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="pager" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>公司动态列表-荣诚集团</title>
    <meta name="Keywords" content="动态列表" />
    <meta name="Description" content="动态列表" />
    <link href="../Style/css/evervan.css" rel="stylesheet" />
    <script src="../Style/js/jquery.min.js"></script>
    <style type="text/css">
        .border {
            border: solid 1px #DADADA;
        }

        .DynamicListButton {
            /*background-color: #4571D9;
            color: white;*/
        }
    </style>
    <script type="text/javascript">
        function focusTitle(obj) {
            if (obj.value == "标题") {
                obj.value = "";
                $(obj).css("color", "black");
            }
        }
        function blurTitle(obj) {
            if (obj.value == "") {
                obj.value = "标题";
                $(obj).css("color", "Silver");
            }
        }
    </script>
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
                                <span style="letter-spacing: 10px; padding: 0px 60px;">动态列表</span>
                            </div>
                            <div style="float: left; margin-top: 25px;margin-left:10px">
                                <asp:TextBox ID="txtTitle" runat="server"  Width="300px" CssClass="border"
                                    ForeColor="Silver" OnFocus="javascript:focusTitle(this);" OnBlur="javascript:blurTitle(this);">标题</asp:TextBox>
                                <asp:Button ID="btnSearch" CssClass="border DynamicListButton" runat="server" Text="查询" OnClick="btnSearch_Click" />
                            </div>
                        </div>
                        <div style="height: 25px;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <div style="margin: 0px 10px;">
                            <div style="height: 25px; clear: both;">
                                <img src="../Style/img/dot.gif" />
                            </div>
                            <asp:Repeater ID="rep" runat="server">
                                <ItemTemplate>
                                    <div >
                                        <div style="float: left;"><a style="font-size:14px" href="Dynamic.aspx?id=<%#Eval("CN_ID").ToString()%>" class="aColorBlank"><%#Eval("CN_TITLE").ToString()%></a></div>
                                        <div style="float: right; color: #808080;font-size:14px"><%# DateTime.Parse( Eval("CN_CREATE_DATE").ToString()).ToString("yyyy-MM-dd")%></div>
                                    </div>
                                    <div style="height: 25px; clear: both;">
                                        <img src="../Style/img/dot.gif" />
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <div class="DynamicListPage">
                            <pager:AspNetPager ID="AspNetPager" runat="server" Width="100%"
                                ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="跳转: "
                                HorizontalAlign="right" PageSize="12" OnPageChanged="AspNetPager_PageChanged"
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
