using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Server_Side
{
    public partial class ServerSide : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                Application.Lock();

                if (Session.IsNewSession)
                {
                    //Session.Count = (int)Session.Count + 1;
                    Session["Session_Count"] = (int)Session.Count + 1;
                }

                Application["Application_Count"] = (int)Application.Count + 1;
                Application.UnLock();
            }

            session_count.Text = "Session Count : " + Session.Count.ToString();
            application_count.Text = "Application Count : " + Application.Count.ToString();

        }

        protected void btn_hellow_Click(object sender, EventArgs e)
        {
            Response.Redirect("PAGE2.ASPX");
        }
    }
}