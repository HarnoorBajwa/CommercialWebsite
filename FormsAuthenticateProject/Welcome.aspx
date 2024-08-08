<%@ Page Title="" Language="C#" MasterPageFile="~/Public.Master" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="FormsAuthenticateProject.Welcome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style1
    {
        font-size: xx-large;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style=" text-align:center">
     <span class="style1">Welcome
     <br />
     </span>
    <br />
    Normally this would be used to offer some marketing information related to your site. 
    <br />
    This page is just being used to pass to the login page 
     <br />
     <br />
    <asp:LinkButton ID="lnkGoToLogin" runat="server" 
        PostBackUrl="~/Account/Login.aspx">Go To Login</asp:LinkButton> 
</div>
</asp:Content>