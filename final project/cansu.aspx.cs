using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace final_project
{
    public partial class cansu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            string str = "";
           string fdr ="";

            if (RadioButton1.Checked)
                str = "MALE";
            if (RadioButton2.Checked)
                str = "FEMALE";

            //string qry = "insert into candidateapplication1(name,sex,qualification,univname,yearofpassout,skills) values('"  + TextBox1.Text + "','" + str + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "' )";
            
            //SqlCommand cmd = new SqlCommand(qry, con);
            //cmd.ExecuteNonQuery();
            ////if (CheckBox5.Checked)
            //{

            //    str = str + "1";
            //}
            //else
            //{
            //    str = str + "0";
            //}

            //if (CheckBox6.Checked)
            //{

            //    str = str + "1";
            //}
            //else
            //{
            //    str = str + "0";
            //}


            //if (CheckBox7.Checked)
            //{

            //    str = str + "1";
            //}
            //else
            //{
            //    str = str + "0";
            //}

            //if (CheckBox8.Checked)
            //{

            //    str = str + "1";
            //}
            //else
            //{
            //    str = str + "0";
            //}
            if (CheckBox5.Checked)
            {

                fdr = fdr + "1";
            }
            else
            {
                fdr = fdr + "0";
            }

            if (CheckBox6.Checked)
            {

                fdr = fdr + "1";
            }
            else
            {
                fdr = fdr + "0";
            }


            if (CheckBox7.Checked)
            {

                fdr = fdr + "1";
            }
            else
            {
                fdr = fdr + "0";
            }

            if (CheckBox8.Checked)
            {

                fdr = fdr + "1";
            }
            else
            {
                fdr = fdr + "0";
            }
            string qry = "insert into candidateapplication1(name,sex,qualification,univname,yearofpassout,skills) values('" + TextBox1.Text + "','" + str + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + fdr + "' )";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
           
            
            string qre = "insert into candidateskills(name,skills) values('" + TextBox1.Text + "','" + fdr + "' )";
            SqlCommand cme = new SqlCommand(qre, con);

            cme.ExecuteNonQuery();
            con.Close();
             
        
          

            Response.Redirect("./demo2.aspx");
            

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}