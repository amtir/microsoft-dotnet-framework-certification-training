<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="LibraryWebApp.AddBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Book</h2>

    <table>
        <tr>
            <td>Book Name</td>
            <td><asp:TextBox ID="txtBookName" runat="server" /></td>
        </tr>
        <tr>
            <td>Details</td>
            <td><asp:TextBox ID="txtDetails" runat="server" TextMode="MultiLine" Rows="3" /></td>
        </tr>
        <tr>
            <td>Author</td>
            <td><asp:TextBox ID="txtAuthor" runat="server" /></td>
        </tr>
        <tr>
            <td>Publication</td>
            <td>
                <asp:DropDownList ID="ddlPublication" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Branch</td>
            <td>
                <asp:DropDownList ID="ddlBranch" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Price</td>
            <td><asp:TextBox ID="txtPrice" runat="server" /></td>
        </tr>
        <tr>
            <td>Quantity</td>
            <td><asp:TextBox ID="txtQty" runat="server" /></td>
        </tr>
    </table>

    <asp:Button ID="btnAddBook" runat="server" Text="Add Book"
        OnClick="btnAddBook_Click" />
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>

    <br /><br />

    <asp:GridView ID="gvBooks" runat="server" AutoGenerateColumns="True" />
</asp:Content>
