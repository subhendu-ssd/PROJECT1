using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class admin3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("./admin1.aspx");

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("./admin2.aspx");

        }
    }
}