<%@ Page Language="C#" MasterPageFile="~/Admin/default.master" AutoEventWireup="true"
    CodeFile="Manager.aspx.cs" Inherits="Admin_Manager" Title="安全管理"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:GridView ID="GVManager" runat="server" AutoGenerateColumns="False" Width="602px"
        Font-Size="14pt" Height="149px" OnRowUpdating="GVManager_RowUpdating" 
        onrowdeleting="GVManager_RowDeleting" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="编号" />
            <asp:BoundField DataField="UserName" HeaderText="用户名" />
            <asp:ButtonField CommandName="Update" Text="修改密码" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button OnClientClick="return confirm('是否删除该用户？')
;" runat="server" Text="删除用户" CausesValidation="False" CommandName="Delete"/>
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
    <asp:Label ID="Label4" runat="server" Text="用     户     名：" Font-Names="14" Font-Size="14pt"></asp:Label>
    <asp:TextBox ID="U_Name" runat="server" Width="187px" MaxLength="10"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="U_Name" ErrorMessage="*"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label1" runat="server" Text="旧    密    码：" Font-Size="14pt"></asp:Label>
    <asp:TextBox ID="OldPWD" runat="server" Width="187px" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="新    密    码：" Font-Size="14pt"></asp:Label>
    <asp:TextBox ID="NewPWD1" runat="server" Width="187px" TextMode="Password" 
        MaxLength="10"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ErrorMessage="*" ControlToValidate="NewPWD1"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label3" runat="server" Text="新    密    码：" Font-Size="14pt"></asp:Label>
    <asp:TextBox ID="NewPWD2" runat="server" Width="187px" TextMode="Password" 
        MaxLength="10"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ControlToValidate="NewPWD2" ErrorMessage="*"></asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="NewPWD1"
        ControlToValidate="NewPWD2" ErrorMessage="两次密码输入不一致"></asp:CompareValidator>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Add" runat="server" Text="添加管理员" onclick="Add_Click" />
    <asp:Button ID="UpDate" runat="server" Text="确定" Width="94px" OnClick="UpDate_Click" />
    <asp:HiddenField ID="S_Id" runat="server" />
</asp:Content>
