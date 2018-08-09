<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LabourUnion.aspx.cs" Inherits="Goering.Web.Responsibility.LabourUnion" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>工会互动-荣诚集团</title>
    <link href="../Style/css/evervan.css" rel="stylesheet" />
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
                    <td style="vertical-align: top;text-align:left">
                        <div style="height: 50px; border-bottom: solid 1px #9CB6EC;">
                            <div style="height: 50px; line-height: 50px; font-size: 16px; font-weight: bold; background-color: #4571D9; color: white; float: left; border-radius: 5px 5px 0px 0px;">
                                <span style="letter-spacing: 10px; padding: 0px 60px;">工会互动</span>
                            </div>
                        </div>

                        <div style="height: 10px;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                       <div style="width:100%;font-size:20px;font-weight:bold;text-align:left">工会换届选举</div>
                        <div style="line-height: 25px;font-size:14px;text-align:left">
                        <p>
                            2017&ensp;年&ensp;6&ensp;月&ensp;13&ensp;日&ensp;-&ensp;EVN&ensp;工会换届选举，本次工会换届选举邀请清远市清新区总工会 陈苑副主席到场见证整个换届选举的过程。经过民主、公开、公正之选举投票，恭喜袁飞虎先生 当选本届工会主席，李辉丽小姐当选本届工会副主席。
                        </p>
                            </div>
                        <img src="../Style/img/Responsibility/laber1.png" />
                        <div style="width:100%;font-size:20px;font-weight:bold;text-align:left;margin:20px 0 20px 0">员工代表选举</div>

                        <img src="../Style/img/Responsibility/laber2.png" />

                        <div style="width:100%;font-size:20px;font-weight:bold;text-align:left;margin:20px 0 20px 0">CBA&ensp;集体协商与谈判</div>
                        <div style="line-height: 25px;font-size:14px;text-align:left">
                        <p>
                        背景：广东省集体合同条例出台，本项目从&ensp;2015&ensp;年&ensp;6&ensp;月开始经理现场调查，&ensp;5&ensp;次培训，问卷调查，员工/管理层访谈，专案总结等环节，于&ensp;2016&ensp;年&ensp;8&ensp;月完成；
    通过本次学习，我司健全了员工代表团队，並针对住房公积金话题开展了集体协商，并取得了显著成果。
                            </p>
                            </div>
                        <img src="../Style/img/Responsibility/laber3.png" />
                    </td>
                </tr>
            </table>
            <uc1:end runat="server" ID="end" />
        </center>
    </form>
</body>
</html>
