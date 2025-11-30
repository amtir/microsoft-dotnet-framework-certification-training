<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Verified.aspx.cs" Inherits="WebAppOTP.Verified" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>OTP Verified</title>
  <style>
    body { font-family: Segoe UI, sans-serif; }
    .card { margin:40px auto; max-width:520px; border:1px solid #ccc; padding:20px; border-radius:8px; }
    .ok { color: #0a7a28; font-weight:700; font-size:20px; }
  </style>
</head>
<body>
<form id="form1" runat="server">
  <div class="card">
    <div class="ok">✅ OTP verified successfully.</div>
    <p>You can now continue.</p>
    <asp:HyperLink runat="server" NavigateUrl="~/WebForm1.aspx" Text="Back to start" />
  </div>
</form>
</body>
</html>
