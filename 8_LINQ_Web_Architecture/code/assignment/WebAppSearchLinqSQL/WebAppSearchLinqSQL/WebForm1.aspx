<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppSearchLinqSQL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 183px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>LINQ TO SQL</h2>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Student Roll No</td>
                    <td>
                        <asp:TextBox ID="txtRollNo" runat="server"></asp:TextBox>
                        <br />
                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                        <br />
                        </td>
                </tr>
                <tr>
                    <td class="auto-style2">Student Name </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Father&#39;s Name</td>
                    <td>
                        <asp:TextBox ID="txtFather" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Mother&#39;s Name</td>
                    <td>
                        <asp:TextBox ID="txtMother" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td><asp:Label ID="lblStatus" runat="server" ForeColor="Green" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
