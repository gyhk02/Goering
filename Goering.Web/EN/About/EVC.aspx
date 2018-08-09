<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EVC.aspx.cs" Inherits="Goering.Web.EN.About.EVC" %>

<%@ Register Src="~/EN/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/EN/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/EN/Include/about_left.ascx" TagPrefix="uc1" TagName="about_left" %>
<%@ Register Src="~/EN/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Meng Da Footwear Industrial Co., Ltd.(EVC)-About Evervan</title>
    <meta name="Keywords" content="EVC,Meng Da Footwear Industrial Co., Ltd. " />
    <meta name="Description" content="Meng Da Footwear Industrial is located in the capital of Cambodia, Phnom Penh, which is around 5.6 km from the international airport." />
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
                        <uc1:about_left runat="server" id="about_left" HighLightId="leftItemEVC" />
                    </td>
                    <td class="middleWidth"></td>
                    <td style="vertical-align: top;">
                        <div style="text-align:center;">
                            <img src="../Style/img/about/factory/evc.png" /></div>
                        <div style="height:5px;"><img src="../../Style/img/dot.gif" /></div>
                        <div style="line-height: 25px;font-size:14px;text-align:justify">
    <div class="pSpacing"><img src="../../Style/img/dot.gif" /></div>   
                     <p >    
                             Meng Da Footwear Industrial is located in the capital of Cambodia, Phnom Penh, which is around 5.6 km from the international airport. With the advent of agility & globalized competition, the build-up of Meng Da has created a more solid oversea manufacturing base for the Group in the fiercer global economic environment. With the most price-competitive factory as well as another important production base in Group which strengthened Group's development flexibility and potential. Meng Da is a benchmark for Group’s expansion in Southeast Asia which greatly enhances group’s competiveness and profitability. 
                           </p>
                     <p >    
                             Currently there are 20 C2B production cells and approximately 4,000 workers. Factory is built on the basis of environment-friendly construction, which includes the green sunshade throughout the factory, sky light to light up, cooling system inside production floor, water recycling, solar energy equipment investment and so on. Meng Da is committed to creating a completely distinctive working environment with high efficiency & competitiveness. Human-oriented & sustainability are part of corporate philosophies. Creating a harmony environment platform where employees are able to pursue their career paths for self-development while balancing their living hood. Factory is also committed to social responsibility & worker care activities. In the long term unremitting effort, turnover rate was successfully controlled below 2.0%, far lower than neighborhood factories. And with the persisted in belief & cooperation of employees, Meng Da achieved first 4C adidas factory in Cambodia in 2015.  
                           </p>
                     <p >    
                             On the other hand, with the team efforts & collaboration with T2, even insufficient supply chain in Cambodia, Meng Da still successfully rolled out short lead time program and surrendered excellence result in 2016.  2017 June, in the race of 33 factories, Meng Da won the champion of adidas FACT evaluation. <span style="font-weight:bold;">VISION, WILLING, TEAM</span> creates our value.
                           </p>
                     <p >    
                             In order to sustain the continuous challenges of uprising labor cost as well as competitions, EVM & Meng Da collaboratively starts the initiative of <span style="font-weight:bold;">“FROM GOOD TO GREAT”</span> by integrating and reinventing since June 2016. Meng Da successfully moved in the 2nd category, Originals, and level up the product diversity & complexity. This is the turning point for Meng Da and we really proof all the possibility in Cambodia. 
                           </p>

                           <div > 
Company Name:  Meng Da Footwear Industrial Co., Ltd. (EVC)<br />
Establishment:  Founded in 2009 and start production in 2010.<br />
Complex Area: Area 55,000 square meters<br />
Product Diversity:  adidas YA & Originals<br />
Company Address: St.Veng Sreng Phoum Tropeang Thloeng, Sangkat Chorm Chao Khan Dangkor, Phnom Penh, Cambodia.

                           </div>
    <div style="height:35px;" ><img src="../../Style/img/dot.gif" /></div>
                        </div>
                        <table style="width:100%; margin:0px;" border="0">
                            <tr>
                                <td style="text-align:left;"><img src="../../Style/img/about/evc/evc_01.png" /></td>
                                <td style="text-align:center;"><img src="../../Style/img/about/evc/evc_02.png" /></td>
                                <td style="text-align:right;"><img src="../../Style/img/about/evc/evc_03.png" /></td>
                            </tr>
                            <tr>
                                <td style="text-align:left;" ><img src="../../Style/img/about/evc/evc_04.png" /></td>
                                <td style="text-align:center;" ><img src="../../Style/img/about/evc/evc_05.png" /></td>
                                <td style="text-align:right;" ><img src="../../Style/img/about/evc/evc_06.png" /></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <uc1:end runat="server" id="end" />      
            </center>
    </form>
</body>
</html>