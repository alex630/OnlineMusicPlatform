<%@ Page Language="C#" MasterPageFile="~/Admin/default.master" AutoEventWireup="true"
    CodeFile="MusicStyle.aspx.cs" Inherits="Admin_MusicStyle" Title="STYLE MANAGERMENT" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Size="14pt" Text="STYLE："></asp:Label>
    <asp:TextBox ID="TB_Style" runat="server" Font-Size="14pt" MaxLength="10"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
        ControlToValidate="TB_Style"></asp:RequiredFieldValidator>
    <br />
    &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Add" runat="server" Text="ADD" OnClick="Add_Click" />
    <asp:Button ID="Update" runat="server" Text="UPDATE" OnClick="Update_Click" />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:GridView ID="GV_Style" runat="server" AutoGenerateColumns="False" Font-Size="12pt"
        OnRowDeleting="GV_Style_RowDeleting" 
    OnRowUpdating="GV_Style_RowUpdating" Width="544px"
        Style="margin-top: 0px" CellPadding="4" ForeColor="#333333" 
    GridLines="None">
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID" />
            <asp:BoundField DataField="Style" HeaderText="STYLE" />
            <asp:ButtonField CommandName="Update" Text="UPDATE" />

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button CommandName="Delete" OnClientClick="return confirm('Do you want to delete all?')
;" ID="Button1" runat="server" Text="DELETE" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <br />
    <asp:HiddenField ID="S_Id" runat="server" />
</asp:Content>
