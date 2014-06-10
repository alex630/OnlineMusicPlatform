<%@ Page Language="C#" MasterPageFile="~/Admin/default.master" AutoEventWireup="true" CodeFile="AddMusic.aspx.cs" Inherits="Admin_AddMusic" Title="音乐上传" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    


    <br />
<br />
<br />
    


    <asp:Label ID="Label1" runat="server" Font-Size="14pt" Text="Upload Music："></asp:Label>
    <asp:FileUpload ID="UpLoadMusic" runat="server" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="UpLoadMusic" ErrorMessage="*"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Font-Size="14pt" Text="Upload Lyric："></asp:Label>
    <asp:FileUpload ID="LyricUpload" runat="server" />
    


    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="LyricUpload" ErrorMessage="*"></asp:RequiredFieldValidator>
    


<br />
<br />
<asp:Label ID="Label3" runat="server" Font-Size="14pt" Text="Singer："></asp:Label>
<asp:DropDownList ID="DpDSinger" runat="server">
</asp:DropDownList>
<br />
<br />
<asp:Label ID="Label4" runat="server" Font-Size="14pt" 
    Text="Music Style："></asp:Label>
<asp:DropDownList ID="DropDownList1" runat="server">
</asp:DropDownList>
<br />
<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Upload" onclick="Button1_Click" />
<br />
<br />
<br />
<br />
    


</asp:Content>

