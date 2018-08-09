<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjectEdit.aspx.cs" Inherits="Goering.Web.Manager.ProjectEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>编辑项目</title>
    <link rel="stylesheet" href="../Style/bootstrap/css/bootstrap.min.css" />
    <script src="../Style/js/jquery.min.js"></script>
    <script src="../Style/bootstrap/js/bootstrap.min.js"></script>
</head>
<body>

    <form runat="server">
        <div class="panel panel-default">
            <div class="panel-heading" style="text-align: left">
                <span style="font-weight: bold; font-size: 14px">编辑项目</span>
            </div>
            <div class="panel-body" style="padding: 10px;">
                <table style="width: 500px">
                    <tr style="height: 40px">
                        <td>
                            <label>项目名称</label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtProjectName" runat="server"></asp:TextBox><span style="color: red">*</span>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入项目名称" ControlToValidate="txtProjectName" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="项目名称重复" OnServerValidate="CustomValidator1_ServerValidate" ForeColor="Red"></asp:CustomValidator>
                        </td>
                    </tr>
                    <tr style="height: 40px">
                        <td>
                            <label>链接地址</label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtURL" runat="server"></asp:TextBox><span style="color: red">*</span>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入链接地址" ControlToValidate="txtURL" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr style="height: 40px">
                        <td>
                            <label>排序</label></td>
                        <td>
                            <asp:TextBox ID="txtSort" runat="server"></asp:TextBox><span style="color: red">*</span>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="请输入排序" ControlToValidate="txtSort" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr style="height: 40px">
                        <td>
                            <label for="reallyname"></label>
                        </td>
                        <td>
                            <asp:CheckBox ID="cbxIsEnable" Text="是否启用" runat="server" />
                        </td>
                    </tr>
                    <tr style="height: 40px">
                        <td colspan="2" style="text-align: center; padding: 5px">
                            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-default" OnClick="btnSave_ServerClick" Text="保存" />
                            <input id="btnback" type="button" value="返回" onclick="javascript: window.location.href = 'ProjectList.aspx'" class="btn btn-default" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>

    </form>
</body>
</html>
