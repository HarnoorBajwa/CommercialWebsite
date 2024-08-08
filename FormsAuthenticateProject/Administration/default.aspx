<%@ Page Title="Admin Home" Language="C#" MasterPageFile="~/Administration/Admin.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FormsAuthenticateProject.Administration._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .admin-dashboard {
            margin: 20px auto;
            width: 80%;
            text-align: center;
        }
        .admin-dashboard h2 {
            margin-bottom: 20px;
        }
        .admin-dashboard .section {
            margin: 15px 0;
        }
        .admin-dashboard .section a {
            font-size: 16px;
            color: #007bff;
            text-decoration: none;
        }
        .admin-dashboard .section a:hover {
            text-decoration: underline;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="admin-dashboard">
        <h2>Welcome to the Admin Dashboard</h2>
        <p>Use the links below to manage various aspects of the system.</p>

        <div class="section">
            <h3><a href="ManageProducts.aspx">Manage Products</a></h3>
            <p>Add, edit, and delete products.</p>
        </div>

        <div class="section">
            <h3><a href="UserMaintenance.aspx">Manage Users</a></h3>
            <p>Maintain user accounts and roles.</p>
        </div>

        <div class="section">
            <h3><a href="Reporting.aspx">Reporting</a></h3>
            <p>View system reports.</p>
        </div>
    </div>
</asp:Content>
