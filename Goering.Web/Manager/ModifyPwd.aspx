<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyPwd.aspx.cs" Inherits="Goering.Web.Manager.ModifyPwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>修改密码</title>
    <link rel="stylesheet" href="../Style/bootstrap/css/bootstrap.min.css" />
    <script src="../Style/js/jquery.min.js"></script>
    <script src="../Style/bootstrap/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
     <div class="panel panel-default">
            <div class="panel-heading" style="text-align: left">
                <span style="font-weight: bold; font-size: 14px">修改密码</span>
            </div>
            <div class="panel-body" style="padding: 10px;">
                <table style="width: 400px">
                    <tr style="height: 40px">
                        <td>
                            <label>登录名</label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtLoginName" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr style="height: 40px">
                        <td>
                            <label>原密码</label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtOldPwd" runat="server" TextMode="Password"></asp:TextBox><span style="color: red">*</span>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="不能为空" ControlToValidate="txtOldPwd" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtOldPwd" ErrorMessage="原密码不正确" ForeColor="#FF3300" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                        </td>
                    </tr>
                    <tr style="height: 40px">
                        <td>
                            <label>新密码</label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPassword1" runat="server" TextMode="Password"></asp:TextBox><span style="color: red">*</span>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="不能为空" ControlToValidate="txtPassword1" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr style="height: 40px">
                        <td>
                            <label>确认新密码</label></td>
                        <td>
                            <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password"></asp:TextBox><span style="color: red">*</span>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="不能为空" ControlToValidate="txtPassword2" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword1" ControlToValidate="txtPassword2" Display="Dynamic" ErrorMessage="两次密码不一致" ForeColor="#FF3300"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr style="height: 40px">
                        <td colspan="2" style="text-align: center; padding: 5px">
                            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-default" OnClick="btnSave_ServerClick" Text="保存" />
                            &nbsp;</td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
