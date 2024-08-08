<%@ Page Title="Order Product" Language="C#" MasterPageFile="~/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="OrderProduct.aspx.cs" Inherits="FormsAuthenticateProject.Customer.OrderProduct" %>

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
        <h2>Order Product</h2>
        
        <asp:Label ID="lblError" runat="server" CssClass="error-message" Visible="False"></asp:Label>
        
        <div class="section">
            <h3>Select Product</h3>
            <label for="ddlSupplier">Supplier:</label>
            <asp:DropDownList ID="ddlSupplier" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSupplier_SelectedIndexChanged">
                <asp:ListItem Text="Select a supplier" Value=""></asp:ListItem>
                
            </asp:DropDownList>

            <label for="ddlCategory">Category:</label>
            <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
                <asp:ListItem Text="Select a category" Value=""></asp:ListItem>
                
            </asp:DropDownList>

            <label for="ddlProduct">Product:</label>
            <asp:DropDownList ID="ddlProduct" runat="server">
                <asp:ListItem Text="Select a product" Value=""></asp:ListItem>
                
            </asp:DropDownList>
        </div>

        <div class="section">
            <h3>Billing Information</h3>
            <label for="txtCardHolderName">Card Holder Name:</label>
            <asp:TextBox ID="txtCardHolderName" runat="server" />

            <label for="ddlCardType">Credit Card Type:</label>
            <asp:DropDownList ID="ddlCardType" runat="server">
                <asp:ListItem Text="Visa" Value="Visa"></asp:ListItem>
                <asp:ListItem Text="MasterCard" Value="MasterCard"></asp:ListItem>
                <asp:ListItem Text="American Express" Value="AmericanExpress"></asp:ListItem>
            </asp:DropDownList>

            <label for="txtCardNumber">Credit Card Number:</label>
            <asp:TextBox ID="txtCardNumber" runat="server" TextMode="Password" />

            <label for="txtSecurityCode">Security Code (CVV):</label>
            <asp:TextBox ID="txtSecurityCode" runat="server" TextMode="Password" />

            <label for="ddlExpiryMonth">Expiry Month:</label>
            <asp:DropDownList ID="ddlExpiryMonth" runat="server">
             
            </asp:DropDownList>

            <label for="ddlExpiryYear">Expiry Year:</label>
            <asp:DropDownList ID="ddlExpiryYear" runat="server">
               
            </asp:DropDownList>
        </div>

        <div class="section">
            <h3>Delivery Information</h3>
            <label for="txtHouseNumber">House Number:</label>
            <asp:TextBox ID="txtHouseNumber" runat="server" />

            <label for="txtStreet">Street Name and Designation:</label>
            <asp:TextBox ID="txtStreet" runat="server" />

            <label for="txtApartment">Apartment Unit Number (optional):</label>
            <asp:TextBox ID="txtApartment" runat="server" />

            <label for="txtCity">City:</label>
            <asp:TextBox ID="txtCity" runat="server" />

            <label for="txtProvince">Province:</label>
            <asp:TextBox ID="txtProvince" runat="server" />

            <label for="txtPostalCode">Postal Code:</label>
            <asp:TextBox ID="txtPostalCode" runat="server" />
        </div>

        <asp:Button ID="btnSaveOrder" runat="server" Text="Place Order" OnClick="btnSaveOrder_Click" />
    </div>
</asp:Content>
