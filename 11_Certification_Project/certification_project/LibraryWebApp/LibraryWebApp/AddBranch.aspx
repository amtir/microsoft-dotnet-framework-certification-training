<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBranch.aspx.cs" Inherits="LibraryWebApp.AddBranch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Branch</h2>

    Branch name:<br />
    <asp:TextBox ID="txtBranchName" runat="server"></asp:TextBox>
    <asp:Button ID="btnAddBranch" runat="server" Text="Add"
        OnClick="btnAddBranch_Click" />
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    <br /><br />

    <asp:GridView ID="gvBranch" runat="server" AutoGenerateColumns="False"
        DataKeyNames="BranchId"
        OnRowEditing="gvBranch_RowEditing"
        OnRowCancelingEdit="gvBranch_RowCancelingEdit"
        OnRowUpdating="gvBranch_RowUpdating"
        OnRowDeleting="gvBranch_RowDeleting">
        <Columns>
            <asp:BoundField DataField="BranchId" HeaderText="ID" ReadOnly="True" />
            <asp:BoundField DataField="BranchName" HeaderText="Branch" />
            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
