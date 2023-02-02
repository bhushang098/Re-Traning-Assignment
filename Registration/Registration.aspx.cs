using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_validation.Visible = false;
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.age = int.Parse(tb_age.Text.ToString());
            user.user_name = tb_user_name.Text.ToString();
            user.user_mail = tb_email.Text.ToString();
            user.password = tb_password.Text.ToString();

            if(user.age>50 || user.age<18)
            {
                lbl_validation.Text = "Age Should Be between 18 and 50";
                lbl_validation.Visible = true;
                return;
            }

            if(user.password != tb_conform_pass.Text.ToString())
            {
                lbl_validation.Text = "Password Did not Matched";
                lbl_validation.Visible = true;
                return;
            }

            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();

            string strConn = @"Data Source=PRSQL;Initial Catalog=UserDb;User ID=labuser;Password=Welcome123$";
            string strCmd = @"insert into Users (user_name,user_mail,password,age) values('"+user.user_name+"','"
                +user.user_mail+"','"+user.password+"','"+user.age+"')";

            objConn.ConnectionString = strConn;
            objCmd.Connection = objConn;
            objCmd.CommandType = System.Data.CommandType.Text;
            objCmd.CommandText = strCmd;

            objConn.Open();
            int rowaffected =  objCmd.ExecuteNonQuery();

            Response.Write(rowaffected + " Rows Affetected");
            lbl_validation.Text = "User Registered Successfully";
            objConn.Close();

        }
    }
}