<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplyForList.aspx.cs" Inherits="Goering.Web.Manager.ApplyForList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="pager" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>应聘简历</title>
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
                    <span style="font-weight: bold; font-size: 14px">职位列表</span>&nbsp; <a href="JobEdit.aspx" class="glyphicon glyphicon-plus
glyphicon ">新增</a>
                </div>
                <div class="panel-body" style="padding: 2px">
                    <div style="width: 100%; vertical-align:central; text-align: left; padding: 5px">
                        <label>职位名称</label><asp:TextBox ID="txtName" CssClass="" runat="server"></asp:TextBox>
                        &nbsp;
                        <label>状态</label><asp:DropDownList ID="ddlState" runat="server">
                            <asp:ListItem Value="-1">请选择</asp:ListItem>
                            <asp:ListItem Value="1">已查看</asp:ListItem>
                            <asp:ListItem Value="0">未查看</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;
                        <asp:Button ID="btnSearch" CssClass="btn btn-default btn-sm" runat="server" Text="查询" />
                    </div>
                    <asp:Repeater ID="rep" runat="server" OnItemCommand="rep_ItemCommand">
                        <HeaderTemplate>
                            <table class="table table-striped table-bordered table-hover table-condensed">
                                <thead>
                                    <tr style="background-color: #337ab7; color: white">
                                        <th>应聘职位</th>
                                        <th>应聘者姓名</th>
                                        <th>手机号码</th>
                                        <th>身份证号码</th>
                                        <th>投递日期</th>
                                        <th>备注</th>
                                        <th>简历</th>
                                        <th>状态</th>
                                        <th>删除</th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("JobName") %></td>
                                <td><%#Eval("CN_NAME") %></td>
                                <td>
                                    <%#Eval("CN_PHONE_NUMBER") %>
                                </td>
                                <td><%#Eval("CN_IDENTITY_CARD") %></td>
                                <td><%#Eval("CN_CREATE_DATE","{0:d}") %></td>
                                <td>
                                    <%#Eval("CN_REMARK") %>
                                </td>
                                <td>
                                    <a href='<%#Eval("CN_RESUME_PATH") %>'>下载</a>
                                </td>
                                <td>
                                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#Eval("CN_ID") %>' CommandName="Look"><%#GetStateName((bool)Eval("CN_IS_LOOK")) %></asp:LinkButton>
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
