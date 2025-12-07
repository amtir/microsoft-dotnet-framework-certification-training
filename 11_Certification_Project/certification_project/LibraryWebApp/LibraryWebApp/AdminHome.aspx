<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="LibraryWebApp.AdminHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Admin Home</h2>

    <p>
        Welcome,
        <asp:Label ID="lblAdminName" runat="server"></asp:Label>
    </p>

    <h3>Library Summary</h3>

    <table border="1" cellpadding="5">
        <tr>
            <th>Item</th>
            <th>Count</th>
        </tr>
        <tr>
            <td>Total Branches</td>
            <td><asp:Label ID="lblBranchCount" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Total Publications</td>
            <td><asp:Label ID="lblPubCount" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Total Books</td>
            <td><asp:Label ID="lblBookCount" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Total Students</td>
            <td><asp:Label ID="lblStudentCount" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Books Issued (Active)</td>
            <td><asp:Label ID="lblIssuedCount" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Overdue Books</td>
            <td><asp:Label ID="lblOverdueCount" runat="server"></asp:Label></td>
        </tr>
    </table>
</asp:Content>
