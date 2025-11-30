using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace _3TierApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BLL ob2 = new BLL();
            ob2.Inputuser(TextBox1.Text, TextBox2.Text, TextBox3.Text);
            GridView1.DataSource = ob2.selectUser();
            GridView1.DataBind();
        }
    }
}