using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryWebApp
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // protect all pages that use this master (except Login)
                string role = Session["Role"] as string;

                if (string.IsNullOrEmpty(role))
                {
                    Response.Redirect("~/Login.aspx");
                    return;
                }

                lblUser.Text = $"{role}: {Session["UserName"]}";

                pnlAdminMenu.Visible = role == "Admin";
                pnlStudentMenu.Visible = role == "Student";
            }

        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}