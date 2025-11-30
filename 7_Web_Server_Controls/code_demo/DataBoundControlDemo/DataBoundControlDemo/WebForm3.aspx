<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="DataBoundControlDemo.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FormView ID="FormView1" runat="server" OnPageIndexChanging="FormView1_PageIndexChanging" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both">
                <EditRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>Employee ID</td>
                            <td><%#Eval("Employee_Id") %></td>
                        </tr>
                        <tr>
                            <td>Name</td>
                            <td><%#Eval("Name") %></td>
                        </tr>
                        <tr>
                            <td>Location</td>
                            <td><%#Eval("Location") %></td>
                        </tr>
                    </table>
                </ItemTemplate>
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
            </asp:FormView>
        </div>
    </form>
</body>
</html>
