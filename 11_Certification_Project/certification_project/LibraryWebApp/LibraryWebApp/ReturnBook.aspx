<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReturnBook.aspx.cs" Inherits="LibraryWebApp.ReturnBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Return Book</h2>

    <table>
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

    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    <br /><br />

    <asp:GridView ID="gvIssued" runat="server" AutoGenerateColumns="False"
        OnRowCommand="gvIssued_RowCommand">
        <Columns>
            <asp:BoundField DataField="IssueId" HeaderText="Issue ID" />
            <asp:BoundField DataField="BookName" HeaderText="Book" />
            <asp:BoundField DataField="IssueDate" HeaderText="Issue Date"
                            DataFormatString="{0:yyyy-MM-dd}" />
            <asp:BoundField DataField="DueDate" HeaderText="Due Date"
                            DataFormatString="{0:yyyy-MM-dd}" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnkReturn" runat="server"
                        Text="Return"
                        CommandName="ReturnBook"
                        CommandArgument='<%# Eval("IssueId") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
