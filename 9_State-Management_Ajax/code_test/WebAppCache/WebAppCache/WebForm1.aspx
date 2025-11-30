<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppCache.WebForm1" %>

<%@ OutputCache Duration ="10" VaryByParam="p"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%= DateTime.Now.ToString() %>
            <a href ="?p=1">1</a>
            <a href ="?p=2">2</a>
            <a href ="?p=3">3</a>
        </div>
    </form>
</body>
</html>
