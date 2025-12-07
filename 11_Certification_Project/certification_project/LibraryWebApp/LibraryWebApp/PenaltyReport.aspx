<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PenaltyReport.aspx.cs" Inherits="LibraryWebApp.PenaltyReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Penalty Report</h2>

    <table>
        <tr>
            <td>Branch</td>
            <td>
                <asp:DropDownList ID="ddlBranch" runat="server"
                    AutoPostBack="true"
                    OnSelectedIndexChanged="ddlBranch_SelectedIndexChanged" />
            </td>
        </tr>
        <tr>
            <td>Student</td>
            <td>
                <asp:DropDownList ID="ddlStudent" runat="server"
                    AutoPostBack="true"
                    OnSelectedIndexChanged="ddlStudent_SelectedIndexChanged" />
            </td>
        </tr>
    </table>

    <br />

    <asp:GridView ID="gvPenalty" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="StudentName" HeaderText="Student" />
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
