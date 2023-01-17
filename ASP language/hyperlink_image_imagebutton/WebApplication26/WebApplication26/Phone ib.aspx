<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Phone ib.aspx.cs" Inherits="WebApplication26.Phone_ib" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/iphone 13 prop max.jpg" OnClick="ImageButton1_Click" ToolTip="this is image button" />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/1990.jpg" ToolTip="This is a image" />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/iphone13.jpg" ToolTip="This is a image" />
    </form>
    <p>
        Image 1 (this is image button not a image)</p>
</body>
</html>
