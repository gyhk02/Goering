<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Goering.Web.Manager.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>后台管理</title>
    <link href="../Style/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Style/css/common.css" rel="stylesheet" />
    <script src="../Style/js/jquery.min.js"></script>
    <script src="../Style/bootstrap/js/bootstrap.min.js"></script>
    <script type="text/javascript">
        function AddPage(pageUrl)
        {
            $("#ifMain").attr("src", pageUrl);
        }
    </script>
    
</head>
<body >
    <form id="form1" runat="server">
        <nav class="navbar navbar-default" role="navigation" style="margin: 1px">
            <div class="container-fluid">
                <div class="navbar-header">
                    <a class="navbar-brand" href="#">后台管理</a>
                </div>
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="#"><span class="glyphicon glyphicon-user"></span>你好，<%= Session["ReallyName"] %> </a></li>
                    <li><a href="javascript:void(0)" onclick="AddPage('ModifyPwd.aspx')"><span class="glyphicon glyphicon-lock"></span>修改密码 </a></li>
                    <li><a href="/Manager/LoginOut.aspx"><span class="glyphicon glyphicon-log-in"></span>退出</a></li>
                </ul>
            </div>
        </nav>

        <div class="container-fluid" style="margin: 0">
            <div class="row">
                <div id="menu"  runat="server" class="col-md-2" style="height: 500px; padding: 2px">
                </div>
                <div id="main" class="col-md-10" style="padding:0" >
                    <iframe id="ifMain" scrolling="auto" frameborder="0"  src="" style="width:100%;height:100%;"></iframe>
                </div>
            </div>
        </div>


    </form>
    <script type="text/javascript">
        $(window).resize(function () {
            InitHeight();
        });
        function InitHeight()
        {
            var height = $(window).height() - 60
            
            $("#main").css("height", height);
        }

        InitHeight();
        </script>
</body>
    
    
</html>
