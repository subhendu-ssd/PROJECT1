using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace final_project
{
    public partial class canlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from candidateprofile where email=@label1 and password=@label2", con);
            cmd.Parameters.AddWithValue("@label1", TextBox1.Text);
            cmd.Parameters.AddWithValue("@label2", TextBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Response.Redirect("./demo2.aspx");

            }
            else
            {
                Label4.Text = "Invalid USERID or PASSWORD";

               
               // ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
            }

            
            

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}