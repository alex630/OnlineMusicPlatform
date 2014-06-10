<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PlayMusic.aspx.cs" Inherits="PlayMusic" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>—播放歌曲—</title>

    <script type="text/javascript">
        swfobject.registerObject("FlashID");
    </script>

    <style type="text/css">
        #main{ text-align:center; width:900px; height:auto;}
        #Top{width: 900px;height: 44px;background-image: url(images/Bor_Top.png);text-align: center;size: 20px; padding-top:15px;}
        #Cen{ width:900px; height:400px; background-color:#336699;}
        #Bott{width:900px; height:400px; padding-top:0; margin:0;}
    </style>
</head>
<body style="text-align:center">
    <div id="main">
        <div id="Top">
            正在播放：<%=MusicFileName%>
        </div>
        <div id="Cen" style="background-color: #336699;">
            <object id="FlashID" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" height="400">
                <param name="movie" value="images/1.swf" />
                <param name="quality" value="high" />
                <param name="wmode" value="transparent" />
                <param name="swfversion" value="6.0.65.0" />
                <!-- 此 param 标签提示使用 Flash Player 6.0 r65 和更高版本的用户下载最新版本的 Flash Player。如果您不想让用户看到该提示，请将其删除。 -->
                <param name="expressinstall" value="Scripts/expressInstall.swf" />
                <!-- 下一个对象标签用于非 IE 浏览器。所以使用 IECC 将其从 IE 隐藏。 -->
                <!--[if !IE]>-->
                <object type="application/x-shockwave-flash" data="1.swf" height="400" style="width: 905px">
                    <!--<![endif]-->
                    <param name="quality" value="high" />
                    <param name="wmode" value="transparent" />
                    <param name="swfversion" value="6.0.65.0" />
                    <param name="expressinstall" value="Scripts/expressInstall.swf" />
                    <!-- 浏览器将以下替代内容显示给使用 Flash Player 6.0 和更低版本的用户。 -->
                    <div>
                        <h4>
                            此页面上的内容需要较新版本的 Adobe Flash Player。</h4>
                        <p>
                            <a href="http://www.adobe.com/go/getflashplayer">
                                <img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif"
                                    alt="获取 Adobe Flash Player" width="112" height="33" /></a></p>
                    </div>
                    <!--[if !IE]>-->
                </object>
                <!--<![endif]-->
            </object>
        </div>
        <form id="form1" runat="server">
        <div id="Bott">
            <object classid='clsid:6BF52A52-394A-11D3-B153-00C04F79FAA6' id='mediaPlayer' style="width:900px; height:44px;">
                <param name='url' value="<%=MusicFilePath %>" />
                <param name='volume' value='100' />
                <param name='playcount' value='100' />
                <param name='enablecontextmenu' value='0' />
                <param name='enableerrordialogs' value='0' />
                <embed width='900' height='360' src="<%=MusicFilePath%>" type="audio/x-pn-realaudio-plugin"
                controls="ImageWindow" autostart="true"></embed>
            </object>
        </div>
        </form>
    </div>
    
    
<!-- Baidu Button BEGIN -->
<script type="text/javascript" id="bdshare_js" data="type=slide&amp;img=7&amp;pos=right&amp;uid=6627698" ></script>
<script type="text/javascript" id="bdshell_js"></script>
<script type="text/javascript">
    document.getElementById("bdshell_js").src = "http://bdimg.share.baidu.com/static/js/shell_v2.js?cdnversion=" + Math.ceil(new Date() / 3600000);
</script>
<!-- Baidu Button END -->
</body>
</html>
