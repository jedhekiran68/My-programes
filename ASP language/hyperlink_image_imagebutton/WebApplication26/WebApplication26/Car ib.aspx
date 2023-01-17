<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Car ib.aspx.cs" Inherits="WebApplication26.Car_ib" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Mercedes-Benz-.jpg" OnClick="ImageButton1_Click" ToolTip="this is image button" />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Bucati.jpg" ToolTip="This is a image" />
        <asp:Image ID="Image2" runat="server" Height="254px" ImageUrl="~/Kia.jpg" ToolTip="This is a image" Width="335px" />
    </form>
    <p>
        Image 1 (this is image button not a image)</p>
</body>
</html>
