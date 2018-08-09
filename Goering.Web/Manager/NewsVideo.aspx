<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsVideo.aspx.cs" Inherits="Goering.Web.Manager.NewsVideo" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="pager" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../Style/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Style/css/common.css" rel="stylesheet" />
    <script src="../Style/js/jquery.min.js"></script>
    <script src="../Style/bootstrap/js/bootstrap.min.js"></script>
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
            var obj = document.getElementById('btnSelectFile');
            if (obj.value == "") {
                alert("请选择要上传的文件！");
                return false;
            }
            var stuff = obj.value.match(/^(.*)(\.)(.{1,8})$/)[3];
            if (stuff != "mp4") {
                alert("文件类型不正确，请选择.mp4文件！");
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
                    <span style="font-weight: bold; font-size: 14px">相关视频</span>
                </div>
                <div class="panel-body" style="padding: 2px">
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
                                <td><%#Eval("CN_NAME") %></td>
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
                        HorizontalAlign="right" PageSize="5" OnPageChanged="AspNetPager_PageChanged"
                        EnableTheming="true" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                        PrevPageText="上一页">
                    </pager:AspNetPager>
                </div>
            </div>
        </div>

        <div class="panel panel-default">
            <div class="panel-heading" style="text-align: left">
                <span style="font-weight: bold; font-size: 14px">请选择要上传有关<span style="color: #337ab7">“<asp:Label ID="lblVideoTitle" runat="server" Text=""></asp:Label>”</span>的视频(格式必须为MP4) </span>
            </div>
            <div class="panel-body" style="padding: 2px">
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
