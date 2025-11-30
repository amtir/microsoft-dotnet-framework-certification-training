using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_AppState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Application.Lock();
            int count = 0;
                if (Application["visit"] != null) {
                count = Convert.ToInt32(Application["visit"].ToString());
            }
            count = count + 1;
            Application["visit"] = count; 
            Application.UnLock();
            Label1.Text = "Total Visit: " + count.ToString(); 
        }
    }
}