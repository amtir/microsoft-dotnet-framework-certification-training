<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datacache1.aspx.cs" Inherits="WebAppCache.WebForm2" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeDBConnectionString %>" ProviderName="<%$ ConnectionStrings:EmployeeDBConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [employee]" EnableCaching="true" CacheDuration="60"></asp:SqlDataSource>
        <div>
        </div>
    </form>
</body>
</html>
