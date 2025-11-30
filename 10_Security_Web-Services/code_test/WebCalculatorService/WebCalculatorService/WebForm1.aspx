<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebCalculatorService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator web Service Consumer Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Calculator web Service Consumer Demo</h1>

        Enter First number  <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox><br /><br />

        Enter Second number <asp:TextBox ID="txtSecond" runat="server"></asp:TextBox><br /><br />

        Select Operation<br />
        <asp:DropDownList ID="ddlOperation" runat="server">
            <asp:ListItem>Add</asp:ListItem>
            <asp:ListItem>Subtract</asp:ListItem>
            <asp:ListItem>Multiply</asp:ListItem>
            <asp:ListItem>Divide</asp:ListItem>
        </asp:DropDownList><br /><br />

        <asp:Button ID="btnSubmit" runat="server" Text="Submit"
            OnClick="btnSubmit_Click" /><br /><br />

        Result<br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </form>
</body>
</html>
