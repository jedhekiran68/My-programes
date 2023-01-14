<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_val.aspx.cs" Inherits="validation._2_val" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 232px;
        }
        .auto-style3 {
            width: 193px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 232px;
            height: 26px;
        }
        .auto-style6 {
            width: 193px;
            height: 26px;
        }
        </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
        </div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">validation</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style5"></td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label1" runat="server" Text="enter email id:"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="enter email here" ForeColor="Red" BackColor="Aqua"></asp:RequiredFieldValidator>
            </td>
            <td>// this is&nbsp; Required Field Validator1</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Text="enter password:"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="enter password here" ForeColor="Red" SetFocusOnError="True" BackColor="Aqua"></asp:RequiredFieldValidator>
            </td>
            <td>// this is&nbsp; Required Field Validator2</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label3" runat="server" Text="enter mob no.:"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RangeValidator ID="RangeValidator1" runat="server" BackColor="#33CC33" ControlToValidate="TextBox3" ErrorMessage="no.should be 10 digits:" ForeColor="Red" MaximumValue="10" MinimumValue="10" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
            </td>
            <td>/ this is&nbsp;range Field Validator1</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label4" runat="server" Text="enter pincode.:"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RangeValidator ID="RangeValidator2" runat="server" BackColor="#6699FF" ControlToValidate="TextBox4" ErrorMessage="pincode must be 6 digit" ForeColor="Red" MaximumValue="6" MinimumValue="6" SetFocusOnError="True"></asp:RangeValidator>
            </td>
            <td>/ this is&nbsp;range Field Validator2</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" Text="enter password.:"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label6" runat="server" Text="confirm password.:"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:CompareValidator ID="CompareValidator1" runat="server" BackColor="#66FF66" ControlToCompare="TextBox5" ControlToValidate="TextBox6" ErrorMessage="password not match" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" Height="25px" Text="login" Width="118px" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>
