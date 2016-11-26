using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class demo2 : System.Web.UI.Page
    {
          
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
           {
               ddd();

           }
           
        }
    

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("./mainpage2.aspx");
        }

       

      

       

       

protected void Timer1_Tick1(object sender, EventArgs e)
{
    ddd();

}

private void ddd()
{
    Random _rand = new Random();
    int i = _rand.Next(1, 4);
    Image2.ImageUrl = "~/PICTURES/" + i.ToString() + ".jpg";
}

      }
    }
