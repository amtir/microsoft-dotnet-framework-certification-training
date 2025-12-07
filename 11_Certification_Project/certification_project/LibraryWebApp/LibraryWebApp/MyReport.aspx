<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyReport.aspx.cs" Inherits="LibraryWebApp.MyReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>My Report</h2>

    <asp:GridView ID="gvMyReport" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="BookName" HeaderText="Book" />
            <asp:BoundField DataField="IssueDate" HeaderText="Issue Date"
                            DataFormatString="{0:yyyy-MM-dd}" />
            <asp:BoundField DataField="DueDate" HeaderText="Due Date"
                            DataFormatString="{0:yyyy-MM-dd}" />
            <asp:BoundField DataField="ReturnDate" HeaderText="Return Date"
                            DataFormatString="{0:yyyy-MM-dd}" />
            <asp:BoundField DataField="Penalty" HeaderText="Penalty"
                            DataFormatString="{0:C}" />
        </Columns>
    </asp:GridView>
</asp:Content>
