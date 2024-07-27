<%@ Page Title="User Maintenance" Language="C#" MasterPageFile="~/Administration/Admin.Master" AutoEventWireup="true" CodeBehind="UserMaintenance.aspx.cs" Inherits="FormsAuthenticateProject.Administration.UserMaintenance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .user-maintenance {
            width: 80%;
            margin: 20px auto;
            text-align: left;
        }
        .user-maintenance h2 {
            text-align: center;
            margin-bottom: 20px;
        }
        .user-form label {
            display: block;
            margin: 5px 0;
        }
        .user-form input, .user-form select {
            width: 100%;
            margin-bottom: 10px;
        }
        .user-form button {
            margin-top: 10px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="user-maintenance">
        <h2>User Maintenance</h2>
        
        <div class="user-form">
            <h3>Add or Edit User</h3>
            <label for="txtUsername">Username:</label>
            <asp:TextBox ID="txtUsername" runat="server" />

            <label for="txtFirstName">First Name:</label>
            <asp:TextBox ID="txtFirstName" runat="server" />

            <label for="txtLastName">Last Name:</label>
            <asp:TextBox ID="txtLastName" runat="server" />

            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" />

            <label for="ddlRole">Role:</label>
            <asp:DropDownList ID="ddlRole" runat="server">
                <asp:ListItem Text="Admin" Value="Admin"></asp:ListItem>
                <asp:ListItem Text="User" Value="User"></asp:ListItem>
            </asp:DropDownList>

            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        </div>

        <h3>User List</h3>
        <asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="False" DataKeyNames="UserID" OnRowEditing="gvUsers_RowEditing" OnRowDeleting="gvUsers_RowDeleting">
            <Columns>
                <asp:BoundField DataField="UserID" HeaderText="User ID" ReadOnly="True" />
                <asp:BoundField DataField="Username" HeaderText="Username" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Role" HeaderText="Role" />
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

