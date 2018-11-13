<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="database grid view.aspx.cs" Inherits="WebApplication1.database_grid_view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="10" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="5">
            <PagerSettings Mode="NumericFirstLast" />
            <PagerStyle BackColor="Pink" BorderColor="Red" BorderStyle="Dotted" BorderWidth="5px" />
        </asp:GridView>
    </form>
</body>
</html>
