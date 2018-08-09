<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageSwitcherList.aspx.cs" Inherits="Goering.Web.Manager.ImageSwitcherList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="pager" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>切换图片</title>
    <link href="../Style/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Style/css/common.css" rel="stylesheet" />
    <script src="../Style/js/jquery.min.js"></script>
    <script src="../Style/bootstrap/js/bootstrap.min.js"></script>
    <style>
        .left,
        .right {
            padding: 10px;
            display: table-cell;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="panel panel-default">
                <div class="panel-heading" style="text-align: left">
                    <span style="font-weight: bold; font-size: 14px">首页切换图片</span>
                </div>
                <div class="panel-body" style="padding: 2px">
                    <asp:Repeater ID="rep" runat="server" OnItemCommand="rep_ItemCommand">
                        <HeaderTemplate>
                            <table class="table table-striped table-bordered table-hover table-condensed">
                                <thead>
                                    <tr style="background-color: #337ab7; color: white">
                                        <th>名称</th>
                                        <th>上传日期</th>
                                        <th>查看</th>
                                        <th>操作</th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("CN_NAME") %></td>
                                <td><%#Eval("CN_CREATE_DATE","{0:d}") %></td>
                                <td>
                                    <a href='<%#Eval("CN_URL") %>' target="_blank">查看</a>
                                </td>
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
                        HorizontalAlign="right" PageSize="5" OnPageChanged="AspNetPager_PageChanged"
                        EnableTheming="true" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                        PrevPageText="上一页">
                    </pager:AspNetPager>
                </div>
            </div>
        </div>

        <div class="panel panel-default">
            <div class="panel-heading" style="text-align: left">
                <span style="font-weight: bold; font-size: 14px">上传图片<span  style="color: #337ab7">(尺寸：980x371)</span> </span>
            </div>
            <div class="panel-body" style="padding: 2px">
                <div class="form-group">
                    <div class="left">
                        <asp:FileUpload ID="btnSelectFile" runat="server" />
                    </div>
                    <div class="right">
                        <asp:Button ID="btnUpload" CssClass="btn btn-default" runat="server" Text="上传" OnClick="btnUpload_Click" />
                    </div>
                </div>

            </div>
        </div>
    </form>
</body>
</html>
