<%@ Page Language="C#" MasterPageFile="~/List.master" AutoEventWireup="true" CodeFile="DownMusic.aspx.cs"
    Inherits="DownMusic" Title="Music Download" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Size="25px" Text="Song："></asp:Label>
    <asp:Label ID="M_FileName" runat="server" ForeColor="#3333CC" Font-Size="23px" 
        Font-Bold="True"></asp:Label>
    <br />
     <br />
      <br />
    
    <!-- Baidu Button BEGIN -->
    <div id="bdshare" class="bdshare_b" style="line-height: 12px;">
        <img src="http://bdimg.share.baidu.com/static/images/type-button-5.jpg?cdnversion=20120831" />
        <a class="shareCount"></a>
    </div>

    <script type="text/javascript" id="bdshare_js" data="type=button&amp;uid=6627698"></script>

    <script type="text/javascript" id="bdshell_js"></script>

    <script type="text/javascript">
        document.getElementById("bdshell_js").src = "http://bdimg.share.baidu.com/static/js/shell_v2.js?cdnversion=" + Math.ceil(new Date() / 3600000);
    </script>

    <!-- Baidu Button END -->
    
    
    <br />
    <br />
    <br />
    <a href="<%=MusicFilePath %>">
        <img src="images/DownFile.png" alt="下载" border="0" />
    </a>
    <br />
    <br />
    <br />
    <%--    写下我对这首歌的感受：--%>
    <br />
    <br />
    <%--  <IFRAME ID="eWebEditor1" SRC="ewebeditor/ewebeditor.htm?id=hid&style=coolblue" FRAMEBORDER="0" SCROLLING="no" WIDTH="550" HEIGHT="350"></IFRAME>
  <asp:HiddenField ID="hid" runat="server" />
   <br />
    

    <asp:Button ID="Button1" runat="server" Text="提交" />
--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
    <asp:GridView ID="GV5" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GV5_SelectedIndexChanged"
        CellPadding="4" ForeColor="#333333" GridLines="None">
        <RowStyle Width="300px" BackColor="#EFF3FB" />
        <Columns>
            <asp:HyperLinkField DataTextField="MusicName" HeaderText="Song">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" Width="65%" />
            </asp:HyperLinkField>
            <asp:HyperLinkField DataTextField="Name" HeaderText="Singer">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" Width="25%" />
            </asp:HyperLinkField>
            <asp:TemplateField>
                <ItemTemplate>
                    <a href="#" onclick='window.open(&#039;playMusic.aspx?id=<%#Eval("Id")%>&#039;,&#039;&#039;,&#039;width=380,height=260&#039;);'>
                        <img alt="试听" border="0" height="16" src="images/ting.GIF" width="16" />
                    </a>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <a href="#" onclick='window.open(&#039;DownMusic.aspx?id=<%#Eval("Id")%>&#039;,&#039;&#039;,&#039;width=380,height=260&#039;);'>
                        <img alt="下载" border="0" height="16" src="images/down.gif" width="16" />
                    </a>
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
</asp:Content>
