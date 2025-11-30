<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebAppFormAuthenticationAuthorization.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 18px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            width: 167px;
        }
        .auto-style5 {
            height: 26px;
            width: 167px;
        }
    </style>
</head>
<body>
    <p class="auto-style1">
        <h4>Login Form</h4>
         <div>
    <form id="form1" runat="server">
       
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">User Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Remember Me" />
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" ForeColor="#CC0000"></asp:Label>
    </p>
               
        </div>
    </form>
</body>
</html>