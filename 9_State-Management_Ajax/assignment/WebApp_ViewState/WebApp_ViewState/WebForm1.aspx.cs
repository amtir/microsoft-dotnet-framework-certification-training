using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_ViewState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // On every postback, increase the counter stored in ViewState
            if (IsPostBack)
            {
                int count = 0;

                if (ViewState["number_postback"] != null)
                    count = (int)ViewState["number_postback"];

                count++; // one more postback
                ViewState["number_postback"] = count;
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            // Display data from ViewState
            if (ViewState["name"] != null)
                Label1.Text = ViewState["name"].ToString();

            if (ViewState["number_postback"] != null)
                Label2.Text = ViewState["number_postback"].ToString();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Save the name in ViewState
            ViewState["name"] = TextBox1.Text;
            TextBox1.Text = string.Empty;
        }
    }
}