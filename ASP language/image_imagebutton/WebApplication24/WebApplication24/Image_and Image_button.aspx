<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Image_and Image_button.aspx.cs" Inherits="WebApplication24.Image_and_Image_button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="300px" ImageUrl="~/20230102054522_Sorento.jpg" OnClick="ImageButton1_Click" Width="400px" />
        <asp:ImageButton ID="ImageButton2" runat="server" Height="300px" ImageUrl="~/download (2).jpg" />
        <asp:ImageButton ID="ImageButton3" runat="server" Height="300px" ImageUrl="~/images.jpg" />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/download.jpg" />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/download (2).jpg" />
        <asp:Image ID="Image3" runat="server" ImageUrl="~/download (1).jpg" />
        <asp:Image ID="Image4" runat="server" Height="300px" ImageUrl="~/images (1).jpg" Width="300px" />
        <asp:Image ID="Image5" runat="server" ImageUrl="~/Mercedes-Benz-A-class-Hatchback-210920221745.jpg" />
    </form>
</body>
</html>
