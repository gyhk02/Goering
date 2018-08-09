<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectUser.aspx.cs" Inherits="Goering.Web.Manager.SelectUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>选择用户</title>
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
                    <span style="font-weight: bold; font-size: 14px">选择用户</span>
                </div>
                <div class="panel-body" style="padding: 2px">
                    <asp:Repeater ID="rep" runat="server">
                        <HeaderTemplate>
                            <table class="table table-striped table-bordered table-hover table-condensed">
                                <thead>
                                    <tr style="background-color: #337ab7; color: white">
                                        <th>选择</th>
                                        <th>登录名</th>
                                        <th>工号</th>
                                        <th>姓名</th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%#Eval("Selected")%>' /><asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("CN_ID") %>' />
                                </td>
                                <td><%#Eval("CN_LOGIN_NAME") %></td>
                                <td><%#Eval("CN_EMPLOYEE_NO") %></td>
                                <td><%#Eval("CN_REALLY_NAME") %></td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </tbody>
                    </table>
                        </FooterTemplate>
                    </asp:Repeater>
                    <div class="form-group">
                        <div class="col-sm-offset-5">
                            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-default" OnClick="btnSave_Click" Text="保存" />
                            <input id="btnback" type="button" value="返回" onclick="javascript: window.location.href = 'Authorization.aspx'"  class="btn btn-default"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
