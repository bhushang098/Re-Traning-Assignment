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

namespace TypedUnTypedDataSet
{
    public partial class Form1 : Form
    {
        DataSet ds;
        SqlCommand ObjCmd;
        SqlConnection Objconn;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
            string strconn = @"Data Source = PRSQL; Database=EmployeeDB;User ID = labuser; Password=Welcome123$";
            Objconn = new SqlConnection(strconn);
            string strcmdSelect = "Select * from Employees";
            ObjCmd = new SqlCommand(strcmdSelect, Objconn);
            da = new SqlDataAdapter();
            da.SelectCommand = ObjCmd;
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();


        }


        private void btn_display_typed_Click(object sender, EventArgs e)
        {
            DataSet1 etds = new DataSet1();
            da.Fill(etds, "Employees");
            tb_name.Text = etds.Employees[1].Name;
            //  etds.Employee[0].EmpId = "2";  // directly error as the type took is int and passed string
            //   da.Update(etds.Tables["Employee"]);
        }

        private void btn_display_untyped_Click(object sender, EventArgs e)
        {
            da.Fill(ds, "Employees");
            tb_name.Text = (string)ds.Tables["Employees"].Rows[0]["Name"];
            dgv_employee.DataSource = ds;
            dgv_employee.DataMember = "Employees";

        }

        private void btn_update_untyped_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["Employees"];
            DataRow row = dt.Rows[2];
            row["ID"] = "Bhushan"; // runtime exception showing while trying to fetch data from sql database
            da.Update(ds.Tables["Employees"]);
            MessageBox.Show((string)ds.Tables["Employees"].Rows[2]["ID"]);


        }
    }
}
