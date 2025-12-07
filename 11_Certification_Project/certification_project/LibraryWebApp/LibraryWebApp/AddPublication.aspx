<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPublication.aspx.cs" Inherits="LibraryWebApp.AddPublication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Publication</h2>

    Publication name:<br />
    <asp:TextBox ID="txtPubName" runat="server"></asp:TextBox>
    <asp:Button ID="btnAddPub" runat="server" Text="Add"
        OnClick="btnAddPub_Click" />
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    <br /><br />

    <asp:GridView ID="gvPub" runat="server" AutoGenerateColumns="False"
        DataKeyNames="PublicationId"
        OnRowEditing="gvPub_RowEditing"
        OnRowCancelingEdit="gvPub_RowCancelingEdit"
        OnRowUpdating="gvPub_RowUpdating"
        OnRowDeleting="gvPub_RowDeleting">
        <Columns>
            <asp:BoundField DataField="PublicationId" HeaderText="ID" ReadOnly="True" />
            <asp:BoundField DataField="PublicationName" HeaderText="Publication" />
            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
