<%@ Page Title="View History" Language="C#" MasterPageFile="~/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="ViewHistory.aspx.cs" Inherits="FormsAuthenticateProject.Customer.ViewHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .history-table {
            width: 80%;
            margin: 20px auto;
            border-collapse: collapse;
        }
        .history-table th, .history-table td {
            border: 1px solid #ddd;
            padding: 8px;
        }
        .history-table th {
            background-color: #f2f2f2;
            text-align: left;
        }
        .history-table tr:hover {
            background-color: #f5f5f5;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="text-align:center">
    <h2>Your Order History</h2>
    <asp:GridView ID="gvOrderHistory" runat="server" CssClass="history-table" AutoGenerateColumns="False" EmptyDataText="No past orders found.">
        <Columns>
            <asp:BoundField DataField="OrderDate" HeaderText="Date of Invoice" DataFormatString="{0:yyyy-MM-dd}" />
            <asp:BoundField DataField="InvoiceNumber" HeaderText="Invoice Number" />
            <asp:BoundField DataField="TotalAmount" HeaderText="Total Amount" DataFormatString="{0:C}" />
            <asp:BoundField DataField="ShippedDate" HeaderText="Shipped Date" DataFormatString="{0:yyyy-MM-dd}" />
        </Columns>
    </asp:GridView>
</div>
</asp:Content>

