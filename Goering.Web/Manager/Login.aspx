<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Goering.Web.Manager.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Style/css/Login.css" rel="stylesheet" type="text/css" />
    <script src="../Style/js/jquery.min.js" type="text/javascript"></script>
    <title>荣诚集团后台-后台登录</title>
    <script language="javascript" type="text/javascript">
        function ChangeCode() {

            var date = new Date();
            var myImg = document.getElementById("ImageCheck");
            var GUID = document.getElementById("lblGUID");

            if (GUID != null) {
                if (GUID.innerHTML != "" && GUID.innerHTML != null) {
                    myImg.src = "../ValidateCode.aspx?GUID=" + GUID.innerHTML + "&flag=" + date.getMilliseconds()

                }
            }
            return false;
        }

        function validate() {
            var username = $("#txtUsername");
            var password = $("#txtPass");
            var checkCode = $("#CheckCode")

            if ($.trim(username.val()) == "") {
                alert("用户名不能为空");
                username.focus();
                return false;
            }

            if ($.trim(password.val()) == "") {
                alert("密码不能为空");
                password.focus();
                return false;
            }

            if ($.trim(checkCode.val()) == "") {
                alert("验证码不能为空");
                checkCode.focus();
                return false;
            }

            return true;


        }


    </script>
</head>
<body leftmargin="0" topmargin="0" marginheight="0" marginwidth="0">
    <form id="form1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <table width="620" border="0" align="center" cellpadding="0" cellspacing="0">
        <tbody>
            <tr>
                <td width="620" style="height: 11px; line-height: 11px;">
                    <img height="11" src="/Style/img/login/login_p_img02.gif" width="650">
                </td>
            </tr>
            <tr>
                <td align="center" style="height: 230px; background-image: url(/Style/img/login/login_p_img03.gif);">
                    <table width="570" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td>
                                <table cellspacing="0" cellpadding="0" width="570" border="0">
                                    <tbody>
                                        <tr>
                                            <td width="245" height="80" align="center" valign="top">
                                                <img height="67" src="/Style/img/logo.png" width="245">
                                            </td>
                                            <td align="right" valign="top">
                                                <br>
                                                &nbsp;<img height="9" src="/Style/img/login/point07.gif" width="13" border="0">
                                                欢迎登录
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;<asp:Label ID="lblGUID" runat="server" Style="display: none"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <img src="../Style/img/login/a_te01.gif" width="570" height="3">
                            </td>
                        </tr>
                        <tr>
                            <td align="center" background="/Style/img/login/a_te02.gif">
                                <table width="520" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td width="123" height="120">
                                            <img height="95" src="/Style/img/login/login_p_img05.gif" width="123" border="0">
                                        </td>
                                        <td align="center">
                                            <table cellspacing="0" cellpadding="0" border="0">
                                                <tr>
                                                    <td width="210" valign="middle">
                                                        用户名：
                                                        <input class="nemo01" tabindex="1" maxlength="22" size="22" name="user" id="txtUsername"
                                                            runat="server"/>
                                                    </td>
                                                    <td width="80" rowspan="3" align="right" valign="middle">
                                                        <asp:ImageButton ID="btnLogin" runat="server" ImageUrl="/Style/img/login/login_p_img11.gif"
                                                            OnClientClick=" return validate()" OnClick="btnLogin_Click"></asp:ImageButton>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="middle">
                                                        密&nbsp;&nbsp; 码：
                                                        <input name="user" type="password" class="nemo01" tabindex="1" size="22" maxlength="22"
                                                            id="txtPass" runat="server">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="middle">
                                                        验证码：
                                                        <input class="nemo01" id="CheckCode" tabindex="3" maxlength="22" size="11" name="user"
                                                            runat="server" style="width: 42%">
                                                        <a id="A2" href="" onclick="ChangeCode();return false;">
                                                            <asp:Image ID="ImageCheck" runat="server" ImageUrl="/ValidateCode.aspx?GUID=GUID"
                                                                ImageAlign="AbsMiddle" ToolTip="看不清，换一个" Width="54"></asp:Image></a>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br>
                                            <asp:Label ID="lblMsg" runat="server" BackColor="Transparent" ForeColor="Red"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td bgcolor="#ffffff">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="height: 11px; line-height: 11px;">
                    <img height="11" src="../Style/img/login/login_p_img04.gif" width="650">
                </td>
            </tr>
        </tbody>
    </table>
    <br />
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td height="70" align="center">
                &nbsp;</td>
        </tr>
    </table>
    <br>
    </form>
</body>
</html>
