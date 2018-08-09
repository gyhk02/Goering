<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobTitle.aspx.cs" Inherits="Goering.Web.Job.JobTitle" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>应聘职位-荣诚集团</title>
    <link href="../Style/css/evervan.css" rel="stylesheet" />
    <script src="../Style/js/jquery.min.js"></script>
    <style type="text/css">
        input {
            border: solid 1px #DADADA;
        }
    </style>
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
                                <span style="letter-spacing: 10px; padding: 0px 60px;">应聘职位</span>
                            </div>
                            <div style="float: right; margin-top: 30px; font-size: 14px;">
                                <a href="/Style/img/Template.xlsx" style="text-decoration: none; color: #4571D9;" target="_blank">简历模版下载</a>
                            </div>
                        </div>
                        <div style="margin: 10px;">
                            <div>
                                <div style="font-weight: bold; letter-spacing: 5px; color: #4571D9; font-size: 14px; float: left; padding: 10px 30px; border-bottom: solid 1px #D7DADF;">
                                    <asp:Label ID="lblJobName" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                            <div style="padding-left: 30px; padding-top: 50px; clear: both;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 80px; height: 50px;">姓 名：</td>
                                        <td style="width: 270px;">
                                            <asp:TextBox ID="txtName" runat="server" Width="120px" MaxLength="10"></asp:TextBox>&nbsp;<span style="color: red;">*</span>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入姓名" ControlToValidate="txtName" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                        </td>
                                        <td style="width: 80px;">手机号码：</td>
                                        <td>
                                            <asp:TextBox ID="txtPhoneNumber" runat="server" Width="120px" MaxLength="11"></asp:TextBox>&nbsp;<span style="color: red;">*</span>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入手机号码" ControlToValidate="txtPhoneNumber" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPhoneNumber" Display="Dynamic" ErrorMessage="请输入正确手机号" ForeColor="#FF3300" ValidationExpression="^1\d{10}$"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr style="height: 80px;">
                                        <td>身份证号码：</td>
                                        <td colspan="3">
                                            <asp:TextBox ID="txtIdentityCard" runat="server" Width="495px" MaxLength="20"></asp:TextBox>&nbsp;<span style="color: red;">*</span>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="请输入身份证号码" ControlToValidate="txtIdentityCard" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>备 注：</td>
                                        <td colspan="3">
                                            <asp:TextBox ID="txtRemark" runat="server" Height="100px" Width="495px" MaxLength="500"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr id="resume" style="height: 80px;" runat="server">
                                        <td>简 历：</td>
                                        <td colspan="3">
                                            <asp:FileUpload ID="btnSelectFile" runat="server" Width="500px" />
                                    </tr>
                                    <tr style="height: 50px;">
                                        <td>验 证 码：</td>
                                        <td colspan="3">
                                            <input class="nemo01" id="CheckCode" tabindex="3" maxlength="10" size="11" name="user"
                                                runat="server" style="width: 42%">
                                            <a id="A2" href="" onclick="ChangeCode();return false;">
                                                <asp:Image ID="ImageCheck" runat="server" ImageUrl="../ValidateCode.aspx?GUID=GUID"
                                                    ImageAlign="AbsMiddle" ToolTip="看不清，换一个" Width="54"></asp:Image></a><asp:Label ID="lblMsg" runat="server" BackColor="Transparent" ForeColor="Red"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr style="height: 80px;">
                                        <td colspan="4" style="text-align: center;">
                                            <asp:Button ID="btnSumit" runat="server" Text="提交简历" ForeColor="White" BackColor="#4571D9" Height="30px" Width="100px" OnClick="btnSumit_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </div>

                        </div>
                    </td>
                </tr>
            </table>
            <div style="height: 5px;">
                <img src="../Style/img/dot.gif" />
            </div>
            <uc1:end runat="server" ID="end" />
        </center>
    </form>
</body>
</html>
