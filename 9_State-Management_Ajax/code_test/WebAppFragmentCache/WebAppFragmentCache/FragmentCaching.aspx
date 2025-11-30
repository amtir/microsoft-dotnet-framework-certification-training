<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FragmentCaching.aspx.cs" Inherits="WebAppFragmentCache.FragmentCaching" %>

<%@ Register src="FragmentCtrl1.ascx" tagname="FragmentCtrl1" tagprefix="uc1" %>
<%@ Register src="FragmentCtrl2.ascx" tagname="FragmentCtrl2" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <uc1:FragmentCtrl1 ID="FragmentCtrl11" runat="server" />
            <br />
            <br />
            <uc2:FragmentCtrl2 ID="FragmentCtrl21" runat="server" />
            <br />
        </div>
    </form>
</body>
</html>
