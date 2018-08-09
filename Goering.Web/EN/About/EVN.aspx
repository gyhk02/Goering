<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EVN.aspx.cs" Inherits="Goering.Web.EN.About.EVN" %>

<%@ Register Src="~/EN/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/EN/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/EN/Include/about_left.ascx" TagPrefix="uc1" TagName="about_left" %>
<%@ Register Src="~/EN/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Evervan Qingyuan Footwear Co., Ltd.(EVN)-About Evervan</title>
    <meta name="Keywords" content="EVN,headquarter,Evervan Qingyuan Footwear Co., Ltd." />
    <meta name="Description" content="Evervan’s headquarter is located in Qingyuan City, Guangdong Province, near by the Beijiang River and Bijia Mountain. " />
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
                        <uc1:about_left runat="server" id="about_left" HighLightId="leftItemEVN" />
                    </td>
                    <td class="middleWidth"></td>
                    <td style="vertical-align: top;">
                        <div style="text-align:center;">
                            <img src="../Style/img/about/factory/evn.png" /></div>
                        <div style="height:5px;"><img src="../../Style/img/dot.gif" /></div>
<div style="line-height: 25px;font-size:14px;text-align:justify">
                            <p>
                                Evervan’s headquarter is located in Qingyuan City, Guangdong Province, near by the Beijiang River and Bijia Mountain. As a Sino-foreign joint venture, the company is the headquarter of Evervan Group. The establishment of EVN has created a new milestone for Evervan group. It was put into production in 2006, becoming an irreplaceable role for adidas. EVN has completed organization and system, the most advanced imported production equipment and development technical skills ability for footwear. The development technology department is equipped with advanced computer automated drafting, patterning and material usage calculation system, which helps us to produce the best sport shoes and win international awards.
                            </p>
    <div class="pSpacing"><img src="../../Style/img/dot.gif" /></div>                         
                            <p>
                                At present, EVN has been acquired the quality, environment and occupational health and safety systems’ certification of ISO9001, ISO14001, OHSAS18001, got AA Class Enterprise Inspection and Customs Advanced Certification of Guangdong Province as well. EVN became one of the 5C suppliers of adidas in SEA annual audit in 2012. Moreover, the first Golf production line and Outdoor ait. innovation Centre were set up in EVN in the same year.
                            </p>
    <div class="pSpacing"><img src="../../Style/img/dot.gif" /></div>                            
                           <div> 
                                Factory name：Evervan Qingyuan Footwear Co., Ltd. (EVN)<br />
                                Establishment time：Established in 2005, officially launched in 2006<br />
                                Production scale：Covering an area of 162,144 square meters, monthly output is 550,000 pairs,the number of employees is 6,000 and investment capital is $50 million<br />
                                Main products：adidas Outdoor、Golf、Training、Originals
                           </div>
                            <div style="height:35px;" ><img src="../../Style/img/dot.gif" /></div>
                            <div>
                                <div style="" >
                                    Factory address：No.16 Taihe Industrial Town, Qingxin Dist., Qingyuan City, Guangdong, China<br />
                                    Contact Number：+86-0763-6865858<br />
                                    Fax Number：+86-0763-5858585<br />
                                    Postal Code：511800
                                </div>
                            </div>
                        </div>
                        <div style="height:20px; clear:both;" ><img src="../../Style/img/dot.gif" /></div>
                        <table style="width:100%; margin:0px;" border="0">
                            <tr>
                                <td style="text-align:left;"><img src="../../Style/img/about/evn/evn_01.png" /></td>
                                <td style="text-align:center;"><img src="../../Style/img/about/evn/evn_02.png" /></td>
                                <td style="text-align:right;"><img src="../../Style/img/about/evn/evn_03.png" /></td>
                            </tr>
                            <tr>
                                <td style="text-align:left;" ><img src="../../Style/img/about/evn/evn_04.png" /></td>
                                <td style="text-align:center;" ><img src="../../Style/img/about/evn/evn_05.png" /></td>
                                <td style="text-align:right;" ><img src="../../Style/img/about/evn/evn_06.png" /></td>
                            </tr>
                        </table>
                        <div><img src="../../Style/img/about/evn/evn_07.png" style="width:100%;" /></div>
                    </td>
                </tr>
            </table>
            <uc1:end runat="server" id="end" />   
            </center>
    </form>
</body>
</html>