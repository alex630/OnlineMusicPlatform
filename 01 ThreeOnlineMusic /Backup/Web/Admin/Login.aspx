<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Admin_Login"
    EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后台管理系统登录</title>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312">
    <style>
        TD
        {
            font-size: 11px;
            color: #000000;
            font-family: Verdana, Arial, Helvetica, sans-serIf;
            text-decoration: none;
        }
        .input_1
        {
            border-right: #999999 1px solid;
            padding-right: 2px;
            border-top: #999999 1px solid;
            padding-left: 2px;
            list-style-position: inside;
            font-size: 12px;
            padding-bottom: 2px;
            margin-left: 10px;
            border-left: #999999 1px solid;
            color: #333333;
            padding-top: 2px;
            border-bottom: #999999 1px solid;
            font-family: Arial, Helvetica, sans-serIf;
            list-style-type: none;
            height: 18px;
            background-color: #dadedf;
        }
    </style>
    <meta content="MSHTML 6.00.6000.16705" name="GENERATOR">
</head>
<body>
    <form id="form1" runat="server">
    <table cellspacing="0" cellpadding="0" width="651" align="center" border="0">
        <tbody>
            <tr>
                <td height="50">
                </td>
            </tr>
            <tr>
                <td height="351">
                    <table cellspacing="0" cellpadding="0" width="100%" border="0">
                        <tbody>
                            <tr>
                                <td width="15" background="images/ileft.gif" height="43">
                                </td>
                                <td width="620" background="images/i_topbg2.gif">
                                    <img height="43" src="images/i_top1.gif" width="43">
                                </td>
                                <td width="16">
                                    <img height="43" src="images/iright.gif" width="16">
                                </td>
                            </tr>
                            <tr>
                                <td background="images/ileftbg.gif">
                                </td>
                                <td valign="center" background="images/bg.gif" height="279">
                                    <table height="109" cellspacing="0" cellpadding="0" width="369" align="center" border="0">
                                        <tbody>
                                            <tr>
                                                <td width="155">
                                                    <img height="140" src="images/logo.jpg" width="155" usemap="#Map" border="0">
                                                </td>
                                                <td valign="top" align="left" width="214">
                                                    <table cellspacing="0" cellpadding="0" width="167" border="0">
                                                        <tbody>
                                                            <tr>
                                                                <td valign="bottom" width="167" height="30">
                                                                    <a href="http://www.865171.cn/admin-templates/">
                                                                        <img height="19" src="images/adminsyteam.gif" width="154" border="0"></a>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td height="123">
                                                                    <table height="109" cellspacing="0" cellpadding="0" align="center" border="0">
                                                                        <form name="form2" action="method=post">
                                                                        <tr>
                                                                            <td valign="bottom" align="left" width="44" height="28">
                                                                                <div align="right">
                                                                                    <img height="14" src="images/id.gif" width="43">
                                                                                    </div>
                                                                            </td>
                                                                            <td height="20">
                                                                                <asp:TextBox ID="username" runat="server" Width="100px"></asp:TextBox>
                                                                                <asp:RequiredFieldValidator ID="User" runat="server" ErrorMessage="*" ControlToValidate="username"></asp:RequiredFieldValidator>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td align="left" height="20">
                                                                                <div align="right">
                                                                                    <img height="14" src="images/pass.gif" width="43"></div>
                                                                            </td>
                                                                            <td height="20">
                                                                                <asp:TextBox ID="password" runat="server" TextMode="Password" Width="100px"></asp:TextBox>
                                                                                <asp:RequiredFieldValidator ID="PWD" runat="server" ErrorMessage="*" ControlToValidate="password"></asp:RequiredFieldValidator>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td valign="center" colspan="2" height="25">
                                                                                <div align="center">
                                                                                    <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
                                                                                    <br />
                                                                                    <asp:ImageButton ID="login" runat="server" ImageUrl="images/b_login.gif" OnClick="login_Click" />
                                                                                    <asp:ImageButton ID="clean" runat="server" ImageUrl="images/b_clean.gif" OnClick="clean_Click" />
                                                                                </div>
                                                                            </td>
                                                                        </tr>
                                                                        </form>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                                <td background="images/irightbg.gif">
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <img height="29" src="images/i_bottom_left.gif" width="15">
                                </td>
                                <td background="images/i_bottom_bg.gif">
                                </td>
                                <td width="16">
                                    <img height="29" src="images/i_bottom_right.gif" width="16">
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>
            <tr>
                <td height="1">
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
            </tr>
        </tbody>
    </table>
    <map name="Map">
        <area shape="CIRCLE" target="_blank" coords="77,67,57" href="http://www.865171.cn/">
    </map>
    </form>
</body>
</html>
