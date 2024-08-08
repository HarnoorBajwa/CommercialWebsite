<%@ Page Title="Change Password" Language="C#" MasterPageFile="~/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="FormsAuthenticateProject.Customer.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .change-password {
            width: 50%;
            margin: 20px auto;
            text-align: left;
        }
        .change-password h2 {
            text-align: center;
        }
        .change-password label {
            display: block;
            margin-bottom: 5px;
        }
        .change-password input {
            width: 100%;
            margin-bottom: 15px;
            padding: 5px;
        }
        .change-password button {
            margin-top: 10px;
            width: 100%;
            padding: 10px;
        }
        .change-password .error-message {
            color: red;
            margin-bottom: 10px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="change-password">
        <h2>Change Password</h2>
        
        <asp:Label ID="lblError" runat="server" CssClass="error-message" Visible="False"></asp:Label>
        
        <label for="txtEmail">Email Address:</label>
        <asp:TextBox ID="txtEmail" runat="server" />

        <label for="ddlSecretQuestion">Secret Question:</label>
        <asp:DropDownList ID="ddlSecretQuestion" runat="server">
            <!-- Secret questions will be populated here -->
        </asp:DropDownList>

        <label for="txtSecretAnswer">Answer:</label>
        <asp:TextBox ID="txtSecretAnswer" runat="server" />

        <label for="txtNewPassword">New Password:</label>
        <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password" />

        <label for="txtConfirmPassword">Confirm New Password:</label>
        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" />

        <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" OnClick="btnChangePassword_Click" />
    </div>
</asp:Content>

