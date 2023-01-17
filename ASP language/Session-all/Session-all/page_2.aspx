<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page_2.aspx.cs" Inherits="Session_all.page_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4>this is a 2'nd page</h4>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/page3.aspx">page3</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" PostBackUrl="~/page3.aspx">page3</asp:LinkButton>
    </form>
</body>
</html>
