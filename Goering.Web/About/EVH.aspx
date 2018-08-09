<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EVH.aspx.cs" Inherits="Goering.Web.About.EVH" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>得阳鞋业有限公司(EVH)-荣诚集团</title>
    <meta name="Keywords" content="EVH,得阳,衡阳市得阳鞋业有限公司" />
    <meta name="Description" content="衡阳市得阳鞋业有限公司位于素有“雁城”之称的湖南衡阳，坐落于衡阳县西渡高新经济技术开发区，占地250亩，具有得天独厚的区位和地理优势。" />
    <link href="../Style/css/evervan.css" rel="stylesheet" />
    <style type="text/css">
        .pSpacing {
            height: 1px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <uc1:top runat="server" ID="top" />
            <uc1:topImg runat="server" id="topImg" />
            <div style="clear:both"></div>
            <table style="width: 980px;margin:0px">
                <tr>
                    <td style="width: 263px; vertical-align: top;">
                        <uc1:left runat="server" id="left" />
                    </td>
                    <td class="middleWidth"></td>
                    <td style="vertical-align: top;">
                        <div style="text-align:center;">
                            <img src="../Style/img/about/factory/evh.png" /></div>
                        <%--<div style="border-bottom: solid 1px #9CB6EC;""><img src="../Style/img/dot.gif" /></div>--%>
                        <div style="height:5px;"><img src="../Style/img/dot.gif" /></div>
<div style="line-height: 25px;font-size:14px;text-align:left">

                            <p >
                                <span style="font-size:18px; font-weight:bold;">衡阳市得阳鞋业有限公司</span>                                
                                位于素有“雁城”之称的湖南衡阳，坐落于衡阳县西渡高新经济技术开发区，占地250亩，具有得天独厚的区位和地理优势。自&ensp;2008&ensp;年荣诚集团投产湖南荣阳（&ensp;EVV&ensp;）以来，订单持续增长，并取得良好的经营业绩，集团本着对行业的熟悉与了解，坚持立足中国境内长久发展的策略，相继成立了衡阳市得阳鞋业有限公司，得阳的创建标志着集团在内陆的发展又树立了一个新的里程碑。
                            </p>
    <div class="pSpacing"><img src="../Style/img/dot.gif" /></div>
                           <p >    
                               得阳鞋业有限公司于&ensp;2010&ensp;年&ensp;1&ensp;月开始动工建设，2011&ensp;年&ensp;3&ensp;月投入生产，现有职工&ensp;3,000&ensp;人，年产&ensp;450&ensp;万双&ensp;adidas&ensp;成品鞋，创税近&ensp;1,300&ensp;万元。现已展现了良好的经济、社会效益，成为荣诚集团在内陆最大生产基地。2012&ensp;年，衡阳市得阳鞋业有限公司荣获&ensp;“&ensp;衡阳县十佳明星企业&ensp;”、“&ensp;A&ensp;类海关企业&ensp;”；通过了&ensp;ISO9001、ISO14001、OHSAS18001&ensp;体系认证。
                           </p>
    <div class="pSpacing"><img src="../Style/img/dot.gif" /></div>                            
                           <div > 
工厂名称：衡阳市得阳鞋业有限公司（&ensp;简称&ensp;EVH&ensp;）<br />
创立时间：成立于&ensp;2010&ensp;年，2011&ensp;年正式投产<br />
生产规模：占地面积&ensp;130,000&ensp;平方米；最大月产能&ensp;45&ensp;万双<br />
          员工人数&ensp;3,000；投资金额&ensp;2,000&ensp;万美金<br />
主要产品：adidas Original & Training & Outdoor&ensp;运动鞋
                           </div>
    <div style="height:35px;" ><img src="../Style/img/dot.gif" /></div>
    <div>
        <div>
工厂地址：湖南省衡阳县西渡高新经济技术开发区联胜中路一号<br />
联系电话：+86-0734-8571555<br />
传真号码：+86-0734-8572555<br />
邮政编码：421200
        </div>
    </div>
                        </div>

                        <table style="width:100%; margin:0px;" border="0">
                            <tr>
                                <td style="text-align:left;"><img src="../Style/img/about/evh/evh_01.png" />                                </td>
                                <td style="text-align:center;"><img src="../Style/img/about/evh/evh_02.png" /></td>
                                <td style="text-align:right;"><img src="../Style/img/about/evh/evh_03.png" /></td>
                            </tr>
                            <tr>
                                <td style="text-align:left;" ><img src="../Style/img/about/evh/evh_04.png" />                                </td>
                                <td style="text-align:center;" ><img src="../Style/img/about/evh/evh_05.png" /></td>
                                <td style="text-align:right;" ><img src="../Style/img/about/evh/evh_06.png" /></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <uc1:end runat="server" ID="end" />        
            </center>
    </form>
</body>
</html>
