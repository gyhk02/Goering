<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsList.aspx.cs" Inherits="Goering.Web.Manager.News" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="pager" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>公司动态</title>
    <link href="../Style/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Style/css/common.css" rel="stylesheet" />
    <script src="../Style/js/jquery.min.js"></script>
    <script src="../Style/bootstrap/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="panel panel-default">
                <div class="panel-heading" style="text-align: left">
                    <span style="font-weight: bold; font-size: 14px">公司动态</span>&nbsp;<a href="NewsEdit.aspx" class="glyphicon glyphicon-plus
glyphicon ">新增</a>
                </div>
                
                <div class="panel-body" style="padding: 2px">
                    <div style="width: 100%; vertical-align:central; text-align: left; padding: 5px">
                            <label >标题</label>
                            <asp:TextBox ID="txtMonthlyName" runat="server"></asp:TextBox>
                            <asp:Button ID="btnSearch" CssClass="btn btn-default btn-sm" runat="server" Text="查询" OnClick="btnSearch_Click" />
                       </div>
                    
                    <asp:Repeater ID="rep" runat="server" OnItemCommand="rep_ItemCommand">
                        <HeaderTemplate>
                            <table class="table table-striped table-bordered table-hover table-condensed">
                                <thead>
                                    <tr style="background-color: #337ab7; color: white">
                                        <th>标题</th>
                                        <th>上传日期</th>
                                        <th>编辑</th>
                                        <th>相关视频</th>
                                        <th>删除</th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("CN_TITLE") %></td>
                                <td><%#Eval("CN_CREATE_DATE","{0:d}") %></td>
                                <td><asp:LinkButton ID="btnEdit" runat="server" CommandArgument='<%#Eval("CN_ID") %>' CommandName="Edit">编辑</asp:LinkButton></td>
                                <td><asp:LinkButton ID="btnVideo" runat="server" CommandArgument='<%#Eval("CN_ID") %>' CommandName="Video">相关视频</asp:LinkButton></td>
                                <td>
                                    <asp:LinkButton ID="btnDelete" runat="server" CommandArgument='<%#Eval("CN_ID") %>' CommandName="Delete" OnClientClick="return confirm('确认要删除？') ">删除</asp:LinkButton>
                                </td>
                            </tr>

                        </ItemTemplate>
                        <FooterTemplate>
                            </tbody>
                    </table>
                        </FooterTemplate>
                    </asp:Repeater>

                    <pager:AspNetPager ID="AspNetPager" runat="server" Width="100%" UrlPaging="true"
                        ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="跳转: "
                        HorizontalAlign="right" PageSize="9" OnPageChanged="AspNetPager_PageChanged"
                        EnableTheming="true" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                        PrevPageText="上一页">
                    </pager:AspNetPager>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
