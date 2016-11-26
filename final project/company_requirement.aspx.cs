using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class company_requirement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
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


            string qre = "insert into companyreq(companyname,skills) values('" + TextBox1.Text + "','" + fdr + "' )";
            SqlCommand cme = new SqlCommand(qre, con);

            cme.ExecuteNonQuery();
            con.Close();
            Response.Redirect("./mainpage.aspx");


        }
    }
}