<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobOpenings.aspx.cs" Inherits="Goering.Web.Job.JobOpenings" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>招聘职位-荣诚集团</title>
    <meta name="Keywords" content="人才招聘" />
    <meta name="Description" content="人才招聘" />
    <link href="../Style/css/evervan.css" rel="stylesheet" />
    <script src="../Style/js/jquery.min.js"></script>
    <style type="text/css">
        .JobOpeningsTr {
            border-bottom: solid 1px #9CB6EC;
            height: 30px;
        }
    </style>
    <script type="text/javascript">
        function openDetail(obj) {
            var detailName = obj.id + "Detail"
            if ($("#" + detailName).css("display") == "none") {
                $("#" + detailName).css("display", "");
                obj.innerHTML = "[收起]";
            } else {
                $("#" + detailName).css("display", "none");
                obj.innerHTML = "[展开]";
            }
        }
    </script>
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
                                <span style="letter-spacing: 10px; padding: 0px 60px;">招聘职位</span>
                            </div>
                        </div>
                        <div style="height: 25px;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <asp:Repeater ID="rep" runat="server" >
                            <HeaderTemplate>
                                <table style="width: 100%;">
                            <tr style="font-size:16px;">
                                <td style="text-align: center; height: 50px; background-color: #4571D9; color: white;">职位</td>
                                <td style="width: 20px;">&nbsp;</td>
                                <td style="text-align: center; height: 50px; background-color: #4571D9; color: white;">工作地区</td>
                                <td style="width: 20px;">&nbsp;</td>
                                <td style="text-align: center; height: 50px; background-color: #4571D9; color: white;">月薪范围</td>
                                <td style="width: 20px;">&nbsp;</td>
                                <td style="text-align: center; height: 50px; background-color: #4571D9; color: white;">更新时间</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr class="JobOpeningsTr">
                                <td style="text-align: left;padding-left:5px;font-size:14px"><%#Eval("CN_NAME") %></td>
                                <td>&nbsp;</td>
                                <td style="text-align: center;font-size:14px"><%#Eval("WorkAreaName") %></td>
                                <td>&nbsp;</td>
                                <td style="text-align: center;font-size:14px"><%#Eval("CN_MONTHLY_PAY") %></td>
                                <td>&nbsp;</td>
                                <td style="text-align: center;font-size:14px"><%#Eval("CN_MODIFY_DATE","{0:yyyy-MM-dd}") %>
                                    &ensp;&ensp;&ensp;
                                    <span id="JobId<%#Eval("CN_ID") %>" style="cursor: pointer;color:" onclick="javascript:openDetail(this);">[展开]</span>
                                </td>
                            </tr>
                            <tr id="JobId<%#Eval("CN_ID") %>Detail" style="display: none;">
                                <td colspan="7">
                                    <div style="margin-top: 10px; background-color: #EAF1FB;text-align:left">
                                        <div style="margin: 10px;">
                                            <div style="height: 25px; padding-top: 10px;font-size:13px">
                                                <div style="width: 150px; float: left;"><span style="font-weight:bold"> 招聘人数：</span><%#Eval("CN_RECRUITIMENT_NUMBER") %></div>
                                                <div style="width: 150px; float: left;padding-left:100px"><span style="font-weight:bold;"> 学历要求：</span><%#Eval("REQUIREMENTSName") %></div>
                                            </div>
                                            <div style="height: 25px;font-size:13px">
                                                <div style="width: 150px; float: left;"><span style="font-weight:bold">年龄要求：</span><%#Eval("CN_AGE") %></div>
                                                <div style="width: 150px; float: left;padding-left:100px"><span style="font-weight:bold">住宿情况：</span><%#Eval("CN_PUT_UP") %></div>
                                                <div style="width: 150px; float: left;padding-left:50px"><span style="font-weight:bold">工作经验：</span><%#Eval("CN_WORK_EXPERIENCE") %></div>
                                            </div>
                                            <div style="height: 25px;font-size:13px"><span style="font-weight:bold">联系方式：</span><%#Eval("CN_CONTACT") %></div>
                                            <div style="line-height: 25px;font-size:13px">
                                                <span style="font-weight:bold">具体要求：</span><br /><%#Eval("CN_REQUIREMENT_DETAIL") %>
                                            </div>
                                            <div style="height: 45px; padding-top: 10px;">
                                                <div style="letter-spacing: 10px; padding: 10px; float: right; background-color: #4571D9;">
                                                    <a href="JobTitle.aspx?JobID=<%#Eval("CN_ID") %>"  target="_blank" style="text-decoration: none; color: white;font-size:15px;font-weight:bold">应聘职位</a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div style="height: 1px; clear: both;">
                                        <img src="../Style/img/dot.gif" />
                                    </div>
                                </td>
                            </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                
                        </table>
                            </FooterTemplate>
                        </asp:Repeater>
                        
                        <div style="height: 10px;">
                            <img src="../Style/img/dot.gif" />
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
