using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace final_project
{
    public partial class comd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //int i ;
            //for(i=1;i<=10;i++)
            ///{
            //if ((string.IsNullOrEmpty(TextBox1.Text)) && (string.IsNullOrEmpty(TextBox2.Text)) &&  (string.IsNullOrEmpty(TextBox3.Text)))



            //{
            //       Button6.Enabled = false;
            //}
            






            //else
            //{
            //if ((TextBox8.Text != TextBox9.Text) || (TextBox1.Text != " ") || (TextBox2.Text != " ") || (TextBox3.Text != " ") || (TextBox4.Text != " ") || (TextBox5.Text != " ") || (TextBox8.Text != " ") || (TextBox9.Text != " ") || (TextBox11.Text != " "))
            //{
            //    Label14.Text = "All Fields Are Mandatory";
            //    Response.Redirect("./comd.aspx");

            //}

            //else
            //{



            
            


                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
                con.Open();
                string fdr = "";




                if (CheckBox1.Checked)
                {

                    fdr = fdr + "1";
                }
                else
                {
                    fdr = fdr + "0";
                }

                if (CheckBox2.Checked)
                {

                    fdr = fdr + "1";
                }
                else
                {
                    fdr = fdr + "0";
                }


                if (CheckBox3.Checked)
                {

                    fdr = fdr + "1";
                }
                else
                {
                    fdr = fdr + "0";
                }

                if (CheckBox4.Checked)
                {

                    fdr = fdr + "1";
                }
                else
                {
                    fdr = fdr + "0";
                }


                string qry = "insert into companyprofile1(companyname,website,regno,location,email,password,confirmpassword,contactno,skills) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox11.Text + "','" + fdr + "' )";


                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();

                //con.Close();
                if (TextBox8.Text == TextBox9.Text)
                {

                    Response.Redirect("./demo3.aspx");
                    con.Close();
                }
        }
             
 


            
        
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}