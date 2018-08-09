<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Culture.aspx.cs" Inherits="Goering.Web.About.Culture" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>企业文化-荣诚集团</title>
    <meta name="Keywords" content="企业文化,专业,热情,尊重,互信" />
    <meta name="Description" content="专业，热情，尊重，互信。" />
    <link href="../Style/css/evervan.css" rel="stylesheet" />
    <style type="text/css">
        .CultureTitle {
            margin-top: 30px; margin-left:2px;
        }
    </style>
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
                                <span style="letter-spacing: 10px; padding: 0px 60px;">企业文化</span>
                            </div>
                        </div>

                        <div style="margin: 10px 0px 0px 20px;font-size:14px">

                            <div class="CultureTitle">
                                <img src="../Style/img/about/about_01.png" />
                            </div>
                            <table style="width: 100%;">
                                <tr>
                                    <td style="width: 28px; height: 30px; background-image: url(../Style/img/about/about_00.png); background-position: center; background-repeat: no-repeat;">&nbsp;</td>
                                    <td>积极创造满足品牌多方需求，与产业竞争发展的实力。 </td>
                                </tr>
                                <tr>
                                    <td style="width: 28px; height: 30px; background-image: url(../Style/img/about/about_00.png); background-position: center; background-repeat: no-repeat;">&nbsp;</td>
                                    <td>注重检讨与分析，提升效益与品质，降低成本杜绝浪费，确保企业的竞争力。</td>
                                </tr>
                                <tr>
                                    <td style="width: 28px; height: 30px; background-image: url(../Style/img/about/about_00.png); background-position: center; background-repeat: no-repeat;">&nbsp;</td>
                                    <td>以职责来判断事情的轻重缓急，而非以职权；以执行力来贯彻任务，而非以口号。</td>
                                </tr>
                            </table>

                            <div class="CultureTitle">
                                <img src="../Style/img/about/about_02.png" />
                            </div>
                            <table style="width: 100%;">
                                <tr>
                                    <td style="width: 28px; height: 30px; background-image: url(../Style/img/about/about_00.png); background-position: center; background-repeat: no-repeat;">&nbsp;</td>
                                    <td>主动勇敢面对各种挑战，不找借口不抱怨，不达目的决不轻言放弃。</td>
                                </tr>
                                <tr>
                                    <td style="width: 28px; height: 30px; background-image: url(../Style/img/about/about_00.png); background-position: center; background-repeat: no-repeat;">&nbsp;</td>
                                    <td>在团队中尽心尽力，充分展现个人的存在价值，克尽职守以大我为先。</td>
                                </tr>
                                <tr>
                                    <td style="width: 28px; height: 30px; background-image: url(../Style/img/about/about_00.png); background-position: center; background-repeat: no-repeat;">&nbsp;</td>
                                    <td>追求团队成就，不强调个人英雄主义，不竣工不诿过，包容善解。</td>
                                </tr>
                            </table>

                            <div class="CultureTitle">
                                <img src="../Style/img/about/about_03.png" />
                            </div>
                           <table style="width: 100%;">
                                <tr>
                                    <td style="width: 28px; height: 30px; background-image: url(../Style/img/about/about_00.png); background-position: center; background-repeat: no-repeat;">&nbsp;</td>
                                    <td>在工作上努力奉献，与公司共荣共存，以身为集团的一份子为荣。</td>
                                </tr>
                                <tr>
                                    <td style="width: 28px; height: 30px; background-image: url(../Style/img/about/about_00.png); background-position: center; background-repeat: no-repeat;">&nbsp;</td>
                                    <td>敬重每一个人的职位和潜能，不轻视不批评，珍惜、聆听、鼓励、感激。</td>
                                </tr>
                                <tr>
                                    <td style="width: 28px; height: 30px; background-image: url(../Style/img/about/about_00.png); background-position: center; background-repeat: no-repeat;">&nbsp;</td>
                                    <td>行事要实事求是追根究底；修养要光明磊落感恩惜福，创造优质工作环境。</td>
                                </tr>
                            </table>

                            <div class="CultureTitle">
                                <img src="../Style/img/about/about_04.png" />
                            </div>
                            <table style="width: 100%;">
                                <tr>
                                    <td style="width: 28px; height: 30px; background-image: url(../Style/img/about/about_00.png); background-position: center; background-repeat: no-repeat;">&nbsp;</td>
                                    <td>对公司效忠，绝不做出伤害公司名誉和利益的决定和行为。</td>
                                </tr>
                                <tr>
                                    <td style="width: 28px; height: 30px; background-image: url(../Style/img/about/about_00.png); background-position: center; background-repeat: no-repeat;">&nbsp;</td>
                                    <td>摒弃个人本位想法承先启后，无私的为公司培育人才，厚植团队战力。</td>
                                </tr>
                                <tr>
                                    <td style="width: 28px; height: 30px; background-image: url(../Style/img/about/about_00.png); background-position: center; background-repeat: no-repeat;">&nbsp;</td>
                                    <td>待人诚恳处事坦诚，凡事以善念为先，建立互助互谅有同理心的最佳团队。</td>
                                </tr>
                            </table>
                            

                            <div class="CultureTitle">
                                <img src="../Style/img/about/about_05.png" />
                            </div>
                            <div style="line-height: 25px; width: 80%;">
                               <p> 这四项诉求，是荣诚集团创业至今不变的企业经营指标，经由时间和事实的证明，一个优秀的现代干部和领导者，更需同时具备上述的四大理念缺一不可，方能成为公司称职的一员，我们每一位成员也都应该以此为圭臬而自勉。</p>
                             <p>用人以品德才能为首要条件。企业的文化将以诚心务实为原则，并以「态度决定命运，细节决定成败」为信念，全力做好一个荣诚人的使命，同时也享受身为荣诚人的和光荣。</p>
                            </div>


                        </div>
                    </td>
                </tr>
            </table>
            <uc1:end runat="server" ID="end" />
        </center>
    </form>
</body>
</html>
