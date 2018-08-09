<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Winning.aspx.cs" Inherits="Goering.Web.About.Winning" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>
<%@ Register Src="~/Include/left.ascx" TagPrefix="uc1" TagName="left" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>获奖殊荣-荣诚集团</title>
    <meta name="Keywords" content="获奖殊荣,品牌人资大奖,广东省一级残疾人就业基地" />
    <meta name="Description" content="集团集中了行业管理、技术、研发、生产等各类高端精英人才，拥有SSE等多项技术专利，并获得ISO9001、ISO14001、OHSAS18001等品质、环境、职业安全体系认证。" />
    <link href="../Style/css/evervan.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <uc1:top runat="server" ID="top"  />
            <uc1:topImg runat="server" id="topImg" />
            <table style="width: 980px">
                <tr>
                    <td style="width: 263px; vertical-align: top;">
                        <uc1:left runat="server" id="left" />
                    </td>
                    <td class="middleWidth"></td>
                    <td style="vertical-align: top;">
                        <div style="height: 50px; border-bottom: solid 1px #9CB6EC;">
                            <div style="height: 50px; line-height: 50px; font-size: 16px; font-weight: bold; background-color: #4571D9; color: white; float: left;border-radius: 5px 5px 0px 0px;        ">
                                <span style="letter-spacing: 10px; padding: 0px 60px;">获奖殊荣</span>
                            </div>
                        </div>
                        <div style="height: 25px;">
                            <img src="../Style/img/dot.gif" />
                        </div>
                        <table style="width:100%">
                            <tr>
                                <td style="width:50%" ><img src="../Style/img/about/wing/wing1.png" /></td>
                                <td style ="padding:5px" >
                                    
                                        <div style="width:100%;text-align:center"> <span style="font-weight:bold;font-size:15px;">&ensp;2016&ensp;品牌人资大奖 </span> </div>
                                    <div style="line-height: 25px;font-size:15px;text-align:left">
                                        <p>集团企业以人为本、关爱员工、致力于打造快乐的工作环境与氛围。</p>
<p>我们荣诚集团在&ensp;2016&ensp;年&ensp;9&ensp;月底在&ensp;adidas&ensp;德国总部供应商峰会上获颁人资大奖&ensp;(&ensp;People Award&ensp;)&ensp;。</p>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td style ="padding:5px" >
                                    <div style="width:100%;text-align:center"> <span style="font-weight:bold;font-size:15px;">&ensp;2016&ensp;广东省一级残疾人就业基地</span> </div>
                                    <div style="line-height: 25px;font-size:15px;text-align:left">
                                        <p>
                                    按照政府相关要求，工厂招聘残疾员工数应按上年度平均在职职工总数的&ensp;1.5&ensp;%，即&ensp;5103*1.5%=77&ensp;人，实际上公司&ensp;2016&ensp;年共聘用残疾員工&ensp;113&ensp;人，並对员工工作、衣食住行等各方面进行全方位关怀。
</p>
                                    </div>
                                </td>
                                <td><img src="../Style/img/about/wing/wing2.png" /></td>
                            </tr>
                        </table>
                        <div style="line-height: 25px;font-size:15px;text-align:left">
                       <p>集团集中了行业管理、技术、研发、生产等各类高端精英人才，建立了“集优秀 人才、行现代管理、做一流产品、供优质服务”的现代企业四维立体发展空间，拥有SSE等多项技术专利，并获得&ensp;ISO9001&ensp;、&ensp;ISO14001&ensp;、&ensp;OHSAS18001&ensp;等品质、环境、职业安全体系认证。</p> 
                        </div>
                        
                        <table>
                            <tr>
                                <td><img src="../Style/img/about/wing/wing3.png"/></td>
                                <td><img src="../Style/img/about/wing/wing4.png"/></td>
                                <td><img src="../Style/img/about/wing/wing5.png"/></td>
                            </tr>
                        </table>
                        <div>
                            <img src="../Style/img/about_3.png" style="width: 100%" />
                        </div>

                    </td>
                </tr>
            </table>
            <uc1:end runat="server" ID="end" />
        </center>
    </form>
</body>
</html>
