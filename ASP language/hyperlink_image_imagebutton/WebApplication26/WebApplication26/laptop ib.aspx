<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="laptop ib.aspx.cs" Inherits="WebApplication26.laptop_ib" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 277px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/ipad.jpg" OnClick="ImageButton1_Click" ToolTip="this is image button" />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/ipad1.jpg" ToolTip="This is a image" />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/ipad2.jpg" ToolTip="This is a image" />
        <p class="auto-style1">
            Image 1 (this is image button not a image)</p>
    </form>
</body>
</html>
