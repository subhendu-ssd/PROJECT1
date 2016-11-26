using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class logs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button9_Click(object sender, EventArgs e)
        {

        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("./canlog.aspx");
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("./comlogin.aspx");

        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Response.Redirect("./comd.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("./comsu.aspx");
        }
    }
}