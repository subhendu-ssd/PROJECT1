using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("./logs.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./about.aspx");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("./admin.aspx");

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("./contactus.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("./feedback.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click2(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void LinkButton1_Click3(object sender, EventArgs e)
        {

        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
                   // Response.Write("<script language="'javascript'"> { window.close();}</script>");

        }
    }
}