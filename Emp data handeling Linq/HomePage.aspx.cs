using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emp_data_handeling_Linq
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_display_Click(object sender, EventArgs e)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();

            string strConn = @"Data Source=PRSQL;Initial Catalog=EmployeeDB;User ID=labuser;Password=Welcome123$";
            string strCmd = @"Select ID,Name,Salary,DID from Employees";

            objConn.ConnectionString = strConn;
            objCmd.Connection = objConn;
            objCmd.CommandType = System.Data.CommandType.Text;
            objCmd.CommandText = strCmd;

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = objCmd;
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            da.Fill(ds, "MyEmployees");
            DataTable dataTable = ds.Tables["MyEmployees"];

            var query = from emp in dataTable.AsEnumerable()
                        select new
                        {
                            ID = emp.Field<int>("ID"),
                            Name = emp.Field<string>("Name"),
                            Salary = emp.Field<decimal>("Salary"),
                            DID = emp.Field<Int16>("DID"),
                        };
            Response.Write("ID \t Name \t Salary \t DepartMent");
            Response.Write("</br> --------------------------");

            foreach (var em in query)
            {
                //Response.WriteLine(e.DID);
                Response.Write(String.Format("{0} \t {1} \t {2} \t {3}", em.ID, em.Name, em.Salary, em.DID));
            }
        }
    }
}