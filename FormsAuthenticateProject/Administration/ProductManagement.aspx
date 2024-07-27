<%@ Page Title="Product Management" Language="C#" MasterPageFile="~/Administration/Admin.Master" AutoEventWireup="true" CodeBehind="ProductManagement.aspx.cs" Inherits="FormsAuthenticateProject.Administration.ProductManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .product-management {
            width: 80%;
            margin: 20px auto;
            text-align: left;
        }
        .product-management h2 {
            text-align: center;
            margin-bottom: 20px;
        }
        .product-form label {
            display: block;
            margin: 5px 0;
        }
        .product-form input, .product-form select {
            width: 100%;
            margin-bottom: 10px;
        }
        .product-form button {
            margin-top: 10px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="product-management">
        <h2>Product Management</h2>
        
        <div class="product-form">
            <h3>Add or Edit Product</h3>
            <label for="txtProductName">Product Name:</label>
            <asp:TextBox ID="txtProductName" runat="server" />

            <label for="ddlSupplier">Supplier:</label>
            <asp:DropDownList ID="ddlSupplier" runat="server" />

            <label for="ddlCategory">Category:</label>
            <asp:DropDownList ID="ddlCategory" runat="server" />

            <label for="txtPrice">Price:</label>
            <asp:TextBox ID="txtPrice" runat="server" TextMode="Number" />

            <label for="txtDescription">Description:</label>
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="4" />

            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        </div>

        <h3>Product List</h3>
        <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" OnRowEditing="gvProducts_RowEditing" OnRowDeleting="gvProducts_RowDeleting">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="Product ID" ReadOnly="True" />
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:BoundField DataField="SupplierName" HeaderText="Supplier" />
                <asp:BoundField DataField="CategoryName" HeaderText="Category" />
                <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:C}" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

