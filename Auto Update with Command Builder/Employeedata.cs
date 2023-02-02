using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Auto_Update_with_Command_Builder
{
    public partial class Employeedata : Form
    {

        SqlConnection conn;
        string strconn = @"Data Source=PRSQL;User ID=labuser;Password=Welcome123$;Initial Catalog=EmployeeDB;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string strCmd;
        SqlCommand cmd;
        SqlCommandBuilder cmdBuilder;
        SqlDataAdapter da;
        DataTable dt;

        public Employeedata()
        {
            InitializeComponent();

            dt = new DataTable();
            conn = new SqlConnection(strconn);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            strCmd = @"select * from Employees";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strCmd;

            da = new SqlDataAdapter(cmd);
            cmdBuilder = new SqlCommandBuilder(da);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Update
            da.Update(dt);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Select
            dt.Clear();
            da.Fill(dt);
            dgvEmployee.DataSource = dt;
        }

        private void Employeedata_Load(object sender, EventArgs e)
        {

        }
    }
}
