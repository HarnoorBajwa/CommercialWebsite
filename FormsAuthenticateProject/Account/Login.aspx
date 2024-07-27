<%@ Page Title="Login" Language="C#" MasterPageFile="~/Account/Account.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FormsAuthenticateProject.Account.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table width="100%">
            <tr>
                <td width="30%"></td>
                <td>
                    <table width="60%">
                        <tr>
                            <td style="text-align:right;">
                                <asp:Label ID="Label3" runat="server" Text="Username"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:right;">
                                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align:center;">
                                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align:center;">
                                <asp:LinkButton ID="lnkForgotPassword" runat="server" PostBackUrl="~/ForgotPassword.aspx">Forgot Password</asp:LinkButton> | 
                                <asp:LinkButton ID="lnkCreateProfile" runat="server" PostBackUrl="~/Account/Register.aspx">Create Account</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </td>
                <td width="30%"></td>
            </tr>
        </table>
    </div>
    <div style="text-align:center;">
        <asp:Label ID="lblMsg" runat="server" Text="" Visible="False" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
    </div>
</asp:Content>

