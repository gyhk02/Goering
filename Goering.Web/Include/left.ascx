<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="left.ascx.cs" Inherits="Goering.Web.Include.left" %>

<%--<link href="../Style/css/evervan.css" rel="stylesheet" />--%>
<script src="../Style/js/jquery.min.js"></script>

<style type="text/css">
    .leftItemSelectedByA {
        text-decoration: none;
        color: yellow;
        font-size: 18px;
        /*font-weight:bold;*/
    }

    .leftItemSelectedByBgImg {
        background-image: url(../Style/img/YellowArrow.png);
        background-position: center;
        background-repeat: no-repeat;
        width: 16px;
    }

    .leftItemDefaultByLink {
        text-decoration: none;
        color: white;
        font-size: 18px;
    }
</style>

<div id="divLeftTitle" runat="server"
    style="height: 50px; line-height: 50px; font-size: 20px; font-weight: bold; background-color: #4571D9; color: white; border-radius: 5px 5px 0px 0px;text-align:center;width:100%">
    <span id="spanLeftTitle" runat="server" style="letter-spacing: 10px; ">关于荣诚</span>
</div>
<div style="height:660px; text-align: center; width: 263px; background-image: url('../Style/img/left.png');">
    <div style="height: 35px;">
        <img src="../Style/img/dot.gif" />
    </div>

    <div id="divLeft" runat="server" style="text-align:left"></div>
</div>
