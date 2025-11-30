using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_Application
{
    public partial class ApplicationState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialize and increment visitor count on every page load
            Application.Lock();
            if (Application["VisitorCount"] == null)
            {
                Application["VisitorCount"] = 0;
            }

            Application["VisitorCount"] = (int)Application["VisitorCount"] + 1;
            Application.UnLock();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Show number of visitors
            Label1.Text = "Number of people who visited this page: "
                          + Application["VisitorCount"].ToString();
        }
    }
}