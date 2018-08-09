<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EVH.aspx.cs" Inherits="Goering.Web.EN.About.EVH" %>

<%@ Register Src="~/EN/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/EN/Include/about_left.ascx" TagPrefix="uc1" TagName="about_left" %>
<%@ Register Src="~/EN/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/EN/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Deyang Footwear Co., Ltd.(EVH)-About Evervan</title>
    <meta name="Keywords" content="EVH,Deyang Footwear Co., Ltd." />
    <meta name="Description" content="Deyang Footwear Co., Ltd. is located in Xidu Economic Technological Development Zone of Hengyang City" />
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
                        <uc1:about_left runat="server" id="about_left" HighLightId="leftItemEVH" />
                    </td>
                    <td class="middleWidth"></td>
                    <td style="vertical-align: top;">
                        <div style="text-align:center;">
                            <img src="../Style/img/about/factory/evh.png" /></div>
                        <div style="height:5px;"><img src="../../Style/img/dot.gif" /></div>
<div style="line-height: 25px;font-size:14px;text-align:left">
                            <p>
                                Deyang Footwear Co., Ltd. is located in Xidu Economic Technological Development Zone of Hengyang City, it covers 250 mu with excellent location and geographic advantage. Since 2008, after the investment of EVV, order has increased gradually with positive performance. Evervan Group's profession in shoes manufacturing industry and insist on the long term strategy in mainland , later on EVH was formed and became an important milestone for Evervan Group .
                            </p>
    <div class="pSpacing"><img src="../../Style/img/dot.gif" /></div>
                           <p>    
                             EVH started to set up in January 2010 and officially launched in March 2011, totally has 3, 000 employees, an annual production of 4.5 million pairs of adidas finished shoes and the tax was nearly RMB13 million. It demonstrates good economic and social benefits, becoming largest production facility of Evervan Group in mainland. In 2012, EVH acquired the systems’ certification of ISO9001、ISO14001、OHSAS18001, EVH also got AA Class Enterprise Inspection and Top 10 Stars Companies of Hengyang.  
                           </p>
                            <div class="pSpacing"><img src="../../Style/img/dot.gif" /></div>                            
                           <div > 
                                Industry Name：Evervan Deyang footwear Co., Ltd. (EVH)<br />
                                Time of Established： Established in 2010, officially launched in 2011<br />
                                Production Scale：Covers an area of 130,000 square meters, totally has 3, 000 employees,
                                produced up to 450,000 pairs, invest 20 million dollars<br />
                                Main Product：adidas Original Training Outdoor Sport shoes
                           </div>
                            <div style="height:35px;" ><img src="../../Style/img/dot.gif" /></div>
                            <div>
                                <div>
                                    Factory address：No.1 Liansheng Road, xidu high-tech development zone, Hengyang, Hunan Province<br />
                                    Contact Number：+86-0734-8571555<br />
                                    Fax Number：+86-0734-8572555<br />
                                    Postal Code：421200
                                </div>
                            </div>
                        </div>

                        <table style="width:100%; margin:0px;" border="0">
                            <tr>
                                <td style="text-align:left;"><img src="../../Style/img/about/evh/evh_01.png" /></td>
                                <td style="text-align:center;"><img src="../../Style/img/about/evh/evh_02.png" /></td>
                                <td style="text-align:right;"><img src="../../Style/img/about/evh/evh_03.png" /></td>
                            </tr>
                            <tr>
                                <td style="text-align:left;" ><img src="../../Style/img/about/evh/evh_04.png" /></td>
                                <td style="text-align:center;" ><img src="../../Style/img/about/evh/evh_05.png" /></td>
                                <td style="text-align:right;" ><img src="../../Style/img/about/evh/evh_06.png" /></td>
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
