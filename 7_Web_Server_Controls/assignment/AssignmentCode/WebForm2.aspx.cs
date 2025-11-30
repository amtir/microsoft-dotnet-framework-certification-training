using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentQuestion1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.PageIndex = 0;          // go to first page after search
                GridView1.DataBind();             // rebind; SqlDataSource reads txtFilter via ControlParameter

            }
        }
    }
}