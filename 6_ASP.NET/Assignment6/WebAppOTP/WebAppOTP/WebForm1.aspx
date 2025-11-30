<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppOTP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>OTP Verification Web Page Demo</title>
    <style>
        .panel {
            border: 2px solid #555;
            padding: 12px;
            width: 480px;
            background-color: #ffffaa;
        }
        .panel.verify {
            background-color: #aaffaa;
        }
        .heading {
            font-weight: bold;
            font-size: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="heading">OTP Verification Web Page Demo</div>
        <a href="https://www.twilio.com/docs/sms" target="_blank">Send OTP and verify in ASP.NET</a>
        <br /><br />

        <!-- Panel 1: Send OTP -->
        <asp:Panel ID="PanelSend" runat="server" CssClass="panel">
            Enter Your Mobile No.<br />
            <asp:TextBox ID="txtPhone" runat="server" Width="400px"></asp:TextBox><br />
            <asp:Button ID="btnSendOTP" runat="server" Text="Send OTP" OnClick="btnSendOTP_Click" /><br />
            <asp:Label ID="lblSendStatus" runat="server" ForeColor="Red"></asp:Label>
        </asp:Panel>

        <!-- Panel 2: Verify OTP -->
        <asp:Panel ID="PanelVerify" runat="server" Visible="false" CssClass="panel verify">
            Enter OTP<br />
            <asp:TextBox ID="txtOTP" runat="server" Width="400px"></asp:TextBox><br />
            <asp:Button ID="btnVerify" runat="server" Text="Verify" OnClick="btnVerify_Click" /><br />
            <asp:Label ID="lblVerifyStatus" runat="server" ForeColor="Blue"></asp:Label>
        </asp:Panel>

        <asp:Label ID="lblGlobal" runat="server" ForeColor="DarkRed"></asp:Label>


        <p><b>Note:</b> OTP is case sensitive.</p>
    </form>
</body>
</html>
