using Login_Redirection.ValidationServiceRef;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Redirection
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_validation1.Visible = false;
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {

            UserValidationServiceSoapClient client = new UserValidationServiceSoapClient();


            User user = new User();
            user.age = int.Parse(tb_age.Text.ToString());
            user.user_name = tb_user_name.Text.ToString();
            user.user_mail = tb_email.Text.ToString();
            user.password = tb_password.Text.ToString();

            if (user.age > 50 || user.age < 18)
            {
                lbl_validation1.Text = "Age Should Be between 18 and 50";
                lbl_validation1.Visible = true;
                return;
            }

            if (user.password != tb_conform_pass.Text.ToString())
            {
                lbl_validation1.Text = "Password Did not Matched";
                lbl_validation1.Visible = true;
                return;
            }




          

            if (client.RegisterUser(user.user_name, user.password, user.user_mail, (int)user.age) >= 0)
            {
                // Success
                Response.Write("Registered Successfully !");
                lbl_validation1.Text = "User Registered Successfully";
               Response.Redirect("LoginForm.aspx");

            }
            else
            {
                
                lbl_validation1.Text = "Something Went Wrong";
            }
            

        }
    }
}