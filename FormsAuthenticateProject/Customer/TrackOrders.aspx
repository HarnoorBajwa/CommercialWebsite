<%@ Page Title="Track Orders" Language="C#" MasterPageFile="~/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="TrackOrders.aspx.cs" Inherits="FormsAuthenticateProject.Customer.TrackOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .order-form {
            width: 70%;
            margin: 20px auto;
            text-align: left;
        }
        .order-form label {
            display: block;
            margin-bottom: 5px;
        }
        .order-form input, .order-form select {
            width: 100%;
            margin-bottom: 10px;
            padding: 5px;
        }
        .order-form button {
            margin-top: 10px;
            width: 100%;
            padding: 10px;
        }
        .order-form .section {
            margin-bottom: 20px;
        }
        .order-form .error-message {
            color: red;
            margin-bottom: 10px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="order-form">
        <h2>Track Orders</h2>

        <asp:Label ID="lblError" runat="server" CssClass="error-message" Visible="False"></asp:Label>

        <div class="section">
            <h3>Order Information</h3>
            <label for="ddlOrderID">Order ID:</label>
            <asp:DropDownList ID="ddlOrderID" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlOrderID_SelectedIndexChanged">
                <asp:ListItem Text="Select an order" Value=""></asp:ListItem>
            </asp:DropDownList>
        </div>

        <div class="section">
            <h3>Order Details</h3>
            <asp:GridView ID="gvOrderDetails" runat="server" AutoGenerateColumns="True">
            </asp:GridView>
        </div>
    </div>
</asp:Content>
