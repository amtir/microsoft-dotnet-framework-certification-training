using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppFragmentCache
{
    public partial class FragmentCaching : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Web Form Time : " + DateTime.Now.TimeOfDay.ToString();
        }
    }
}