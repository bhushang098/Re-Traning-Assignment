using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Database_Operations
{
    internal class MainClass
    {
        static void Main(string[] args)
        {

            string connectionString = @"Data Source=PRSQL;User ID=labuser;Password=Welcome123$;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
             
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            Console.WriteLine("Hello Connection");
            conn.Close();

        }
    }
}
