<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageButton.aspx.cs" Inherits="WebApplication26.ImageButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Car ib.aspx">car</asp:HyperLink>
        <p>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Phone ib.aspx">phone</asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/laptop ib.aspx">laptop</asp:HyperLink>
        </p>
    </form>
</body>
</html>
