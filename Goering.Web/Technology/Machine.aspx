<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Machine.aspx.cs" Inherits="Goering.Web.Technology.Machine" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>生产机台-荣诚集团</title>
    <link href="../Style/css/evervan.css" rel="stylesheet" />
    <script type="text/javascript" src="/Style/ckplayer/ckplayer.js" charset="UTF-8"></script>
    <style type="text/css">
        .monthlyPublication {
            margin: 0;
            float: left;
            width: 190px;
            padding: 10px;
            text-align: center;
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
                                <span style="letter-spacing: 10px; padding: 0px 60px;">生产机台</span>
                            </div>
                        </div>
                        <div style="height: 25px;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <div style="margin: 0 10px;">
                           <div class="monthlyPublication">
                                <img style="width: 150px;height:130px;border-width:0" src="/Style/img/Technology/machine1.png" />
                                <div style="text-align: center; height: 35px; line-height: 35px;width:100%">
                                   自动裁断
                                </div>
                            </div>

                            <div class="monthlyPublication">
                                <img style="width: 150px;height:130px;border-width:0" src="/Style/img/Technology/machine2.png" />
                                <div style="text-align: center; height: 35px; line-height: 35px;width:100%">
                                   镭射切割机
                                </div>
                            </div>

                            <div class="monthlyPublication">
                                <img style="width: 150px;height:130px;border-width:0" src="/Style/img/Technology/machine3.png" />
                                <div style="text-align: center; height: 35px; line-height: 35px;width:100%">
                                   立体环形印刷线
                                </div>
                            </div>

                            <div class="monthlyPublication">
                                <img style="width: 150px;height:130px;border-width:0" src="/Style/img/Technology/machine4.png" />
                                <div style="text-align: center; height: 35px; line-height: 35px;width:100%">
                                   智能标记印线机
                                </div>
                            </div>

                            <div class="monthlyPublication">
                                <img style="width: 150px;height:130px;border-width:0" src="/Style/img/Technology/machine5.png" />
                                <div style="text-align: center; height: 35px; line-height: 35px;width:100%">
                                   双工位低辐射高周波机
                                </div>
                            </div>

                            <div class="monthlyPublication">
                                <img style="width: 150px;height:130px;border-width:0" src="/Style/img/Technology/machine6.png" />
                                <div style="text-align: center; height: 35px; line-height: 35px;width:100%">
                                   360度无需压底模压机
                                </div>
                            </div>

                            <div class="monthlyPublication">
                                <img style="width: 150px;height:130px;border-width:0" src="/Style/img/Technology/machine7.png" />
                                <div style="text-align: center; height: 35px; line-height: 35px;width:100%">
                                   微珠式压机
                                </div>
                            </div>

                            <div class="monthlyPublication">
                                <img style="width: 150px;height:130px;border-width:0" src="/Style/img/Technology/machine8.png" />
                                <div style="text-align: center; height: 35px; line-height: 35px;width:100%">
                                   中底清洗机
                                </div>
                            </div>

                            <div class="monthlyPublication">
                                <img style="width: 150px;height:130px;border-width:0" src="/Style/img/Technology/machine9.png" />
                                <div style="text-align: center; height: 35px; line-height: 35px;width:100%">
                                   多织带一体自动化机器
                                </div>
                            </div>

                            <div class="monthlyPublication">
                                <img style="width: 150px;height:130px;border-width:0" src="/Style/img/Technology/machine10.png" />
                                <div style="text-align: center; height: 35px; line-height: 35px;width:100%">
                                   电子平头锁眼机
                                </div>
                            </div>

                            <div class="monthlyPublication">
                                <img style="width: 150px;height:130px;border-width:0" src="/Style/img/Technology/machine11.png" />
                                <div style="text-align: center; height: 35px; line-height: 35px;width:100%">
                                   三头冲孔机
                                </div>
                            </div>
                               

                        </div>
                    </td>
                </tr>
            </table>
            <uc1:end runat="server" ID="end" />
        </center>
    </form>
</body>
</html>
