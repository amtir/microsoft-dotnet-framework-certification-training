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

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ViewState["name"] != null)
                TextBox1.Text = ViewState["name"].ToString();

            if (ViewState["password"] != null)
                TextBox2.Text = ViewState["password"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ViewState["name"]  = TextBox1.Text;
            ViewState["password"] = TextBox2.Text;
            
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;   
        }
    }
}