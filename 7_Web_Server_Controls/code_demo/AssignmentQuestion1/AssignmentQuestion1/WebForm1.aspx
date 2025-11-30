<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AssignmentQuestion1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 28px;
            width: 173px;
        }
        .auto-style3 {
            width: 173px;
        }
        .auto-style4 {
            height: 28px;
            width: 185px;
        }
        .auto-style5 {
            width: 185px;
        }
        .auto-style6 {
            width: 173px;
            height: 32px;
        }
        .auto-style7 {
            width: 185px;
            height: 32px;
        }
        .auto-style8 {
            height: 32px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Registration Page"></asp:Label>
            <br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="NAME"></asp:Label>
                    </td>
                    <td class="auto-style4">
            <asp:TextBox ID="txtName" runat="server" style="margin-left: 0px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
            <asp:Label ID="Label3" runat="server" Text="OCCUPATION"></asp:Label>
                    </td>
                    <td class="auto-style5">
            <asp:TextBox ID="txtOccupation" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
            <asp:Label ID="Label4" runat="server" Text="PHONENUMBER"></asp:Label>
                    </td>
                    <td class="auto-style5">
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
            <asp:Label ID="Label5" runat="server" Text="LOCATION"></asp:Label>
                    </td>
                    <td class="auto-style5">
            <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
            <asp:Button ID="btnInsert" runat="server" OnClick="Button1_Click" Text="INSERT" />
                    </td>
                    <td class="auto-style7">
            <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
                    </td>
                    <td class="auto-style8">
            <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" style="margin-left: 0px" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblMessage" runat="server" ForeColor="#006600"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
