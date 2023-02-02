using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connected_Operations
{
    public partial class frm_employee : Form
    {
        string strconn = @"Data Source=PRSQL;User ID=labuser;Password=Welcome123$;Initial Catalog=EmployeeDB;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlConnection conn;
        SqlCommand selectcmd;
        SqlCommand insertcmd;
        SqlCommand updatecommand;
        SqlCommand deletecmd;

        string strcmd;
        string strselect;
        string strinsert;


        SqlDataReader dr;

        bool flag = true;

        public frm_employee()
        {
            InitializeComponent();
            conn = new SqlConnection(strconn);
            selectcmd = new SqlCommand();
            insertcmd = new SqlCommand();
            updatecommand = new SqlCommand();
            deletecmd = new SqlCommand();

            strselect = @"select * from Employees";
           
            selectcmd.Connection = conn;
            selectcmd.CommandType = CommandType.Text;
            selectcmd.CommandText = strselect;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Update
            strcmd = @"Update  Employees Set Name = " + "'" + tb_name.Text + "'" + "," + " Salary = " + "'" + tb_salary.Text + "'" + " Where ID = " + "'" + tb_id.Text + "'";

            updatecommand.CommandText = strcmd;
            updatecommand.Connection = conn;
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (dr != null && !dr.IsClosed)
            {
                dr.Close();
            }
           
            int i = updatecommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(i + " Records Updated");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Select
            if(flag)
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    dr = selectcmd.ExecuteReader();
                }
                if(dr.Read())
                {
                    tb_id.Text = dr["ID"].ToString();
                    tb_name.Text = dr["Name"].ToString();
                    tb_salary.Text = dr["Salary"].ToString();
                    tb_did.Text = dr["DID"].ToString();
                    flag = false;

                }
            }
            else
            {
                // Only once clicked Works 
            }
        }

        private void btn_populate_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (dr != null && !dr.IsClosed)
            {
               
            }
            else
            {
                dr = selectcmd.ExecuteReader();
            }

            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_employees.DataSource = dt;

            dr.Close();
            conn.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            strcmd = @"Delete From Employees Where ID = '" + tb_id.Text + "'";
          
            deletecmd.CommandText = strcmd;
            deletecmd.Connection = conn;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (dr != null && !dr.IsClosed)
            {
                dr.Close();
            }
            int i = deletecmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(i + " Rows Deleted");

        }

        private void frm_employee_Load(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            this.strinsert = @"insert into Employees values('" + tb_name.Text + "','" + tb_salary.Text + "','" + tb_did.Text + "')";
            insertcmd.CommandText = strinsert;
            insertcmd.Connection = conn;

            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if(dr!=null && ! dr.IsClosed)
            {
                dr.Close();
            }
            MessageBox.Show(insertcmd.ExecuteNonQuery().ToString() + " Records Inserted");
            conn.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(dr!=null && ! dr.IsClosed)
            {
                if(dr.Read())
                {
                    tb_id.Text = dr["ID"].ToString();
                    tb_name.Text = dr["Name"].ToString();
                    tb_salary.Text = dr["Salary"].ToString();
                    tb_did.Text = dr["DID"].ToString();
                }
                else
                {
                    dr.Close();
                    conn.Close();
                    MessageBox.Show("All Records Displayed");
                }
            }
            else
            {
                MessageBox.Show("Click select Button First");
            }
        }
    }
}
