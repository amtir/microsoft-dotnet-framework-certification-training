<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="LibraryWebApp.StudentHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Student Home</h2>

    <p>
        Welcome,
        <asp:Label ID="lblStudentName" runat="server"></asp:Label>
    </p>

    <h3>My Library Summary</h3>

    <table border="1" cellpadding="5">
        <tr>
            <th>Item</th>
            <th>Value</th>
        </tr>
        <tr>
            <td>Books currently issued</td>
            <td><asp:Label ID="lblActiveLoans" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Total books borrowed</td>
            <td><asp:Label ID="lblTotalLoans" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Total penalty (all time)</td>
            <td><asp:Label ID="lblTotalPenalty" runat="server"></asp:Label></td>
        </tr>
    </table>
</asp:Content>
