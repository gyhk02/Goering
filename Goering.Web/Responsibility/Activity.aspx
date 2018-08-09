<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Activity.aspx.cs" Inherits="Goering.Web.Responsibility.Activity" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>公益活动-荣诚集团</title>
    <meta name="Keywords" content="公益活动,工会换届选举" />
    <meta name="Description" content="公益活动" />
    <link href="../Style/css/evervan.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <uc1:top runat="server" ID="top" />
            <uc1:topImg runat="server" id="topImg" />
            
            <table style="width: 980px">
                <tr>
                    <td style="width: 263px; vertical-align: top;">
                        <uc1:left runat="server" id="left" />
                    </td>
                    <td class="middleWidth"></td>
                    <td style="vertical-align: top;">
                        <div style="height: 50px; border-bottom: solid 1px #9CB6EC;">
                            <div style="height: 50px; line-height: 50px; font-size: 16px; font-weight: bold; background-color: #4571D9; color: white; float: left; border-radius: 5px 5px 0px 0px;">
                                <span style="letter-spacing: 10px; padding: 0px 60px;">公益活动</span>
                            </div>
                        </div>
                        <div style="height: 10px;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <div style="line-height: 35px; background-color:#EAF1FB; padding:5px;text-align:left;font-size:14px">
                            <div style="font-weight:bold">
                                
                                争做社会良好公民，支持公益事业：</div>
                            
<p>1、帮扶老人、扶助幼小：尊老爱幼是一种传统美德，为发扬这种传统美德，公司每年会组织员工志愿者前往福利院探望孤寡老人、孤儿院探望儿童，并为他们表演节目及带去爱心礼物。</p>
<p>2、帮扶贫困及残疾职工：每年&ensp;5&ensp;月份的&ensp;“&ensp;全国助残日&ensp;”&ensp;举办关爱残疾职工慰问活动，并为残疾职工送上慰问礼品。</p>
<p>3、帮扶山区学童：&ensp;“&ensp;以人为本&ensp;”&ensp;是荣诚集团的核心价值，我们我们致力于创造和谐快乐的工作环境与氛围，同时也关注附近社区之弱势群体。</p>

                             </div>
                        <div style="height: 10px;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <div>
                            <div style="width:100%;text-align:left;font-size:20px;font-weight:bold;margin-bottom:5px;margin-top:10px">帮扶老人、扶助幼小</div>
                            <img src="../Style/img/Responsibility/gongyi1.png" style="width: 700px" />

                            <div style="width:100%;text-align:left;font-size:20px;font-weight:bold;margin-bottom:5px;margin-top:10px">帮扶贫困及残疾职工</div>
                            <img src="../Style/img/Responsibility/gongyi2.png" style="width: 700px" />


                            <div style="width:100%;text-align:left;font-size:20px;font-weight:bold;margin-bottom:5px;margin-top:10px">帮扶山区学童</div>
                            <img src="../Style/img/Responsibility/gongyi3.png" style="width: 700px" />
                        </div>
                    </td>
                </tr>
            </table>
            <uc1:end runat="server" ID="end" />
        </center>
    </form>
</body>
</html>
