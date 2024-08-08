<%@ Page Title="Customer Home" Language="C#" MasterPageFile="~/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FormsAuthenticateProject.Customer._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .welcome-message {
            margin-top: 20px;
            font-size: 18px;
        }
        .feature-links {
            margin-top: 30px;
        }
        .feature-links a {
            display: inline-block;
            margin: 10px 20px;
            padding: 15px;
            border: 1px solid #ccc;
            text-decoration: none;
            color: #333;
            font-size: 16px;
            border-radius: 5px;
            transition: background-color 0.3s;
        }
        .feature-links a:hover {
            background-color: #f0f0f0;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center">
        <div class="welcome-message">
            <h2>Welcome to HeliSound Customer Portal</h2>
            <p>Explore our range of home electronics, manage your orders, and track your purchases all in one place.</p>
        </div>
        
        <div class="feature-links">
            <a href="OrderProducts.aspx">Order Products</a>
            <a href="OrderHistory.aspx">View Order History</a>
            <a href="TrackOrders.aspx">Track Orders</a>
            <a href="ChangePassword.aspx">Change Password</a>
        </div>
    </div>
</asp:Content>
