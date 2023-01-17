<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_page.aspx.cs" Inherits="Session_in_3_pages.user_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4>this is user page 1'st page</h4>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter no:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click" />
        </p>
    </form>
</body>
</html>
