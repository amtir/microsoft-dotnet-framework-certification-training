<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationDemo1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Larger" ForeColor="#0000CC" Text="Label"></asp:Label>
        </div>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" style="margin-top: 0px"></asp:TextBox>
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="gender"/>
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="gender"/>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.edureka.co">GMAIL</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="https://www.yahoo.com">YAHOO</asp:HyperLink>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Lausanne</asp:ListItem>
            <asp:ListItem>Geneva</asp:ListItem>
            <asp:ListItem>Bern</asp:ListItem>
            <asp:ListItem>Zurich</asp:ListItem>
            <asp:ListItem>Paris</asp:ListItem>
            <asp:ListItem>London</asp:ListItem>
            <asp:ListItem>Milan</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
            <asp:ListItem Value="1">Red</asp:ListItem>
            <asp:ListItem Value="2">Blue</asp:ListItem>
            <asp:ListItem Value="3">Green</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label>
        <br />
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True">
            <asp:ListItem Value="1" Enabled="false">UG</asp:ListItem>
            <asp:ListItem Value="2">PG</asp:ListItem>
            <asp:ListItem Value="3">Doctorate</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True">
            <asp:ListItem Value="1">Lausanne</asp:ListItem>
            <asp:ListItem Value="2">Geneva</asp:ListItem>
            <asp:ListItem Value="3">Bern</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Label ID="Label5" runat="server"></asp:Label>
        <br />
        <br />
        <br />

        <div>
            <table class="style" align="center">
                <tr><td>
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#000099" Text="Payment Mode"></asp:Label>
                    </td></tr>
                <tr><td>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged">
            <asp:ListItem>Cash on Delivery</asp:ListItem>
            <asp:ListItem>Credit Card</asp:ListItem>
            <asp:ListItem>Debit Card</asp:ListItem>
            <asp:ListItem>Internet Banking</asp:ListItem>
        </asp:RadioButtonList>
                     </td></tr>
            <tr><td>
                <asp:Panel ID="Panel1" runat="server" Height="105px" Width="178px">
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" Height="16px" Width="170px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>PNB</asp:ListItem>
                        <asp:ListItem>SBI</asp:ListItem>
                        <asp:ListItem>CBI</asp:ListItem>
                        <asp:ListItem>BOI</asp:ListItem>
                        <asp:ListItem>ICICI</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </asp:Panel>
            
            </td></tr>
         </table>
            
        </div>
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Label ID="Label7" runat="server"></asp:Label>
        <br />
        <br />
        <fieldset>
            <legend>Educational Details</legend>
       
        <asp:CheckBox ID="CheckBox1" runat="server" Text="UG" />
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="PG" />
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="Doctorate" />
        </fieldset>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Get DateTime" OnClick="Button1_Click" />
    </form>
    </body>
</html>
