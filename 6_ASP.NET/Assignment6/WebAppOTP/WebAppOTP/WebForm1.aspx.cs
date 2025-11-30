using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Vonage;
using Vonage.Messaging;
using Vonage.Request;

namespace WebAppOTP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // Session keys
        private const string S_Otp = "OTP_CODE";
        private const string S_Expiry = "OTP_EXPIRY";
        private const string S_Attempts = "OTP_ATTEMPTS";
        private const string S_Verified = "OTP_VERIFIED";


        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            bool hasPendingOtp =
                Session[S_Otp] != null &&
                Session[S_Expiry] != null &&
                (DateTime)Session[S_Expiry] > DateTime.UtcNow;

            // If just verified, keep verify panel visible once,
            // then invalidate OTP after render.
            if (Session[S_Verified] is bool v && v)
            {
                PanelSend.Visible = false;
                PanelVerify.Visible = true;

                // Invalidate OTP so it can't be reused
                ClearOtpSession();
                Session.Remove(S_Verified);
            }
            else
            {
                PanelSend.Visible = !hasPendingOtp;
                PanelVerify.Visible = hasPendingOtp;
            }

            lblGlobal.Text = $"SessionID: {Session.SessionID} | HasOTP: {hasPendingOtp} | " +
                             $"OTP present: {(Session[S_Otp] != null)} | " +
                             $"Expiry present: {(Session[S_Expiry] != null)}";
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            // Show verify panel only if a non-expired OTP exists in Session
            bool hasPendingOtp =
                Session[S_Otp] != null &&
                Session[S_Expiry] != null &&
                (DateTime)Session[S_Expiry] > DateTime.UtcNow;

            PanelSend.Visible = !hasPendingOtp;
            PanelVerify.Visible = hasPendingOtp;
        }



        protected void btnSendOTP_Click(object sender, EventArgs e)
        {
            lblSendStatus.Text = "";

            // 1) Validate and normalize phone (require E.164 like +41796201615)
            var phone = txtPhone.Text.Trim();
            phone = NormalizeE164(phone);
            if (phone == null)
            {
                lblSendStatus.Text = "Enter a valid phone number in E.164 format (e.g., +41796201615).";
                return;
            }

            // 2) Generate a 6-digit OTP and store with expiry
            var otp = GenerateNumericCode(6);
            int ttl = int.TryParse(ConfigurationManager.AppSettings["OtpTtlMinutes"], out var m) ? m : 5;

            Session[S_Otp] = otp;
            Session[S_Expiry] = DateTime.UtcNow.AddMinutes(ttl);
            Session[S_Attempts] = 0;

            // 3) Send via Vonage
            try
            {
                string apiKey = ConfigurationManager.AppSettings["VonageApiKey"];
                string apiSecret = ConfigurationManager.AppSettings["VonageApiSecret"];
                if (string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(apiSecret))
                {
                    lblSendStatus.Text = "Missing VonageApiKey / VonageApiSecret in Web.config.";
                    return;
                }

                var creds = Credentials.FromApiKeyAndSecret(apiKey, apiSecret);
                var client = new VonageClient(creds);

                var request = new SendSmsRequest
                {
                    To = phone.StartsWith("+") ? phone.Substring(1) : phone, // Vonage allows both; digits-only is safest
                    From = "VonageOTP", // <= 11 alphanumeric chars; change to a number if your country requires it
                    Text = $"Your OTP is {otp}. It expires in {ttl} minutes."
                };

                //var resp = client.SmsClient.SendAnSms(request);
                var resp = client.SmsClient.SendAnSmsAsync(request).GetAwaiter().GetResult();


                // Basic check (optional: inspect resp.Messages[0].Status == "0")
                PanelSend.Visible = false;
                PanelVerify.Visible = true;
                lblVerifyStatus.Text = "SessionID: " + Session.SessionID + " OTP sent. Check your phone.";
            }
            catch (Exception ex)
            {
                lblSendStatus.Text = "Failed to send OTP: " + ex.Message;
            }
        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            lblVerifyStatus.Text = "";
            lblGlobal.Text = $"SessionID: {Session.SessionID}";

            if (Session[S_Otp] == null || Session[S_Expiry] == null)
            {
                lblGlobal.Text += " | No OTP pending. Please request one.";
                return;
            }

            if ((DateTime)Session[S_Expiry] < DateTime.UtcNow)
            {
                ClearOtpSession();
                lblGlobal.Text += " | OTP expired. Please request a new one.";
                return;
            }

            int attempts = (int)Session[S_Attempts];
            var expected = (string)Session[S_Otp];
            var entered = txtOTP.Text.Trim();

            if (entered == expected)
            {
                // Invalidate OTP and leave no reusable state behind
                ClearOtpSession();
                Response.Redirect("~/Verified.aspx", endResponse: true);
                return;
            }

            Session[S_Attempts] = attempts + 1;
            lblVerifyStatus.Text = "❌ Incorrect OTP.";
        }





        // Helpers
        private static string GenerateNumericCode(int digits)
        {
            var bytes = new byte[digits];
            using (var rng = RandomNumberGenerator.Create()) rng.GetBytes(bytes);
            var sb = new StringBuilder(digits);
            foreach (var b in bytes) sb.Append((b % 10).ToString());
            return sb.ToString();
        }

        private static string NormalizeE164(string input)
        {
            var s = input.Replace(" ", "");
            if (!s.StartsWith("+")) s = "+" + s;
            return Regex.IsMatch(s, @"^\+[1-9]\d{6,14}$") ? s : null;
        }

        private void ClearOtpSession()
        {
            Session.Remove(S_Otp);
            Session.Remove(S_Expiry);
            Session.Remove(S_Attempts);
            PanelSend.Visible = true;
            PanelVerify.Visible = false;
        }


    }
}
