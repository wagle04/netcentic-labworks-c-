<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" MasterPageFile="~/Site1.Master" Inherits="WebApplication1.login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <div>
            Username:
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            Password:<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />&nbsp;<asp:Button ID="Login1" runat="server" Text="Login" OnClick="Login1_Click" />
            <br />
            </div>

    </asp:Content>

