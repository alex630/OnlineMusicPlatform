<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OldMusic.aspx.cs" Inherits="OldMusic" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>-怀旧音乐-</title>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<meta name="Desciption" content="This web design site is a very good site with wonderful web design resources">
<meta name="keywords" content="This,web,design,site,is,a,very,good,site,with,wonderful,web,design,resources">
<link href="style/style.css" rel="stylesheet" type="text/css">
<style>
#left{  
float:left;
margin-left:20px;
width:650px;
height:700px;
border: solid 1px #000000;

  }

#right{ 
position:relative;
float:right;
width:320px;
height:700px;
border: solid 1px #000000;
  }
.STYLE2 {color: #FFFFFF}
</style>

</head>

<body>
    <form id="form1" runat="server">
    <div>
    
<center>
<div class="wrapper">
<div class="header">
<div style="float:left; margin-left:110px; margin-top:20px;">
<img src="images/logo.jpg" style="float:left;">
<div style="float:left;  text-align:left; font-family:tahoma; font-size:24pt; color:#636363; margin-left:5px;margin-top:5px;">
    在线<b>音乐</b><br><span style="float:left;  text-align:left; font-family:tahoma; font-size:8pt; color:#b1b1b1;"><b>
    &nbsp;On Line Music</b></span>
</div>

</div>

<div style="float:right; margin-right:30px; margin-top:50px; text-align:left; font-family:tahoma; font-size:17pt; color:#636363;">
    The Best <b> Music</b><br><span style="float:left;  text-align:left; font-family:tahoma; font-size:8pt; color:#b1b1b1;"><b>
    &nbsp;音乐在线共享平台</b></span>
</div>

</div>
<div class="menu">
<div class="menu-text" style="padding-left:140px;padding-right:50px;"><a href="Default.aspx"class="nav">
    首页</a></div>
<div class="menu-text"><a href="PopMusic.aspx"class="nav">流行音乐</a></div>
<div class="menu-text"><a href="RockMusic.aspx" class="nav">摇滚音乐</a></div>
<div class="menu-text" style="padding-right:30px;"><a href="OldMusic.aspx" class="nav">
    怀旧音乐</a></div>
<div class="menu-text"><a href="JazzMusic.aspx" class="nav">爵士音乐</a></div>

<%--<div style="float:right; padding-right:25px;padding-top:12px;">
<input type="image" src="images/go.jpg" />
</div>
<div style="float:right;padding-right:8px;padding-top:14px;">
<input style="border:none; height:18px;width:130px;" type="text" name="search_box" />
</div>--%>

</div>

<div class="first-section">
<div id="left">
  <p align="left"><img src="images/beijing3.jpg" width="646" height="37"></p>
  <p align="left">
      <asp:GridView ID="GV1" runat="server" AllowPaging="True" 
          AutoGenerateColumns="False" onpageindexchanging="GV1_PageIndexChanging" 
          CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="20" 
          Width="640px">
          <RowStyle Width="300px" BackColor="#EFF3FB" />
          <Columns>
              <asp:HyperLinkField DataTextField="MusicName" HeaderText="歌名">
                  <HeaderStyle HorizontalAlign="Center" />
                  <ItemStyle HorizontalAlign="Center" Width="50%" />
              </asp:HyperLinkField>
              <asp:HyperLinkField DataTextField="Name" HeaderText="歌手">
                  <HeaderStyle HorizontalAlign="Center" Width="30%" />
                  <ItemStyle HorizontalAlign="Center" Width="30%" />
              </asp:HyperLinkField>
              <asp:TemplateField>
                  <ItemTemplate>
                      <a href="#" 
                          onclick='window.open(&#039;playMusic.aspx?id=<%#Eval("Id")%>&#039;,&#039;&#039;,&#039;width=380,height=260&#039;);'>
                      <img alt="试听" border="0" height="16" src="images/ting.GIF" width="16" /> </a>
                  </ItemTemplate>
              </asp:TemplateField>
              <asp:TemplateField>
                  <ItemTemplate>
                      <a href="#" 
                          onclick='window.open(&#039;DownMusic.aspx?id=<%#Eval("Id")%>&#039;,&#039;&#039;,&#039;width=380,height=260&#039;);'>
                      <img alt="下载" border="0" height="16" src="images/down.gif" width="16" /> </a>
                  </ItemTemplate>
                  <ControlStyle Width="5%" />
              </asp:TemplateField>
          </Columns>
          <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
          <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
          <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
          <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
          <EditRowStyle BackColor="#2461BF" />
          <AlternatingRowStyle BackColor="White" />
      </asp:GridView>
                        </p>
</div>


<div id="right">
  <table width="322" height="606" border="0">
    <tr>
      <td height="336" align="left" valign="top"><p><img src="images/6.jpg" width="317" height="30"></p>
          <asp:GridView ID="GV5" runat="server" AutoGenerateColumns="False" 
              CellPadding="4" ForeColor="#333333" GridLines="None">
        <RowStyle Width="300px" BackColor="#EFF3FB" />
        <Columns>
            <asp:HyperLinkField DataTextField="MusicName" HeaderText="歌名">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" Width="65%" />
            </asp:HyperLinkField>
            <asp:HyperLinkField DataTextField="Name" HeaderText="歌手">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" Width="25%" />
            </asp:HyperLinkField>
            <asp:TemplateField>
                <ItemTemplate>
                    <a href="#" 
                        onclick='window.open(&#039;playMusic.aspx?id=<%#Eval("Id")%>&#039;,&#039;&#039;,&#039;width=380,height=260&#039;);'>
                    <img alt="试听" border="0" height="16" src="images/ting.GIF" width="16" /> </a>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <a href="#" 
                        onclick='window.open(&#039;DownMusic.aspx?id=<%#Eval("Id")%>&#039;,&#039;&#039;,&#039;width=380,height=260&#039;);'>
                    <img alt="下载" border="0" height="16" src="images/down.gif" width="16" /> </a>
                </ItemTemplate>
                <ControlStyle Width="5%" />
            </asp:TemplateField>
        </Columns>
              <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
              <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
              <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
              <EditRowStyle BackColor="#2461BF" />
              <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    </p></td>
    </tr>
    <tr>
      <td height="352" align="left" valign="top"><p><img src="images/gggg.gif" width="307" height="352"></p>
        </td>
    </tr>
  </table>
</div>
<br width="100%"/>
<div class="footer">
    Copyright 在线音乐 (c) 2013, 京备案第22222号 <a href="#">关于我们</a></div>
</div>

<map name="Map"><area shape="rect" coords="228,8,289,24" href="#"></map>
<map name="Map2"><area shape="rect" coords="217,7,290,27" href="#"></map>
<map name="Map3"><area shape="rect" coords="226,6,283,27" href="#"></map>
<map name="Map4"><area shape="rect" coords="226,8,289,29" href="#"></map>

    </div>
    </form>

</body>
</html>