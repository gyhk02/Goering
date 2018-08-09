<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobEdit.aspx.cs" Inherits="Goering.Web.Manager.JobEdit" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>编辑职位</title>
    <link href="../Style/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Style/css/common.css" rel="stylesheet" />
    <link rel="stylesheet" href="/Style/ueditor/themes/default/ueditor.css" />
    <script src="../Style/js/jquery.min.js"></script>
    <script src="../Style/bootstrap/js/bootstrap.min.js"></script>
    <script src="../Style/My97DatePicker/WdatePicker.js"></script>
    <script type="text/javascript" src="../Style/ueditor/ueditor.config.js"></script>
    <script type="text/javascript" src="../Style/ueditor/ueditor.all.min.js"></script>
    
</head>
<body>
    <form id="form1" runat="server">
        <div class="panel panel-default">
            <div class="panel-heading" style="text-align: left">
                <span style="font-weight: bold; font-size: 14px">编辑职位</span>
            </div>
            <div class="panel-body" style="padding: 2px">
                <table style="width: 600px;margin:5px" align="left">
                    <tr>
                        <td style="width: 50%">
                            <label>职位名称</label>
                            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><span style="color:red">*</span>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="不能为空" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <label>工作地区</label>
                            <asp:DropDownList ID="ddlWorkArea" runat="server"></asp:DropDownList><span style="color:red">*</span>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 50%">

                            <label>月薪范围</label>

                            <asp:TextBox ID="txtMONTHLY_PAY" runat="server"></asp:TextBox><span style="color:red">*</span>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMONTHLY_PAY" ErrorMessage="不能为空" ForeColor="Red"></asp:RequiredFieldValidator>

                        </td>
                        <td style="width: 50%">

                            <label>招聘人数</label>

                            <asp:TextBox ID="txtRECRUITIMENT_NUMBER" runat="server"></asp:TextBox><span style="color:red">*</span>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtRECRUITIMENT_NUMBER" ErrorMessage="不能为空" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtRECRUITIMENT_NUMBER" ErrorMessage="请填正整数" ForeColor="#FF3300" ValidationExpression="^[1-9]*[1-9][0-9]*$"></asp:RegularExpressionValidator>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>学历要求</label>

                            <asp:DropDownList ID="ddlRequireMent" runat="server"></asp:DropDownList><span style="color:red">*</span>

                        </td>
                        <td style="width: 50%">

                            <label>年龄要求</label>

                            <asp:TextBox ID="txtAGE" runat="server"></asp:TextBox><span style="color:red">*</span>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtAGE" ErrorMessage="不能为空" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                        </td>
                    </tr>
                    <tr>
                        <td style="width: 50%">

                            <label>工作经验</label>

                            <asp:TextBox ID="txtWORK_EXPERIENCE" runat="server"></asp:TextBox><span style="color:red">*</span>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtWORK_EXPERIENCE" ErrorMessage="不能为空" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                        </td>
                        <td style="width: 50%">

                            <label>截止日期</label>

                            <asp:TextBox ID="txtEXPIRY_DATE" runat="server"   onclick="WdatePicker({ readOnly: true, dateFmt: 'yyyy-MM-dd' })"></asp:TextBox><span style="color:red">*</span>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtEXPIRY_DATE" ErrorMessage="不能为空" ForeColor="#FF3300"></asp:RequiredFieldValidator>

                        </td>
                    </tr>
                    <tr>
                        <td style="width: 50%">

                             <label>住宿情况</label>

                            <asp:TextBox ID="txtCN_PUT_UP"  runat="server"></asp:TextBox><span style="color:red">*</span>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="不能为空" ControlToValidate="txtCN_PUT_UP" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>

                        <td style="width: 50%">

                            <label>上传简历</label>

                            <asp:CheckBox ID="chkIS_RESUME" runat="server" />

                        </td>

                    </tr>
                    <tr>
                        <td  colspan="2">
                            <label>联系方式</label>

                            <asp:TextBox ID="txtCONTACT" Width="450px" runat="server"></asp:TextBox><span style="color:red">*</span>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtCONTACT" ErrorMessage="不能为空" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        </td>

                    </tr>
                    <tr>
                        <td colspan="2" style="height:200px">

                            <label>具体要求</label>

                            <textarea id="txtREQUIREMENT_DETAIL" runat="server"  cols="70" rows="8"></textarea><span style="color:red">*</span>
                            <script type="text/javascript">
                                var ue = UE.getEditor('txtREQUIREMENT_DETAIL', {
                                    toolbars: [
                                        ['source', 'undo', 'redo', 'bold', 'fontfamily', 'fontsize', 'justifyleft', 'justifyright', 'justifycenter', 'justifyjustify', 'forecolor']
                                    ],
                                    nitialFrameHeight:250,
                                    autoHeightEnabled: false,
                                    autoFloatEnabled: true
                                });
                            </script>
                           

                        </td>

                    </tr>

                    <tr>
                        <td colspan="2" style="text-align:center;padding:5px">

                            <asp:Button ID="btnHidden" runat="server" CssClass="btn btn-default" OnClick="btnSave_ServerClick" Text="保存" />
                            <input id="btnback" type="button" value="返回" onclick="javascript: window.location.href = 'UserList.aspx'" class="btn btn-default" />

                        </td>

                    </tr>
                </table>

            </div>
        </div>

    </form>
</body>
</html>
