<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="WebApplication1.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Sorry, Username or Password is wrong !!! 
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login Again" />
    </form>
</body>
</html>
