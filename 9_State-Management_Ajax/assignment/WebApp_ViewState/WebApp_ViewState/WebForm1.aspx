<%@ Page Language="C#"  EnableViewState="true" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp_ViewState.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 187px;
        }
    </style>
</head>
<body>
    <div>
        <h1>Viewstate</h1>
    </div>
    <div>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Enter your name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="SAVE" OnClick="Button1_Click" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="DISPLAY" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Data in Viewstate</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Number of postbacks</td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
        
        </div>
    </form>
</body>
</html>
