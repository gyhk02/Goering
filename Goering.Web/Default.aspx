<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Goering.Web.Default" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=Edge" />
    <title>荣诚集团-首页</title>
    <meta name="Keywords" content="荣诚集团,关于荣诚,企业社会责任,荣诚月刊,人才招聘,EVN,EVH,EVL,EVM,EVC,PRB,诚展鞋厂,诚展,幸福荣诚" />
    <meta name="Description" content="荣诚集团是一个大型现代化跨国制鞋企业集团，专业从事国际知名品牌adidas运动鞋生产，集设计、研发、生产于一体。" />
    <link href="Style/css/evervan.css" rel="stylesheet" />
    <script type="text/javascript" src="Style/js/jquery.min.js"></script>
    <script src="Style/js/banner.js"></script>
    <link href="Style/css/banner.css" rel="stylesheet" />

    <style type="text/css">
        .monthlyPublication { margin: 0px 17px; float: left; width: 145px; text-align: center; }
        .img1 { width: 980px; height: 350px; margin: 0; }
        .overflow { text-overflow: ellipsis; white-space: nowrap; overflow: hidden; width: 490px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <uc1:top runat="server" ID="top" />
          <div style="clear:both"></div>  
                    <!--banner开始 -->
        <div id="banner" class="banner">
            <asp:Repeater ID="repFalsh" runat="server">
                <ItemTemplate>
                    <img alt=""  class="img1" src='<%#Eval("CN_URL").ToString()%>'
                        <%# Container.ItemIndex ==0? "": "style=\"display:none\"" %>/>
                </ItemTemplate>
            </asp:Repeater>
            <div id="jsNav" class="jsNav" runat="server">
                <div class="leftradio">
                </div>
                <div class="jsscroll">
                    <a id="prev" class="prevBtn" href="javascript:void(0)"></a><span id="spanTab" runat="server">
                    </span><a id="next" class="nextBtn" href="javascript:void(0)"></a>
                </div>
                <div class="rightradio">
                </div>
            </div>
        </div>
        <!--banner结束-->

       <%--集团简介开始--%>
            <div style="width:980px">
          <div style="height: 5px;">
                <img src="Style/img/dot.gif" />
            </div>
              <div style="height: 50px; border-bottom: solid 1px #9CB6EC;">
                <div style="height: 50px; line-height: 50px; font-size: 20px; font-weight: bold; background-color: #4571D9; color: white; float: left; border-radius: 5px 5px 0px 0px;">
                    <span style="letter-spacing: 10px; padding: 0px 60px;">集团简介</span>
                </div>
            </div>
            <div style="height: 5px;">
                <img src="Style/img/dot.gif" />
            </div>
            <table style="width: 100%;">
                <tr>
                    <td style="width: 421px; height:391px; vertical-align: top; text-align:left;
background-image:url('Style/img/index/factoryDistribution.png'); background-repeat:no-repeat; ">
                        <%--<img style="width: 421px;" src="Style/img/index/factoryDistribution.png" />--%>
                        <div style="height:80px;"><img src="Style/img/dot.gif" /></div>
                        <div style="height:20px; width:120px; margin-left:160px;"><a href="About/EVH.aspx" style="margin:0px; padding:0px;"><img style="height:20px; width:120px;" src="Style/img/dot.gif" /></a></div>
                        <div style="height:12px;"><img src="Style/img/dot.gif" /></div>
                        <div style="height:20px; width:120px; margin-left:180px;"><a href="About/EVL.aspx" style="margin:0px; padding:0px;"><img style="height:20px; width:120px;" src="Style/img/dot.gif" /></a></div>
                        <div style="height:12px;"><img src="Style/img/dot.gif" /></div>
                        <div style="height:20px; width:120px; margin-left:200px;"><a href="About/EVN.aspx" style="margin:0px; padding:0px;"><img style="height:20px; width:120px;" src="Style/img/dot.gif" /></a></div>
                        <div style="height:76px;"><img src="Style/img/dot.gif" /></div>
                        <div style="height:20px; width:120px; margin-left:145px;"><a href="About/EVM.aspx" style="margin:0px; padding:0px;"><img style="height:20px; width:120px;" src="Style/img/dot.gif" /></a></div>
                        <div style="height:16px;"><img src="Style/img/dot.gif" /></div>
                        <div style="height:20px; width:120px; margin-left:40px;"><a href="About/EVC.aspx" style="margin:0px; padding:0px;"><img style="height:20px; width:120px;" src="Style/img/dot.gif" /></a></div>
                        <div style="height:58px;"><img src="Style/img/dot.gif" /></div>                        
                        <div style="height:20px; width:120px; margin-left:155px;"><a href="About/PRB.aspx" style="margin:0px; padding:0px;"><img style="height:20px; width:120px;" src="Style/img/dot.gif" /></a></div>
                    </td>
                    <td style="vertical-align: top;text-align:left;line-height: 26px;font-size:14px">
                        <p >荣诚集团成立于&ensp;1991&ensp;年，创始人张荣梧先生&ensp;(&ensp;现任集团总裁兼董事局主席&ensp;)</p>
                            
                            <p >在以许执行长为核心的领导下，集团秉承&ensp;“&ensp;专业、热情、尊重、互信&ensp;”&ensp;的核心价值，全力打造&ensp;“&ensp;以人为本&ensp;”&ensp;的企业文化，坚守&ensp;“&ensp;品质、创新、速度&ensp;”&ensp;持续为客户和社会创造最大价值的使命，实施&ensp;“&ensp;深耕中国、放眼世界&ensp;”&ensp;的经营战略，致力于实现&ensp;“&ensp;成为世界级的精实工厂&ensp;”&ensp;的愿景。</p>
    
                            
                           <p >集团总部位于素有&ensp;“&ensp;广州后花园&ensp;”&ensp;之称的广东省清远市，座落在绿树婆娑芳香茵茵的北江之滨，山青水秀风光旖旎的笔架山下。专业从事国际知名品牌&ensp;adidas&ensp;运动鞋生产，集设计、研发、生产于一体，集团资金雄厚、设施配套、设备先进、技术一流、环境优美、生活舒适，是一个大型现代化跨国制鞋企业集团，
                               旗下拥有清远诚展鞋业有限公司、湖南衡阳得阳鞋业有限公司、常宁荣诚鞋业有限公司、越南鞋美鞋业有限公司、柬埔寨盟达鞋业有限公司和印度尼西亚策略联盟等等，&ensp;2007&ensp;年成功与印度尼西亚&ensp;Panarub&ensp;结成技术联盟，使集团经营灵活，竞争力强，抗风险性高，成为宝成、清禄之后的世界第三大跨国制鞋企业集团。</p>
                           
                    </td>
                </tr>
            </table>
                </div>
            <%--集团简介结束--%>
            <div>
                <img style="width: 980px;" src="Style/img/index/gardenFactory.png" />
            </div>
            <%--动态开始--%>
            <div style="width:980px">
            <div style="height: 3px;">
                <img src="Style/img/dot.gif" />
            </div>
            <div style="height: 50px; border-bottom: solid 1px #9CB6EC;">
                <div style="height: 50px; line-height: 50px; font-size: 20px; font-weight: bold; background-color: #4571D9; color: white; float: left; border-radius: 5px 5px 0px 0px;">
                    <span style="letter-spacing: 10px; padding: 0px 60px;">公司动态</span>
                </div>
                <div style="float: right; padding: 30px 0px 0px 0px;">
                    <a href="Index/DynamicList.aspx" class="aColorBlank">更多 >></a>
                </div>
            </div>
            <div style="height: 5px;">
                <img src="Style/img/dot.gif" />
            </div>
            
            <table style="width: 100%;">
                <tr>
                    <td style="vertical-align: top; background-color: #EAF1FB;">
                        <div style="margin: 0px 10px;">
                            <div style="height: 25px; clear: both;">
                                <img src="Style/img/dot.gif" />
                            </div>

                            <asp:Repeater ID="repNews" runat="server">
                                <ItemTemplate>
                                    <div>
                                        <div style="float: left;text-align:left" class="overflow"><img src="Style/img/index/resultset_next.png" /> <a href="Index/Dynamic.aspx?id=<%#Eval("CN_ID").ToString()%>" title="<%#Eval("CN_TITLE").ToString() %>" target="_blank" class="aColorBlank" style="font-size:14px"><%#Eval("CN_TITLE").ToString()%></a></div>
                                        <div style="float: right; color: #808080;font-size:14px"><%# DateTime.Parse( Eval("CN_CREATE_DATE").ToString()).ToString("yyyy-MM-dd")%></div>
                                    </div>
                                    <div style="height: 22px; clear: both;">
                                        <img src="Style/img/dot.gif" />
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>

                        </div>
                    </td>
                    <td style="width: 5px;">&nbsp;</td>
                    <td style="width: 342px; vertical-align: top;">
                        <img src="Style/img/index/companyDynamics.png" /></td>
                </tr>
            </table>
                </div>
            <%--动态结束--%>
            
            <div style="height: 1px; clear: both;">
                <img src="Style/img/dot.gif" />
            </div>
            <uc1:end runat="server" ID="end" />
        </center>
    </form>

</body>
</html>
