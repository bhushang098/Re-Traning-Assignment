using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Data_Handeling_Employee
{
    public partial class EmployeeForm : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        IDataReader dr;
        string strcmd;
        string strconn = @"Data Source=PRSQL;User ID=labuser;Password=Welcome123$;Initial Catalog=EmployeeDB;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public EmployeeForm()
        {
            InitializeComponent();
            conn = new SqlConnection(strconn);
            cmd = new SqlCommand();
            cmd.Connection = conn;

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            strcmd = @"select * from Employees";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strcmd;

            conn.Open();
            dr = cmd.ExecuteReader();
            dt.Rows.Clear();
            dt.Load(dr);
            dr.Close();
            conn.Close();

            dgvEmployee.DataSource = dt;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            //tb_emp_id.Text + "','" +
            strcmd = @"Insert Into Employees values('" + tb_emp_name.Text + "','" + tb_emp_salary.Text + "','" + tb_dept_id.Text + "')";
            cmd.CommandText = strcmd;
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(i + " Records Added");

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
            strcmd = @"Update  Employees Set Name = " +"'"+tb_emp_name.Text+"'"+ "," + " Salary = " +"'"+tb_emp_salary.Text +"'"+" Where ID = "+"'"+tb_emp_id.Text+"'";

            cmd.CommandText = strcmd;
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(i + " Records Updated");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            strcmd = @"Delete From Employees Where Salary < '"+ tb_emp_salary.Text+"'";
            cmd.CommandText = strcmd;
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(i + " Rows Deleted");


        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
