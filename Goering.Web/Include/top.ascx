<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="top.ascx.cs" Inherits="Goering.Web.Include.top1" %>
<style type="text/css">
    #logo { padding: 5px; width: 160px; height: 49px; float: left; }
    #logo img { height: 49px; width: 160px; }
    .menu { height: 60px; width: 600px; float: right; padding: 0; }
    .menu ul { list-style-type: none; margin: 0; padding: 0; float: right; }
    .menu ul li { float: left; font-size: 14px; padding: 0; margin: 0; text-align: center; height: 60px; vertical-align: middle; }
    .menu a { padding: 18px 12px; display: block; color: #4571D9; font-size: 16px; font-weight: bold; text-decoration: none; }
    .menu a.language { padding-top:20px}
</style>
<div id="container">
    <div id="logo">
        <img src="/Style/img/logo.png" alt="logo" />
    </div>
    <div runat="server" class="menu" id="menu">
    </div>
</div>
