<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page2.aspx.cs" Inherits="database_task.page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="id" DataSourceID="SqlDataSource1" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                <asp:BoundField DataField="mobile_no" HeaderText="mobile_no" SortExpression="mobile_no" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:database2ConnectionString %>" DeleteCommand="DELETE FROM [student] WHERE [id] = @original_id AND (([username] = @original_username) OR ([username] IS NULL AND @original_username IS NULL)) AND (([address] = @original_address) OR ([address] IS NULL AND @original_address IS NULL)) AND (([password] = @original_password) OR ([password] IS NULL AND @original_password IS NULL)) AND (([mobile_no] = @original_mobile_no) OR ([mobile_no] IS NULL AND @original_mobile_no IS NULL))" InsertCommand="INSERT INTO [student] ([username], [address], [password], [mobile_no]) VALUES (@username, @address, @password, @mobile_no)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [student]" UpdateCommand="UPDATE [student] SET [username] = @username, [address] = @address, [password] = @password, [mobile_no] = @mobile_no WHERE [id] = @original_id AND (([username] = @original_username) OR ([username] IS NULL AND @original_username IS NULL)) AND (([address] = @original_address) OR ([address] IS NULL AND @original_address IS NULL)) AND (([password] = @original_password) OR ([password] IS NULL AND @original_password IS NULL)) AND (([mobile_no] = @original_mobile_no) OR ([mobile_no] IS NULL AND @original_mobile_no IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_username" Type="String" />
                <asp:Parameter Name="original_address" Type="String" />
                <asp:Parameter Name="original_password" Type="String" />
                <asp:Parameter Name="original_mobile_no" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="username" Type="String" />
                <asp:Parameter Name="address" Type="String" />
                <asp:Parameter Name="password" Type="String" />
                <asp:Parameter Name="mobile_no" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="username" Type="String" />
                <asp:Parameter Name="address" Type="String" />
                <asp:Parameter Name="password" Type="String" />
                <asp:Parameter Name="mobile_no" Type="String" />
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_username" Type="String" />
                <asp:Parameter Name="original_address" Type="String" />
                <asp:Parameter Name="original_password" Type="String" />
                <asp:Parameter Name="original_mobile_no" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/page1.aspx">insert data</asp:LinkButton>
    </form>
</body>
</html>
