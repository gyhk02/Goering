<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="about_left.ascx.cs" Inherits="Goering.Web.EN.Include.about_left" %>
<style type="text/css">
    .leftItemSelectedByA { text-decoration: none; color: yellow; font-size: 18px; /*font-weight:bold;*/ }
    .leftItemSelectedByBgImg { background-image: url(<%=ResolveUrl("~/Style/img/YellowArrow.png")%>); background-position: center; background-repeat: no-repeat; width: 16px; }
    .leftItemDefaultByLink { text-decoration: none; color: white; font-size: 18px; }
</style>
<div id="divLeftTitle" style="height: 50px; line-height: 50px; font-size: 20px; font-weight: bold; background-color: #4571D9; color: white; border-radius: 5px 5px 0px 0px; text-align: center; width: 100%">
    <span id="spanLeftTitle" style="">About Evervan</span>
</div>
<div style="height: 660px; text-align: center; width: 263px; background-image: url('<%=ResolveUrl("~/Style/img/left.png")%>');">
    <div style="height: 35px;">
        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>" />
    </div>
    <div id="divLeft" style="text-align: left">
        <div style="height: 15px;">
            <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>">
        </div>
        <table>
            <tbody>
                <tr>
                    <td style="width: 10px;">&nbsp;</td>
                    <td style="height: 25px; line-height: 25px;"><a id="leftItemIntroduction" class="leftItemDefaultByLink" href="<%=ResolveUrl("~/EN/About/Introduction.aspx")%>">Intro of Evervan Group</a></td>
                    <td style="width: 3px; height: 25px; line-height: 25px;">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>"></td>
                    <td id="leftItemIntroductionBg" class="">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>" width="16">
                    </td>
                </tr>
            </tbody>
        </table>
        <div style="height: 1px;">
            <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>">
        </div>
        <table>
            <tbody>
                <tr>
                    <td style="width: 70px;">&nbsp;</td>
                    <td style="height: 25px; line-height: 25px;"><a id="leftItemEVN" class="leftItemDefaultByLink" href="<%=ResolveUrl("~/EN/About/EVN.aspx")%>">EVN</a></td>
                    <td style="width: 3px; height: 25px; line-height: 25px;">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>"></td>
                    <td class="" id="leftItemEVNBg">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>" width="16">
                    </td>
                </tr>
            </tbody>
        </table>
        <div style="height: 1px;">
            <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>">
        </div>
        <table>
            <tbody>
                <tr>
                    <td style="width: 70px;">&nbsp;</td>
                    <td style="height: 25px; line-height: 25px;"><a id="leftItemEVH" class="leftItemDefaultByLink" href="<%=ResolveUrl("~/EN/About/EVH.aspx")%>">EVH</a></td>
                    <td style="width: 3px; height: 25px; line-height: 25px;">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>"></td>
                    <td class="" id="leftItemEVHBg">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>" width="16">
                    </td>
                </tr>
            </tbody>
        </table>
        <div style="height: 1px;">
            <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>">
        </div>
        <table>
            <tbody>
                <tr>
                    <td style="width: 70px;">&nbsp;</td>
                    <td style="height: 25px; line-height: 25px;"><a id="leftItemEVL" class="leftItemDefaultByLink" href="<%=ResolveUrl("~/EN/About/EVL.aspx")%>">EVL</a></td>
                    <td style="width: 3px; height: 25px; line-height: 25px;">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>"></td>
                    <td class="" id="leftItemEVLBg">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>" width="16">
                    </td>
                </tr>
            </tbody>
        </table>
        <div style="height: 1px;">
            <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>">
        </div>
        <table>
            <tbody>
                <tr>
                    <td style="width: 70px;">&nbsp;</td>
                    <td style="height: 25px; line-height: 25px;"><a id="leftItemEVM" class="leftItemDefaultByLink" href="<%=ResolveUrl("~/EN/About/EVM.aspx")%>">EVM</a></td>
                    <td style="width: 3px; height: 25px; line-height: 25px;">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>"></td>
                    <td class="" id="leftItemEVMBg">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>" width="16">
                    </td>
                </tr>
            </tbody>
        </table>
        <div style="height: 1px;">
            <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>">
        </div>
        <table>
            <tbody>
                <tr>
                    <td style="width: 70px;">&nbsp;</td>
                    <td style="height: 25px; line-height: 25px;"><a id="leftItemEVC" class="leftItemDefaultByLink" href="<%=ResolveUrl("~/EN/About/EVC.aspx")%>">EVC</a></td>
                    <td style="width: 3px; height: 25px; line-height: 25px;">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>"></td>
                    <td class="" id="leftItemEVCBg">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>" width="16">
                    </td>
                </tr>
            </tbody>
        </table>
        <div style="height: 1px;">
            <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>">
        </div>
        <table>
            <tbody>
                <tr>
                    <td style="width: 70px;">&nbsp;</td>
                    <td style="height: 25px; line-height: 25px;"><a id="leftItemPRB" class="leftItemDefaultByLink" href="<%=ResolveUrl("~/EN/About/PRB.aspx")%>">PRB</a></td>
                    <td style="width: 3px; height: 25px; line-height: 25px;">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>"></td>
                    <td class="" id="leftItemPRBBg">
                        <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>" width="16">
                    </td>
                </tr>
            </tbody>
        </table>
        <div style="height: 15px;">
            <img src="<%=ResolveUrl("~/Style/img/dot.gif")%>">
        </div>
    </div>
</div>
<% if(!string.IsNullOrEmpty(HighLightId)) 
   {%>
<script type="text/javascript">
    document.getElementById("<%=HighLightId%>").className = "leftItemSelectedByA";
    document.getElementById("<%=HighLightId%>" + "Bg").className = "leftItemSelectedByBgImg";
</script>
<%} %>
