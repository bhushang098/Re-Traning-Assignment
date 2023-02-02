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

namespace task1
{
    public partial class frm_employee : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlCommand cmdEmployee;
        string strConnection;
        DataTable dt;
        DataTable dtEmployees;
        SqlDataReader dr;
        SqlDataReader drEmployee;

        static int selectedDepiID;
        public frm_employee()
        {
            InitializeComponent();
            strConnection = "Data Source=DESKTOP-3JCAM49\\SQLEXPRESS;Initial Catalog = MindtreeDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(strConnection);
            command = new SqlCommand();

            cmdEmployee = new SqlCommand();
            cmdEmployee.Connection = conn;
            cmdEmployee.CommandType = CommandType.Text;

            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Departments";
            command.Connection = conn;
            dt = new DataTable();
            dtEmployees = new DataTable();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_show_department_Click(object sender, EventArgs e)
        {
            conn.Open();
            dr = command.ExecuteReader();
            dt.Load(dr);
            dgvDepartments.DataSource = dt;
            conn.Close();
        }

        private void dgvDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDepartments.SelectedRows[0];
            MessageBox.Show(dgvDepartments.CurrentRow.Cells["DeptName"].Value.ToString());
        }

        private void dgvDepartments_SectionChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_dept_row_header_clicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvDepartments.SelectedRows[0];
            DataGridViewCellCollection cells = row.Cells;
            foreach (DataGridViewTextBoxCell cell in cells)
            {
                //MessageBox.Show(cell.Value.ToString());
                selectedDepiID = int.Parse(cell.Value.ToString());
                break;
            }

            // Load Employee in each Departments
            
            cmdEmployee.CommandText = "select e.Name as EmployeeName,e.Salary as EmployeeSalary" +
                ", d.DeptName as DepartmentName from Employees e join Departments d on e.DID = d.DeptId where e.DID = " + selectedDepiID;
            
            if(conn.State != ConnectionState.Closed)
            {


            }
            else
            {
                conn.Open();
                drEmployee = cmdEmployee.ExecuteReader();
                dtEmployees.Clear();
                dtEmployees.Load(drEmployee);
                dgvEmployees.DataSource = dtEmployees;
                conn.Close();

                // Load Summary 
                int count = 0;
                string deptname = "";
                double totalsalary  = 0;

                var temp = dtEmployees.Rows.GetType();
                foreach(DataRow dr in dtEmployees.Rows)
                {
                    totalsalary += double.Parse(dr.ItemArray[1].ToString());
                    count++;
                    deptname = dr.ItemArray[2].ToString();
                }
                lbl_emp_department.Text = string.Format("Total Employees in {0}  Department are {1}", deptname,count);
                lbl_salary_department.Text = string.Format("Total Salary  Distributed in {0} Department is {1}", deptname, totalsalary);

            }

        }
    }
}
