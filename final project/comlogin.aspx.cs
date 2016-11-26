using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace final_project
{
    public partial class comlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from companyprofile1 where email=@label2 and password=@label3", con);
            cmd.Parameters.AddWithValue("@label2", TextBox1.Text);
            cmd.Parameters.AddWithValue("@label3", TextBox3.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Response.Redirect("./demo3.aspx");

            }
            else
            {
                Label4.Text = "Invalid USERID or PASSWORD";


                // ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
            }

            
            
        }
    }
}