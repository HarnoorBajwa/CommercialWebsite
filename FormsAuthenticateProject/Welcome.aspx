<%@ Page Title="" Language="C#" MasterPageFile="~/Public.Master" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="FormsAuthenticateProject.Welcome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style1
    {
        font-size: xx-large;
        color: #333;
    }
    .content-container {
        text-align: center;
        margin: 50px auto;
        width: 60%;
        line-height: 1.6;
        font-size: large;
        color: #666;
    }
    .welcome-message {
        margin-bottom: 20px;
    }
    .button-container {
        margin-top: 30px;
    }
    .action-button {
        padding: 10px 20px;
        background-color: #007bff;
        color: white;
        text-decoration: none;
        border-radius: 5px;
        margin: 5px;
        display: inline-block;
    }
    .action-button:hover {
        background-color: #0056b3;
    }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-container">
        <h2 class="style1">Welcome to HeliSound Electronics</h2>
        
        <div class="welcome-message">
            Your trusted destination for premium home electronics. At HeliSound, we are dedicated to providing you with top-of-the-line Televisions, Home Theatres, and Speakers that deliver an unparalleled audio-visual experience. Explore our extensive collection of products designed to enhance your home entertainment.
        </div>

        <div class="button-container">
            <asp:LinkButton ID="lnkGoToLogin" runat="server" CssClass="action-button" PostBackUrl="~/Account/Login.aspx">Login to Your Account</asp:LinkButton>
            <asp:LinkButton ID="lnkGoToRegister" runat="server" CssClass="action-button" PostBackUrl="~/Account/Registration.aspx">Register a New Account</asp:LinkButton>
        </div>
    </div>
</asp:Content>
