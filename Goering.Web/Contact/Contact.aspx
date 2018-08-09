<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Goering.Web.Contact.Contact" %>

<%@ Register Src="~/Include/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/Include/end.ascx" TagPrefix="uc1" TagName="end" %>
<%@ Register Src="~/Include/topImg.ascx" TagPrefix="uc1" TagName="topImg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>联系我们-荣诚集团</title>
    <link href="../Style/css/evervan.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div style="width:980px">
            <uc1:top runat="server" ID="top" />
            <uc1:topImg runat="server" ID="topImg" />

            <div style="height: 50px; border-bottom: solid 1px #9CB6EC;">
                <div style="height: 50px; line-height: 50px; font-size: 16px; font-weight: bold; background-color: #4571D9; color: white; float: left; border-radius: 5px 5px 0px 0px;">
                    <span style="letter-spacing: 10px; padding: 0px 60px;">联系我们</span>
                </div>
            </div>
            <div style="margin: 10px 50px;text-align:left">

                <div style="margin-top:20px;">
                    <div style="float: left;">
                        <div>
                            <img src="../Style/img/contact/evn.png" />
                        </div>
                        <div style="line-height: 25px; margin-top: 10px;">
                            诚展鞋业有限公司（EVN）--总部<br />
                            【电话】+86-0763-6865858<br />
                            【传真】+86-0763-5858585<br />
                            【邮编】511800<br />
                            【地址】清远市太和镇八片路16号
                        </div>
                    </div>
                    <div style="float: right;">
                        <div>
                            <img src="../Style/img/contact/evh.png" />
                        </div>
                        <div style="line-height: 25px; margin-top: 10px;">
                            衡阳市得阳鞋业有限公司（EVH）<br />
                            【电话】+86-0734-8571555<br />
                            【传真】+86-0734-8572555<br />
                            【邮编】421200<br />
                            【地址】湖南省衡阳市衡阳县西渡镇经济技术开发区联胜中路1号
                        </div>
                    </div>
                    
                </div>
                <div style="height: 1px; clear: both;">
                    <img src="../Style/img/dot.gif" />
                </div>

                <div style="margin-top:20px;">
                    <div style="float: left;">
                        <div>
                            <img src="../Style/img/contact/evl.png" />
                        </div>
                        <div style="line-height: 25px; margin-top: 10px;">
                            常宁荣诚鞋业有限公司（EVL）<br />
                            【电话】+86-0734-7652899<br />
                            【传真】<br />
                            【邮编】421500<br />
                            【地址】湖南省常宁市青阳北路青阳新区台资工业小区
                        </div>
                    </div>
                    <div style="float: right;">
                        <div>
                            <img src="../Style/img/contact/evm.png" />
                        </div>
                        <div style="line-height: 25px; margin-top: 10px;">
                            鞋美有限责任公司-西贡厂（EVM）<br />
                            【电话】+84-650-3746661<br />
                            【传真】+84-650-3746662<br />
                            【邮编】<br />
                            【地址】越南平阳省顺安县平准生产区
                        </div>
                    </div>
                </div>
                <div style="height: 1px; clear: both;">
                    <img src="../Style/img/dot.gif" />
                </div>

                <div style="margin-top:20px;">
                    
                    <div style="float: left;">
                        <div>
                            <img src="../Style/img/contact/evc.png" />
                        </div>
                        <div style="line-height: 25px; margin-top: 10px;">
                            柬埔寨盟达鞋业有限公司（EVC）<br />
                            【电话】+855-23969517<br />
                            【传真】+855-23969518<br />
                            【邮编】12000<br />
                            【地址】Street Veng Sreng,Phum Chorm Chao, Sangkat Chorm Chao,Khan Porsenchey,Phnom Penh,Cambodia
                        </div>
                    </div>
                </div>
                <div style="height: 1px; clear: both;">
                    <img src="../Style/img/dot.gif" />
                </div>



            </div>
            <uc1:end runat="server" ID="end" />
        </div>
            </center>
    </form>
</body>
</html>
