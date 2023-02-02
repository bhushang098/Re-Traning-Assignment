using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Connected_Disconnected_DB
{
    public partial class HomePage : System.Web.UI.Page
    {
        static string connectionString = @"Data Source=PRSQL;User ID=labuser;Password=Welcome123$;Initial Catalog=EmployeeDB;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected void Connected()
        {
            // string connectionString = @"Data Source=PRSQL;User ID=labuser;Password=Welcome123$;Initial Catalog=EmployeeDB;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            string strCommand = @"select * from dbo.Employees";
            command.CommandText = strCommand;

            SqlDataReader reader;

            connection.Open();
            reader = command.ExecuteReader(); // Returns data reader object which will refer to the result set fro read operations 
            
            
            Response.Write("ID");
            Response.Write("\t Name");
            Response.Write("\t Sallary");
            Response.Write("\t Department ID </br>");
            Response.Write("\n--------------------------------------- </br>");

            while (reader.Read())
            {
                Response.Write(reader[0]);
                Response.Write("\t" + reader["Name"]);
                Response.Write("\t" + reader["Salary"]);
                Response.Write("\t" + reader["DID"]+"</br>");
            }
            Response.Write("\n---------------------------------------</br>");

            reader.Close();
            connection.Close();

        }

        protected void Disconnected()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            string strCommand = @"select * from dbo.Employees";
            command.CommandText = strCommand;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Employees");
            DataTable dt = dataSet.Tables["Employees"];

            dgv_result.DataSource = dt;
            dgv_result.DataBind();

            Response.Write("ID"); Response.Write("Hellow Web !");
            Response.Write("\t Name");
            Response.Write("\t Sallary");
            Response.Write("\t Department ID");
            Response.Write("---------------------------------------");

            foreach (DataRow row in dt.Rows)
            {
                Response.Write(row[0]);
                Response.Write("\t" + row["Name"]);
                Response.Write("\t" + row["Salary"]);
                Response.Write("\t" + row["DID"]);
            }
            Response.Write("Hellow Web !");
            Response.Write("---------------------------------------");
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_connected_Click(object sender, EventArgs e)
        {
            Connected();
        }

        protected void btn_disconnected_Click(object sender, EventArgs e)
        {
            Disconnected();
           

        }
    }
}