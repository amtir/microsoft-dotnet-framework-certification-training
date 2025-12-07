<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LibraryWebApp.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Library Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Library Management – Login</h2>

        Email:<br />
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br /><br />

        Password:<br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />

        <asp:Button ID="btnLogin" runat="server" Text="Login"
            OnClick="btnLogin_Click" /><br /><br />

        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
