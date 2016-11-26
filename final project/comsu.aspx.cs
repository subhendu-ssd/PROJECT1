using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace final_project
{
    public partial class comsu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            string qry = "insert into candidateprofile(email,password,confirmpassword,contactno,location) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();



            if (TextBox2.Text == TextBox6.Text)
            {
                Response.Redirect("./cansu.aspx");
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}