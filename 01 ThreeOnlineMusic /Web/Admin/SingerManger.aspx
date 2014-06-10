<%@ Page Language="C#" MasterPageFile="~/Admin/default.master" AutoEventWireup="true"
    CodeFile="SingerManger.aspx.cs" Inherits="Admin_SingerManger" Title="SINGER MANAGERMENT" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="Label1" runat="server" Text="NAME："></asp:Label>
    <asp:TextBox ID="SingerName" runat="server" MaxLength="10"></asp:TextBox>
    <asp:RequiredFieldValidator
        ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" 
        ControlToValidate="SingerName"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label2" runat="server" Text="SEX："></asp:Label>
    <asp:DropDownList ID="SingerSex" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Add" runat="server" Text="INSERT" OnClick="Add_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Update" runat="server" Text="UPDATE" OnClick="Update_Click" />
    <asp:GridView ID="GVSinger" runat="server" Font-Size="14pt" 
    AllowPaging="True" Width="540px"
        OnPageIndexChanging="GVSinger_PageIndexChanging" OnRowDeleting="GVSinger_RowDeleting"
        OnRowUpdating="GVSinger_RowUpdating" AutoGenerateColumns="False" 
    CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GVSinger_SelectedIndexChanged">
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID" />
            <asp:BoundField DataField="Name" HeaderText="NAME" />
            <asp:BoundField DataField="Sex" HeaderText="SEX" />
            <asp:ButtonField CommandName="Update" Text="UPDATE" />
            <%--<asp:ButtonField CommandName="Delete" Text="DELETE" />--%>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button CommandName="Delete" OnClientClick="return confirm('Do you want to delete them all?')
;" ID="Button1" runat="server" Text="DELETE"/>
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
    <asp:HiddenField ID="S_Id" runat="server" />
</asp:Content>
