<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyAccount.aspx.cs" Inherits="LibraryWebApp.MyAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>My Account</h2>

    <h3>Profile Details</h3>
    <table>
        <tr>
            <td>Name</td>
            <td><asp:TextBox ID="txtName" runat="server" /></td>
        </tr>
        <tr>
            <td>Branch</td>
            <td>
                <asp:DropDownList ID="ddlBranch" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Mobile</td>
            <td><asp:TextBox ID="txtMobile" runat="server" /></td>
        </tr>
        <tr>
            <td>Address</td>
            <td><asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Rows="2" /></td>
        </tr>
        <tr>
            <td>City</td>
            <td><asp:TextBox ID="txtCity" runat="server" /></td>
        </tr>
        <tr>
            <td>Pincode</td>
            <td><asp:TextBox ID="txtPincode" runat="server" /></td>
        </tr>
        <tr>
            <td>Email</td>
            <td><asp:TextBox ID="txtEmail" runat="server" /></td>
        </tr>
    </table>
    <asp:Button ID="btnSave" runat="server" Text="Save Changes"
        OnClick="btnSave_Click" />
    <asp:Label ID="lblProfileMsg" runat="server" ForeColor="Red"></asp:Label>

    <hr />

    <h3>Change Password</h3>
    <table>
        <tr>
            <td>Old Password</td>
            <td><asp:TextBox ID="txtOldPassword" runat="server" TextMode="Password" /></td>
        </tr>
        <tr>
            <td>New Password</td>
            <td><asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password" /></td>
        </tr>
        <tr>
            <td>Confirm New Password</td>
            <td><asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" /></td>
        </tr>
    </table>
    <asp:Button ID="btnChangePassword" runat="server" Text="Change Password"
        OnClick="btnChangePassword_Click" />
    <asp:Label ID="lblPwdMsg" runat="server" ForeColor="Red"></asp:Label>

</asp:Content>