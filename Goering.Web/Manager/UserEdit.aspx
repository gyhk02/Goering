<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserEdit.aspx.cs" Inherits="Goering.Web.Manager.UserEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>编辑用户</title>
    <link rel="stylesheet" href="../Style/bootstrap/css/bootstrap.min.css" />
    <script src="../Style/js/jquery.min.js"></script>
    <script src="../Style/bootstrap/js/bootstrap.min.js"></script>
</head>
<body>

    <form runat="server">
        <div class="panel panel-default">
            <div class="panel-heading" style="text-align: left">
                <span style="font-weight: bold; font-size: 14px">编辑用户</span>
            </div>
            <div class="panel-body" style="padding: 10px;">
                <table style="width: 400px">
                    <tr style="height: 40px">
                        <td>
                            <label>登录名</label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtLoginName" runat="server"></asp:TextBox><span style="color: red">*</span>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入登录名" ControlToValidate="txtLoginName" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="登录名重复" OnServerValidate="CustomValidator1_ServerValidate" ForeColor="Red"></asp:CustomValidator>
                        </td>
                    </tr>
                    <tr style="height: 40px">
                        <td>
                            <label>密码</label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox><span style="color: red">*</span>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入密码" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr style="height: 40px">
                        <td>
                            <label>工号</label></td>
                        <td>
                            <asp:TextBox ID="txtEmployeeNo" runat="server"></asp:TextBox><span style="color: red">*</span>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="请输入工号" ControlToValidate="txtEmployeeNo" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr style="height: 40px">
                        <td>
                            <label for="reallyname">真实姓名</label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtReallyName" runat="server"></asp:TextBox><span style="color: red">*</span>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="请输入真实姓名" ControlToValidate="txtReallyName" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr style="height: 40px">
                        <td colspan="2" style="text-align: center; padding: 5px">
                            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-default" OnClick="btnSave_ServerClick" Text="保存" />
                            <input id="btnback" type="button" value="返回" onclick="javascript: window.location.href = 'UserList.aspx'" class="btn btn-default" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>

    </form>
</body>
</html>
