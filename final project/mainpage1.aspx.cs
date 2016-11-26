using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class mainpage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (CheckBox5.Checked)
            {

                String str = "SELECT * FROM [candidateapplication1] where 1 = 1 ";
                if (CheckBox1.Checked)
                {
                    str = str + " And substring(skills, 1,1) = '1' ";
                }
                if (CheckBox2.Checked)
                {
                    str = str + " And substring(skills, 2,1) = '1' ";
                }

                if (CheckBox3.Checked)
                {
                    str = str + " And substring(skills, 3,1) = '1' ";
                }

                if (CheckBox4.Checked)
                {
                    str = str + " And substring(skills, 4,1) = '1' ";
                }

                SqlDataSource1.SelectCommand = str;
                GridView1.DataSourceID = "";
                GridView1.DataSource = SqlDataSource1;
            }
            if (CheckBox6.Checked)
            {

                String str = "SELECT * FROM [candidateapplication1] where 1 = 0 ";
                if (CheckBox1.Checked)
                {
                    str = str + " Or substring(skills, 1,1) = '1' ";
                }
                if (CheckBox2.Checked)
                {
                    str = str + " Or substring(skills, 2,1) = '1' ";
                }

                if (CheckBox3.Checked)
                {
                    str = str + " Or substring(skills, 3,1) = '1' ";
                }

                if (CheckBox4.Checked)
                {
                    str = str + " Or substring(skills, 4,1) = '1' ";
                }

                SqlDataSource1.SelectCommand = str;
                GridView1.DataSourceID = "";
                GridView1.DataSource = SqlDataSource1;
            }


            //SqlDataSource2.SelectCommand = str;
            //GridView2.DataSourceID = "";
            //GridView2.DataSource = SqlDataSource1;
 
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}