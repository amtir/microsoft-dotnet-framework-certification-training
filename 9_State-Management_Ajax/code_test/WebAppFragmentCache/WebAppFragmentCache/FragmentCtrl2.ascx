<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FragmentCtrl2.ascx.cs" Inherits="WebAppFragmentCache.FragmentCtrl2" %>

<%@ OutputCache Duration="5" VaryByParam="none" VaryByControl="RadioButtonList1" %>

<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<br />
<asp:RadioButtonList ID="RadioButtonList1" runat="server">
    <asp:ListItem Selected="True" Value="yes">yes</asp:ListItem>
    <asp:ListItem>No</asp:ListItem>
    <asp:ListItem>Maybe</asp:ListItem>
</asp:RadioButtonList>

