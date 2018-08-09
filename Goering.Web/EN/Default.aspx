<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Goering.Web.EN.Default" %>

<%@ Register Src="~/EN/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/EN/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Evervan Group-Homepage</title>
    <meta name="Keywords" content="Evervan Group,About Evervan,EVN,EVH,EVL,EVM,EVC,PRB" />
    <meta name="Description" content="Evervan Group is specialized in international sports brand footwear for adidas. We design, research, develop and produce for adidas shoes." />
    <link href="../Style/css/evervan.css" rel="stylesheet" />
    <script type="text/javascript" src="../Style/js/jquery.min.js"></script>
    <script src="../Style/js/banner.js"></script>
    <link href="../Style/css/banner.css" rel="stylesheet" />
    <style type="text/css">
        .monthlyPublication { margin: 0px 17px; float: left; width: 145px; text-align: center; }
        .img1 { width: 980px; height: 350px; margin: 0; }
        .pichide { display: none; }
    </style>
</head>
<body>
    <form id="form1">
        <center>
          <uc1:top runat="server" id="top" HighLightId="m1" />
          <div style="clear:both"></div>
            <!--banner开始 -->
          <div id="banner" class="banner">
              <img alt=""  class="img1" src='./upload/image_switch/1.jpg' />
              <img alt=""  class="img1 pichide" src='./upload/image_switch/2.jpg' />
              <img alt=""  class="img1 pichide" src='./upload/image_switch/3.jpg' />
              <img alt=""  class="img1 pichide" src='./upload/image_switch/4.jpg' />
              <img alt=""  class="img1 pichide" src='./upload/image_switch/5.jpg' />
            <div id="jsNav" class="jsNav">
                <div class="leftradio">
                </div>
                <div class="jsscroll">
                    <a id="prev" class="prevBtn" href="javascript:void(0)"></a><span id="spanTab"><a class="trigger imgSelected" href="javascript:void(0)">1</a><a class="trigger" href="javascript:void(0)">2</a><a class="trigger" href="javascript:void(0)">3</a><a class="trigger" href="javascript:void(0)">4</a><a class="trigger" href="javascript:void(0)">5</a></span><a id="next" class="nextBtn" href="javascript:void(0)"></a>
                </div>
                <div class="rightradio">
                </div>
            </div>
        </div>
        <!--banner结束-->
            <div style="width:980px">
          <div style="height: 5px;">
                <img src="../Style/img/dot.gif" />
            </div>
              <div style="height: 50px; border-bottom: solid 1px #9CB6EC;">
                <div style="height: 50px; line-height: 50px; font-size: 20px; font-weight: bold; background-color: #4571D9; color: white; float: left; border-radius: 5px 5px 0px 0px;">
                    <span style="padding: 0px 60px;">Introduction of Evervan Group</span>
                </div>
            </div>
            <div style="height: 5px;">
                <img src="../Style/img/dot.gif" />
            </div>
            <table style="width: 100%;">
                <tr>
                    <td style="width: 421px; height:391px; vertical-align: top; text-align:left;
background-image:url('Style/img/index/factoryDistribution.png'); background-repeat:no-repeat; ">
                        <div style="height:80px;"><img src="../Style/img/dot.gif" /></div>
                        <div style="height:20px; width:120px; margin-left:160px;"><a href="./About/EVH.aspx" style="margin:0px; padding:0px;"><img style="height:20px; width:120px;" src="../Style/img/dot.gif" /></a></div>
                        <div style="height:12px;"><img src="../Style/img/dot.gif" /></div>
                        <div style="height:20px; width:120px; margin-left:180px;"><a href="./About/EVL.aspx" style="margin:0px; padding:0px;"><img style="height:20px; width:120px;" src="../Style/img/dot.gif" /></a></div>
                        <div style="height:12px;"><img src="../Style/img/dot.gif" /></div>
                        <div style="height:20px; width:120px; margin-left:200px;"><a href="./About/EVN.aspx" style="margin:0px; padding:0px;"><img style="height:20px; width:120px;" src="../Style/img/dot.gif" /></a></div>
                        <div style="height:76px;"><img src="../Style/img/dot.gif" /></div>
                        <div style="height:20px; width:120px; margin-left:145px;"><a href="./About/EVM.aspx" style="margin:0px; padding:0px;"><img style="height:20px; width:120px;" src="../Style/img/dot.gif" /></a></div>
                        <div style="height:16px;"><img src="../Style/img/dot.gif" /></div>
                        <div style="height:20px; width:120px; margin-left:40px;"><a href="./About/EVC.aspx" style="margin:0px; padding:0px;"><img style="height:20px; width:120px;" src="../Style/img/dot.gif" /></a></div>
                        <div style="height:58px;"><img src="../Style/img/dot.gif" /></div>                        
                        <div style="height:20px; width:120px; margin-left:155px;"><a href="./About/PRB.aspx" style="margin:0px; padding:0px;"><img style="height:20px; width:120px;" src="../Style/img/dot.gif" /></a></div>
                    </td>
                    <td style="vertical-align: top;text-align:justify;line-height: 17px;font-size:14px">
                        <p >Evervan Group is founded in 1991 by Mr. Ron Chang (President and Chairman of the group).</p>
                            
                            <p >Under the leadership of CEO Mr. Jackson Hsiu, we adhere to the core values of “Expertise, Passion, Respect, and Trust” with the corporate culture of “People-oriented”. Our mission is to create maximum and sustainable value for our customer and society with “Quality, Speed, and Innovation”. The operation strategy is “cultivating China and having prospects for the world”. Our vision is to become a world-class Lean manufacturer.</p>
    
                            
                           <p >The hearquarter of Evervan Group is located in Qingyuan City, Guangdong Province, which is known as Guangzhou’s garden, near by the Beijiang River and Bijia Mountain. The Group is specialized in international sports brand footwear for adidas. We design, research, develop and produce for adidas shoes, and we have made smart investment, facilities, advanced equipment, first-class technology, beautiful environment, and comfortable life. We own Evervan Qingyuan Footwear Co., LTD. (EVN), Evervan Hengyang Footwear Co., Ltd. in Hunan Province (EVH), Evervan Changning Footwear Co., Ltd. in Hunan Province (EVL), Saigon Jim Brother’s Corp. in Vietnam (EVM), Meng Da Footwear Industrial Co., Ltd. in Cambodia (EVC). In 2007, Evervan has formed strategic alliance with Panarub, Indonesia, making us more competitive and stronger resistance to the high risks, and becoming the multinational footwear production group.</p>
                           
                    </td>
                </tr>
            </table>
                </div>
            <div>
                <img style="width: 980px;" src="../Style/img/index/gardenFactory.png" />
            </div>
            <div style="height: 1px; clear: both;">
                <img src="../Style/img/dot.gif" />
            </div>
            <uc1:end runat="server" id="end" />
        </center>
    </form>
</body>
</html>
