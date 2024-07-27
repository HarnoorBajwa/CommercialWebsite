<%@ Page Title="Reporting" Language="C#" MasterPageFile="~/Administration/Admin.Master" AutoEventWireup="true" CodeBehind="Reporting.aspx.cs" Inherits="FormsAuthenticateProject.Administration.Reporting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .reporting {
            width: 80%;
            margin: 20px auto;
            text-align: left;
        }
        .reporting h2 {
            text-align: center;
            margin-bottom: 20px;
        }
        .reporting .filters {
            margin-bottom: 20px;
        }
        .reporting .filters label {
            display: inline-block;
            margin-right: 10px;
        }
        .reporting .filters select, .reporting .filters input[type="date"] {
            margin-right: 10px;
        }
        .reporting .actions {
            margin-top: 20px;
        }
        .reporting .actions button {
            margin-right: 10px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="reporting">
        <h2>Reporting</h2>
        
        <div class="filters">
            <label for="ddlReportType">Report Type:</label>
            <asp:DropDownList ID="ddlReportType" runat="server">
                <asp:ListItem Text="Sales Report" Value="Sales"></asp:ListItem>
                <asp:ListItem Text="Inventory Report" Value="Inventory"></asp:ListItem>
                <asp:ListItem Text="Customer Report" Value="Customer"></asp:ListItem>
            </asp:DropDownList>

            <label for="txtStartDate">Start Date:</label>
            <asp:TextBox ID="txtStartDate" runat="server" TextMode="Date"></asp:TextBox>

            <label for="txtEndDate">End Date:</label>
            <asp:TextBox ID="txtEndDate" runat="server" TextMode="Date"></asp:TextBox>

            <asp:Button ID="btnGenerateReport" runat="server" Text="Generate Report" OnClick="btnGenerateReport_Click" />
        </div>

        <asp:GridView ID="gvReport" runat="server" AutoGenerateColumns="False">
            <Columns>
                <!-- Define columns as per the report data -->
            </Columns>
        </asp:GridView>

        <div class="actions">
            <asp:Button ID="btnExport" runat="server" Text="Export to Excel" OnClick="btnExport_Click" />
            <asp:Button ID="btnPrint" runat="server" Text="Print" OnClick="btnPrint_Click" />
        </div>
    </div>
</asp:Content>
