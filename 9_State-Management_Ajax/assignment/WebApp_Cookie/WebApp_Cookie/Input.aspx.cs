using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_Cookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Read cookie when page loads
            if (Request.Cookies["color"] != null)
            {
                string bgColor = Request.Cookies["color"].Value;
                Body.Style["background-color"] = bgColor;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save selected color to cookie
            HttpCookie c = new HttpCookie("color");
            c.Value = DropDownList1.SelectedValue;
            c.Expires = DateTime.Now.AddDays(1);   // Optional: cookie lives 1 day
            Response.Cookies.Add(c);

            // Also apply color immediately
            Body.Style["background-color"] = DropDownList1.SelectedValue;

        }
    }
}