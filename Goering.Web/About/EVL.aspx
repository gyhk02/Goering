<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EVL.aspx.cs" Inherits="Goering.Web.About.EVL" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>常宁市荣诚鞋业有限公司(EVL)-荣诚集团</title>
    <meta name="Keywords" content="EVL,常宁,常宁市荣诚鞋业有限公司" />
    <meta name="Description" content="常宁市荣诚鞋业有限公司 位于素有“油茶”之乡的湖南常宁市,是常宁市政府重点招商引资的一家台资企业，是荣诚集团在常宁投资的鞋面加工厂。" />
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
                            <img src="../Style/img/about/factory/evl.png" /></div>
                        <%--<div style="border-bottom: solid 1px #9CB6EC;""><img src="../Style/img/dot.gif" /></div>--%>
                        <div style="height:5px;"><img src="../Style/img/dot.gif" /></div>
<div style="line-height: 25px;font-size:14px;text-align:left">

                            <p >
                                <span style="font-size:18px; font-weight:bold;">常宁市荣诚鞋业有限公司</span>                                
                                位于素有“油茶”之乡的湖南常宁市,是常宁市政府重点招商引资的一家台资企业，是荣诚集团在常宁投资的鞋面加工厂。常宁荣诚的创立，不仅代表了荣诚是政府认同的企业，也代表政府对荣诚未来的高度关注与支持，曾接受过湖南省委副省长盛茂林、衡阳市委书记李亿农相继参访。
                            </p>
    <div class="pSpacing"><img src="../Style/img/dot.gif" /></div>
                           <p >    
                               常宁荣诚于&ensp;2010&ensp;年&ensp;7&ensp;月&ensp;14&ensp;日注册成立，并于&ensp;2010&ensp;年&ensp;9&ensp;月&ensp;3&ensp;日正式投产，现有职工人数&ensp;1,000&ensp;余人，配套完整的裁断线&ensp;5&ensp;条，针车线&ensp;15&ensp;条，月产量鞋面达&ensp;18&ensp;万双。公司生产车间宽敞明亮，除拥有先进的各项生产设备外，还配备了一流的配套设备，包括通风设备、消防设备、饮水设备以及紧急清洗站、急救箱等安全设备，并不定时对员工进行各项知识与技能培训。
                           </p>
    <div class="pSpacing"><img src="../Style/img/dot.gif" /></div>                            
                            <p >
                               公司秉承“以人为本”的企业文化，重视员工福利，致力于为员工提供高品质的工作与生活环境。公司正规经营，遵循国家法制，追求环保，将不断提升，以良好的经济效益，营造绿色安全企业，力求达到经济效益与社会效益的双赢。未来，公司将以更优的品质、更高的产能、更先进的管理，以荣诚集团人一直传承的团队合作精神，实现不断自我提升，为开创更美好的明天而不懈努力。
                            </p>
    <div class="pSpacing"><img src="../Style/img/dot.gif" /></div>                            
                           <div > 
工厂名称：常宁市荣诚鞋业有限公司（&ensp;简称&ensp;EVL&ensp;）<br />
创立时间：成立于&ensp;2010&ensp;年<br />
生产规模：占地面积&ensp;4,500&ensp;平方米；员工人数&ensp;1,000<br />
&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;月产能&ensp;18&ensp;万双；投资金额&ensp;100&ensp;万美金<br />
主要产品：adidas 鞋面
                           </div>
    <div style="height:35px;" ><img src="../Style/img/dot.gif" /></div>
    <div>
        <div>
工厂地址：湖南省常宁市青阳北路青阳新区台资工业小区<br />
联系电话：+86-0734-7652899<br />
邮政编码：421500
        </div>
    </div>
                        </div>
                        <div><img src="../Style/img/about/evl/evl_01.png" style="width:100%;" /></div>
                    </td>
                </tr>
            </table>
            <uc1:end runat="server" ID="end" />        
            </center>
    </form>
</body>
</html>
