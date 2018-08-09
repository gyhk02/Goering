<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MonthlyMagazine.aspx.cs" Inherits="Goering.Web.Manager.MonthlyMmagazine" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="pager" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>荣诚月刊</title>
    <link href="../Style/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Style/css/common.css" rel="stylesheet" />
    <script src="../Style/js/jquery.min.js"></script>
    <script src="../Style/bootstrap/js/bootstrap.min.js"></script>
    <style>
        .left,
        .right {
            padding: 10px;
            display: table-cell;
        }
    </style>
    <script type="text/javascript">
        function CheckFileUpload() {
            var objNum = $("#txtNumber").val();
            //if (isNaN(objNum)||objNum=="")
            if (!(/^(\+|-)?\d+$/.test(objNum)) || objNum < 0) {
                alert("请输入正整数月刊期数！");
                $("#txtNumber").val("");
                return false;
            }

            var obj = document.getElementById('btnSelectFile');
            if (obj.value == "") {
                alert("请选择要上传的文件！");
                return false;
            }
            var stuff = obj.value.match(/^(.*)(\.)(.{1,8})$/)[3];
            if (stuff != "zip") {
                alert("文件类型不正确，请选择.zip文件！");
                return false;
            }
            return true;
        }
        function CHeckSearchText() {
            var objNum = $("#txtMonthlyName").val();
            if (objNum == "") {
                return true;
            }
            if (!(/^(\+|-)?\d+$/.test(objNum)) || objNum < 0) {
                alert("标题请输入正整数！");
                $("#txtMonthlyName").val("");
                return false;
            }
            return true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="panel panel-default">
                <div class="panel-heading" style="text-align: left">
                    <span style="font-weight: bold; font-size: 14px">荣诚月刊</span>&nbsp;
                </div>
                <div class="panel-body" style="padding: 2px">
                    <div style="width: 100%; vertical-align: central; text-align: left; padding: 5px">
                        <label>标题</label>
                        <asp:TextBox ID="txtMonthlyName" runat="server"></asp:TextBox>
                        <asp:Button ID="btnSearch" runat="server" Text="查询" CssClass="btn btn-default btn-sm" OnClick="btnSearch_Click" OnClientClick="return CHeckSearchText();" />
                    </div>
                    <asp:Repeater ID="rep" runat="server" OnItemCommand="rep_ItemCommand">
                        <HeaderTemplate>
                            <table class="table table-striped table-bordered table-hover table-condensed">
                                <thead>
                                    <tr style="background-color: #337ab7; color: white">
                                        <th>名称</th>
                                        <th>上传日期</th>
                                        <th>操作</th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("CN_NUMBER","荣诚月刊第{0}期") %></td>
                                <td><%#Eval("CN_CREATE_DATE","{0:d}") %></td>
                                <td>
                                    <asp:LinkButton ID="btnDelete" runat="server" CommandArgument='<%#Eval("CN_ID") %>' CommandName="Delete" OnClientClick="return confirm('确认要删除？') ">删除</asp:LinkButton>
                                </td>
                            </tr>

                        </ItemTemplate>
                        <FooterTemplate>
                            </tbody>
                    </table>
                        </FooterTemplate>
                    </asp:Repeater>

                    <pager:AspNetPager ID="AspNetPager" runat="server" Width="100%" UrlPaging="true"
                        ShowPageIndexBox="Always" PageIndexBoxType="DropDownList" TextBeforePageIndexBox="跳转: "
                        HorizontalAlign="right" PageSize="9" OnPageChanged="AspNetPager_PageChanged"
                        EnableTheming="true" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                        PrevPageText="上一页">
                    </pager:AspNetPager>
                </div>
            </div>
        </div>
        <div class="panel panel-default">
            <div class="panel-heading" style="text-align: left">
                <span style="font-weight: bold; font-size: 14px">温馨提示:<span style="color: #337ab7">月刊必须打包成.zip格式上传</span> </span>
            </div>
            <div class="panel-body" style="padding: 2px">
                <div class="form-group">
                    <span>月刊期数：第<asp:TextBox ID="txtNumber" runat="server" Width="50px"></asp:TextBox>期</span>&nbsp;&nbsp;&nbsp;&nbsp;
                </div>
                <div class="form-group">
                    <div class="left">
                        <asp:FileUpload ID="btnSelectFile" runat="server" />
                    </div>
                    <div class="right">
                        <asp:Button ID="btnUpload" CssClass="btn btn-default" runat="server" Text="上传" OnClick="btnUpload_Click" OnClientClick="return CheckFileUpload();" />
                    </div>
                </div>

            </div>
        </div>
    </form>
</body>
</html>
