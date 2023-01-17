<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="image_button.aspx.cs" Inherits="WebApplication25.image_button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/car.aspx">car</asp:HyperLink>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Mobile.aspx">phone</asp:HyperLink>
        </p>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/laptop.aspx">Laptop</asp:HyperLink>
    </form>
</body>
</html>
