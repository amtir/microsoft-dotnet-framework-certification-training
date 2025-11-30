using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            /*
             * HttpCookie cookie = new HttpCookie("student");
            cookie.Value = "John";
            Response.Cookies.Add(cookie);
            var co_val = Response.Cookies["student"].Value;
            Label1.Text = co_val;    */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Cookies["name"].Value = TextBox1.Text;
            Response.Cookies["name"].Expires = DateTime.Now.AddMinutes(5);
            Label1.Text = "Cookie created.";
            TextBox1.Text = "";


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["name"] == null)
                TextBox1.Text = "No Cookies Found";
            else
                TextBox2.Text = Request.Cookies["name"].Value;
        }
    }
}