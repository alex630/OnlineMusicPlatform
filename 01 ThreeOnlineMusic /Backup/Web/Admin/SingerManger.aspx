<%@ Page Language="C#" MasterPageFile="~/Admin/default.master" AutoEventWireup="true"
    CodeFile="SingerManger.aspx.cs" Inherits="Admin_SingerManger" Title="歌手管理" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="Label1" runat="server" Text="歌手姓名："></asp:Label>
    <asp:TextBox ID="SingerName" runat="server" MaxLength="10"></asp:TextBox>
    <asp:RequiredFieldValidator
        ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" 
        ControlToValidate="SingerName"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label2" runat="server" Text="歌手性别："></asp:Label>
    <asp:DropDownList ID="SingerSex" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Add" runat="server" Text="插入" OnClick="Add_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Update" runat="server" Text="更新" OnClick="Update_Click" />
    <asp:GridView ID="GVSinger" runat="server" Font-Size="14pt" 
    AllowPaging="True" Width="540px"
        OnPageIndexChanging="GVSinger_PageIndexChanging" OnRowDeleting="GVSinger_RowDeleting"
        OnRowUpdating="GVSinger_RowUpdating" AutoGenerateColumns="False" 
    CellPadding="4" ForeColor="#333333" GridLines="None">
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="编号" />
            <asp:BoundField DataField="Name" HeaderText="姓名" />
            <asp:BoundField DataField="Sex" HeaderText="性别" />
            <asp:ButtonField CommandName="Update" Text="修改" />
            <%--<asp:ButtonField CommandName="Delete" Text="删除" />--%>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button CommandName="Delete" OnClientClick="return confirm('删除歌手同时会删除该歌手的所有歌曲，确定继续吗')
;" ID="Button1" runat="server" Text="删除"/>
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
