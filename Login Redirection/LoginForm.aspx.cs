using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Login_Redirection.ValidationServiceRef;

namespace Login_Redirection
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            UserValidationServiceSoapClient client = new UserValidationServiceSoapClient();

            if(!client.LoginUser(tb_user_name.Text,tb_password.Text))
            {
                Response.Write("Crediientials not matched");
            }
            else
            {
                Response.Write("User Found");
                // Redirect
                FormsAuthentication.RedirectFromLoginPage(tb_user_name.Text, false);
            }

        }

        protected void btn_register_go_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}