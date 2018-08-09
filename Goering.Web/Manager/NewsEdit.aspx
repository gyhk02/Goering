<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsEdit.aspx.cs" Inherits="Goering.Web.Manager.NewsEdit" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>公司动态</title>
    <link href="../Style/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Style/css/common.css" rel="stylesheet" />
    <link rel="stylesheet" href="/Style/ueditor/themes/default/ueditor.css" />
    <script src="../Style/js/jquery.min.js"></script>
    <script src="../Style/bootstrap/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="../Style/ueditor/ueditor.config.js"></script>
    <script type="text/javascript" src="../Style/ueditor/ueditor.all.min.js"></script>
    
    <style type="text/css">
        #myEditor {
            width: auto;
        }
    </style>
    <script type="text/javascript">
        function CHeckSearchText() {
            var objNum = $("#txtTitle").val();
            if (objNum == "") {
                alert("请输入标题！");
                return false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">

        <div class="panel panel-default">
            <div class="panel-heading" style="text-align: left">
                <span style="font-weight: bold; font-size: 14px">编辑动态</span>
            </div>
            <div class="panel-body" style="padding: 10px;">
                <table style="width: 100%">
                    <tr style="height: 40px">
                        <td style="width:60px">
                            <label>标题</label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtTitle" runat="server" Width="500px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitle" ErrorMessage="不能为空" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr >
                        
                        <td colspan="2">
                            <textarea id="myEditor" name="myEditor" runat="server" onblur="setUeditor()"></textarea>
                            <script type="text/javascript">
                                var ue = UE.getEditor('myEditor');
                            </script>
                        </td>
                    </tr>
                    <tr style="height: 40px;text-align:center">
                        <td colspan="2">

                            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-default" Text="保存" OnClick="btnSave_Click" />
                <input id="btnback" type="button" value="返回" onclick="javascript: window.location.href = 'NewsList.aspx'" class="btn btn-default" />
                        </td>
                    </tr>

                </table>
            </div>
        </div>
        
    </form>
</body>
</html>
