using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace View_State_Demo
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                listcollection.Items.Add("Java");
                listcollection.Items.Add("Dot Net");
                listcollection.Items.Add("C++");
                listcollection.Items.Add("Spring");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Posting Bcak to server");

        }
    }
}