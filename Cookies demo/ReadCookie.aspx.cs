using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies_demo
{
    public partial class ReadCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("ReadCookie.aspx is loaded");
        }

        protected void btn_read_cookie_Click(object sender, EventArgs e)
        {
            HttpCookie objCookie = Request.Cookies["myCookie"];
            
            Label_time.Text = objCookie.Values["Time"];
            Label_time.ForeColor = System.Drawing.Color.FromName(objCookie.Values["ForeGroundColor"]);
            Label_time.BackColor = System.Drawing.Color.FromName(objCookie.Values["BackGroundColor"]);

            Label_current_time.Text = DateTime.Now.ToString();

        }
    }
}