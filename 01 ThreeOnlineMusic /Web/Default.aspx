<%@ Page Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Default.aspx.cs"
    Inherits="_Default2" Title="-在线音乐-" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:GridView ID="GV1" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None">
        <RowStyle Width="300px" BackColor="#EFF3FB" />
        <Columns>
            <asp:HyperLinkField DataTextField="MusicName" HeaderText="Song">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle Width="65%" HorizontalAlign="Center" />
            </asp:HyperLinkField>
            <asp:HyperLinkField DataTextField="Name" HeaderText="Singer">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle Width="25%" HorizontalAlign="Center" />
            </asp:HyperLinkField>
            <asp:TemplateField>
                <ItemTemplate>
                    <a onclick="window.open('playMusic.aspx?id=<%#Eval("Id")%>','','width=380,height=260');" href="#">
                        <img border="0" src="images/ting.GIF" width="16" height="16" alt="试听"/>
                    </a>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
            <ItemTemplate>
                <a onclick="window.open('DownMusic.aspx?id=<%#Eval("Id")%>','','width=900,height=260');" href="#">                
                <img border="0" src="images/down.gif" width="16" height="16" alt="下载" />
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
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
    <asp:GridView ID="GV2" runat="server" AutoGenerateColumns="False" 
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
 
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="Server">
    <asp:GridView ID="GV3" runat="server" AutoGenerateColumns="False" 
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
 
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder5" runat="Server">
    <asp:GridView ID="GV4" runat="server" AutoGenerateColumns="False" 
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
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder6" runat="Server">
    <asp:GridView ID="GV5" runat="server" AutoGenerateColumns="False" 
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
</asp:Content>
