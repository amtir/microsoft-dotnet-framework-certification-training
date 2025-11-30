<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppUserRegistration.WebForm1" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
    <style>
        body { font-family: Segoe UI, Arial, sans-serif; }
        .form { max-width: 520px; margin: 30px auto; padding: 18px; border: 1px solid #ccc; border-radius: 8px; }
        .row { margin-bottom: 10px; }
        .row label { display:inline-block; width:140px; }
        .star { color: #d33; }
        .msg-ok { color: #0a7a28; font-weight:600; }
        .msg-err { color: #b20000; font-weight:600; }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <div class="form">
        <h2>User Registration</h2>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="msg-err" />

        <div class="row">
            <label>First Name <span class="star">*</span></label>
            <asp:TextBox ID="txtFirstName" runat="server" />
            <asp:RequiredFieldValidator ID="rfvFN" runat="server" ControlToValidate="txtFirstName"
                ErrorMessage="First Name is required." Display="Dynamic" CssClass="msg-err" />
        </div>

        <div class="row">
            <label>Last Name <span class="star">*</span></label>
            <asp:TextBox ID="txtLastName" runat="server" />
            <asp:RequiredFieldValidator ID="rfvLN" runat="server" ControlToValidate="txtLastName"
                ErrorMessage="Last Name is required." Display="Dynamic" CssClass="msg-err" />
        </div>

        <div class="row">
            <label>Mobile <span class="star">*</span></label>
            <asp:TextBox ID="txtMobile" runat="server" MaxLength="20" />
            <asp:RequiredFieldValidator ID="rfvMob" runat="server" ControlToValidate="txtMobile"
                ErrorMessage="Mobile is required." Display="Dynamic" CssClass="msg-err" />
            <asp:RegularExpressionValidator ID="revMob" runat="server" ControlToValidate="txtMobile"
                ValidationExpression="^\+?[0-9]{7,20}$"
                ErrorMessage="Enter a valid phone number (digits, optional +)." CssClass="msg-err" Display="Dynamic" />
        </div>

        <div class="row">
            <label>Gender <span class="star">*</span></label>
            <asp:DropDownList ID="ddlGender" runat="server">
                <asp:ListItem Text="-- Select --" Value="" />
                <asp:ListItem Text="Male" Value="Male" />
                <asp:ListItem Text="Female" Value="Female" />
                <asp:ListItem Text="Other" Value="Other" />
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvGen" runat="server" ControlToValidate="ddlGender"
                InitialValue="" ErrorMessage="Please select a gender." CssClass="msg-err" Display="Dynamic" />
        </div>

        <div class="row">
            <label>Address</label>
            <asp:TextBox ID="txtAddress" runat="server" Width="320px" />
        </div>

        <hr />

        <div class="row">
            <label>User Name <span class="star">*</span></label>
            <asp:TextBox ID="txtUserName" runat="server" />
            <asp:RequiredFieldValidator ID="rfvUN" runat="server" ControlToValidate="txtUserName"
                ErrorMessage="User Name is required." Display="Dynamic" CssClass="msg-err" />
        </div>

        <div class="row">
            <label>Password <span class="star">*</span></label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rfvPW" runat="server" ControlToValidate="txtPassword"
                ErrorMessage="Password is required." Display="Dynamic" CssClass="msg-err" />
        </div>

        <div class="row">
            <label>Confirm Password <span class="star">*</span></label>
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rfvCPW" runat="server" ControlToValidate="txtConfirmPassword"
                ErrorMessage="Confirm Password is required." Display="Dynamic" CssClass="msg-err" />
            <asp:CompareValidator ID="cvPW" runat="server" ControlToCompare="txtPassword"
                ControlToValidate="txtConfirmPassword" Operator="Equal" Type="String"
                ErrorMessage="Passwords do not match." CssClass="msg-err" Display="Dynamic" />
        </div>

        <div class="row">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>

        <asp:Label ID="lblResult" runat="server" />
    </div>
</form>
</body>
</html>
