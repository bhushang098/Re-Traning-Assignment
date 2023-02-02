using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Connected_Disconnected_Db_Aproach
{
    

    internal class Program
    {
        static string connectionString = @"Data Source=PRSQL;User ID=labuser;Password=Welcome123$;Initial Catalog=EmployeeDB;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static void Connected()
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
            Console.Write("ID");
            Console.Write("\t Name");
            Console.Write("\t Sallary");
            Console.WriteLine("\t Department ID");
            Console.WriteLine("---------------------------------------");

            while(reader.Read())
            {
                Console.Write(reader[0]);
                Console.Write("\t"+reader["Name"]);
                Console.Write("\t" + reader["Salary"]);
                Console.WriteLine("\t" + reader["DID"]);
            }
            Console.WriteLine("---------------------------------------");

            reader.Close();
            connection.Close();

        }

        static void Disconnected()
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
            adapter.Fill(dataSet,"Employees");
            DataTable dt = dataSet.Tables["Employees"];

            Console.Write("ID");
            Console.Write("\t Name");
            Console.Write("\t Sallary");
            Console.WriteLine("\t Department ID");
            Console.WriteLine("---------------------------------------");

            foreach(DataRow row in dt.Rows)
            {
                Console.Write(row[0]);
                Console.Write("\t" + row["Name"]);
                Console.Write("\t" + row["Salary"]);
                Console.WriteLine("\t" + row["DID"]);
            }

            Console.WriteLine("---------------------------------------");
        }

        static void ConnectedAutomaticLoad()
        {
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
            DataTable dt = new DataTable();
            dt.Load(reader);

            Console.Write("ID");
            Console.Write("\t Name");
            Console.Write("\t Sallary");
            Console.WriteLine("\t Department ID");
            Console.WriteLine("---------------------------------------");

            foreach (DataRow row in dt.Rows)
            {
                Console.Write(row[0]);
                Console.Write("\t" + row["Name"]);
                Console.Write("\t" + row["Salary"]);
                Console.WriteLine("\t" + row["DID"]);
            }
            Console.WriteLine("---------------------------------------");

            reader.Close();
            connection.Close();
        }
        static void Main(string[] args)
        {
            Connected();
            Disconnected();
            ConnectedAutomaticLoad();
        }
    }
}
