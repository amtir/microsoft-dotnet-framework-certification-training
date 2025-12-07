<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IssueBook.aspx.cs" Inherits="LibraryWebApp.IssueBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Issue Book</h2>

    <table>
        <tr>
            <td>Student</td>
            <td>
                <asp:DropDownList ID="ddlStudent" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Publication</td>
            <td>
                <asp:DropDownList ID="ddlPublication" runat="server"
                    AutoPostBack="true"
                    OnSelectedIndexChanged="ddlPublication_SelectedIndexChanged" />
            </td>
        </tr>
        <tr>
            <td>Book</td>
            <td>
                <asp:DropDownList ID="ddlBook" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Due date (days from today)</td>
            <td>
                <asp:TextBox ID="txtDays" runat="server" Text="14" />
            </td>
        </tr>
    </table>

    <asp:Button ID="btnIssue" runat="server" Text="Issue Book"
        OnClick="btnIssue_Click" />
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>

    <br /><br />
<h3>Currently Issued Books</h3>

Filter by student:
<asp:DropDownList ID="ddlFilterStudent" runat="server"
    AutoPostBack="true"
    OnSelectedIndexChanged="ddlFilterStudent_SelectedIndexChanged" />
<br /><br />

<asp:GridView ID="gvIssued" runat="server" AutoGenerateColumns="True" />

</asp:Content>
