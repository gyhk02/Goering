<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Goering.Web.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="flashcontent"></div>
            <div id="video" style="position: relative; z-index: 100; width: 600px; height: 400px;">
                <div id="a1"></div>
                <div id="a2"></div>
                <div id="a3"></div>
            </div>
            <script type="text/javascript" src="Style/ckplayer/ckplayer.js" charset="UTF-8"></script>
            <script type="text/javascript">
                var flashvars = {
                    f: 'http://172.16.96.55/GSPAccessory/20150722041434109.mp4',
                    c: 0,
                    b: 1,
                    i: ''
                };
                var video = ['http://172.16.96.55/GSPAccessory/20150722041434109.mp4->video/mp4'];
                CKobject.embed('Style/ckplayer/ckplayer.swf', 'a1', 'ckplayer_a1', '600', '400', true, flashvars, video);


                var flashvars2 = {
                    f: 'http://172.16.96.55/GSPAccessory/20150721105327071.mp4',
                    c: 0,
                    b: 1,
                    i: ''
                };
                var video2 = ['http://172.16.96.55/GSPAccessory/20150721105327071.mp4->video/mp4'];
                CKobject.embed('Style/ckplayer/ckplayer.swf', 'a2', 'ckplayer_a1', '600', '400', false, flashvars2, video2);

                var flashvars3 = {
                    f: 'http://172.16.96.55/GSPAccessory/20150721105327071.mp4',
                    c: 0,
                    b: 1,
                    i: ''
                };
                var video3 = ['http://172.16.96.55/GSPAccessory/20150721105327071.mp4->video/mp4'];
                CKobject.embed('Style/ckplayer/ckplayer.swf', 'a3', 'ckplayer_a1', '600', '400', true, flashvars3, video3);
            </script>
        </div>
    </form>
</body>
</html>
