using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class mainpage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {


        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            String str = "SELECT * FROM [companyprofile1] where 1 = 1 ";
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
    }
}