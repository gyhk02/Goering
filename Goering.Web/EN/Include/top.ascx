<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="top.ascx.cs" Inherits="Goering.Web.EN.Include.top" %>
<style type="text/css">
    #logo { padding: 5px; width: 160px; height: 49px; float: left; }
    #logo img { height: 49px; width: 160px; }
    .menu { height: 60px; width: 600px; float: right; padding: 0; }
    .menu ul { list-style-type: none; margin: 0; padding: 0; float: right; }
    .menu ul li { float: left; font-size: 14px; padding: 0; margin: 0; text-align: center; height: 60px; vertical-align: middle; }
    .menu a { padding: 18px 12px; display: block; color: #4571D9; font-size: 16px; font-weight: bold; text-decoration: none; }
    .menu a.language { padding-top:16px}
</style>
<div id="container">
    <div id="logo">
        <img src="<%=ResolveUrl("~/Style/img/logo.png") %>" alt="logo" />
    </div>
    <div class="menu" id="menu">
        <ul>
            <li id='m1'><a id='a1' href='<%=ResolveUrl("~/EN/Default.aspx") %>'>Homepage</a></li>
            <li id='m2'><a id='a2' href='<%=ResolveUrl("~/EN/About/Introduction.aspx")%>'>About Evervan Group</a></li>
            <li><a class="language" href='<%=ResolveUrl("~/Default.aspx") %>'>中文版</a></li>
        </ul>
    </div>
    <%if(!string.IsNullOrEmpty(HighLightId))
      { %>
        <script type="text/javascript">
            var obj = document.getElementById("<%=HighLightId%>");
            obj.style.backgroundColor = "#4571D9";
            obj.getElementsByTagName("a")[0].style.color = "white"
        </script>
    <% }%>
</div>