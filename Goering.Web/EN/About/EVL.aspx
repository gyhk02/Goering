<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EVL.aspx.cs" Inherits="Goering.Web.EN.About.EVL" %>

<%@ Register Src="~/EN/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/EN/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/EN/Include/about_left.ascx" TagPrefix="uc1" TagName="about_left" %>
<%@ Register Src="~/EN/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Evervan Changning Footwear Co., Ltd(EVL)-About Evervan</title>
    <meta name="Keywords" content="EVL,Evervan Changning Footwear Co., Ltd" />
    <meta name="Description" content="Evervan Changning Footwear Co., Ltd is located in Changning City, which was known as “Homeland of Camellia oil” in Hunan Province." />
    <link href="../../Style/css/evervan.css" rel="stylesheet" />
    <style type="text/css">
        .pSpacing { height: 1px; }
    </style>
</head>
<body>
    <form id="form1">
        <center>
            <uc1:top runat="server" id="top" HighLightId="m2" />
            <uc1:topImg runat="server" id="topImg" />
            <div style="clear:both"></div>
            <table style="width: 980px;margin:0px">
                <tr>
                    <td style="width: 263px; vertical-align: top;">
                        <uc1:about_left runat="server" id="about_left" HighLightId="leftItemEVL" />
                    </td>
                    <td class="middleWidth"></td>
                    <td style="vertical-align: top;">
                        <div style="text-align:center;">
                            <img src="../Style/img/about/factory/evl.png" /></div>
                        <div style="height:5px;"><img src="../../Style/img/dot.gif" /></div>
<div style="line-height: 25px;font-size:14px;text-align:justify">

                            <p>
                              Evervan Changning Footwear Co., Ltd is located in Changning City, which was known as “Homeland of Camellia oil” in Hunan Province. EVL is a Taiwanese-invested enterprise and Changning government attracting investment key project for upper processing in September. Nowadays, EVL has more than 1,000 employees, 5 complete-set of the cutting lines and 15 stitching lines and monthly production up to 180,000 pairs of uppers. The production workshop is spacious and bright, in addition to all kinds of advanced production equipment, we also have safety equipment including ventilation installation, firefight system, water equipment and first-aid case, carrying out knowledge and skills training for employees. 
                            </p>
    <div class="pSpacing"><img src="../../Style/img/dot.gif" /></div>
                           <p>    
                               EVL insists on the enterprise culture of "people-oriented", pays attention to employees benefit, and commits to provide a high quality working and living environment for employees. Besides, EVL pursuit’s environmental protection and builds up the green security enterprise to achieve a win-win situation of economic and social benefits. EVL will make unremitting efforts to realize and create a better future with better quality products, higher capacity, more advanced management and team work cooperation.
                           </p>
                            <div class="pSpacing"><img src="../../Style/img/dot.gif" /></div>                            
                           <div> 
                            Industry Name：Evervan Changning footwear Co., Ltd. (EVL)<br />
                            Time of Established：Established in 2010<br />
                            Production Scale：Covers an area of 4500 square meters, totally has 1, 000 employees, produced up to 180,000 pairs of uppers, invest 1 million dollars<br />
                            Main Product：adidas uppers
                           </div>
                        <div style="height:35px;" ><img src="../../Style/img/dot.gif" /></div>
                        <div>
                            <div>
                                Address：Taiwanese industrial district, Qingyang district, Qingyang Road, Changning City,Hunan Province<br />
                                Contact Number：+86-0734-7652899<br />
                                Postal Code：421500
                            </div>
                        </div>
                        </div>
                        <div><img src="../../Style/img/about/evl/evl_01.png" style="width:100%;" /></div>
                    </td>
                </tr>
            </table>
            <uc1:end runat="server" id="end" />        
            </center>
    </form>
</body>
</html>