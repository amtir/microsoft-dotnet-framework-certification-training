using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_Session
{
    public partial class Input : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Read values from the session and show them
            if (Session["UserName"] != null && Session["Password"] != null)
            {
                Label1.Text = "Username: " + Session["UserName"].ToString()
                            + "<br />Password: " + Session["Password"].ToString();
            }
            else
            {
                Label1.Text = "No data in session.";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["UserName"] = TextBox1.Text;
            Session["Password"] = TextBox2.Text;
            Response.Redirect("Display.aspx");
        }
    }
}