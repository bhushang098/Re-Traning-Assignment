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

namespace Connected_1Method_Two_Buttons
{
    public partial class Form1 : Form
    {
        string strConn;
        SqlConnection objConn;
        string Cmd;
        SqlCommand objCmd;
        SqlDataReader dr;
        bool flag;
        public Form1()
        {
            InitializeComponent();
            strConn = @"Data Source=PRSQL;Initial Catalog=EmployeeDB;User ID=labuser;Password=Welcome123$";
            objConn = new SqlConnection(strConn);
            Cmd = @"Select * From Employees";



            objCmd = new SqlCommand();
            objCmd.Connection = objConn;
            objCmd.CommandText = Cmd;



            objConn.Open();
            dr = objCmd.ExecuteReader();
            flag = true;
        }
        private void End()
        {
            dr.Close();
            objConn.Close();
        }




        private void btn_diaplay_Click(object sender, EventArgs e)
        {
            if (sender == btn_diaplay)
            {
                if (flag)
                {
                    if (objConn.State == ConnectionState.Closed)
                    {
                        objConn.Open();
                        dr = objCmd.ExecuteReader();
                    }
                    if (dr.Read())
                    {
                        tb_id.Text = dr["ID"].ToString();
                        tb_name.Text = dr["Name"].ToString();
                        tb_salary.Text = dr["Salary"].ToString();

                        flag = false;
                    }
                }

            }
            else if (sender == btn_next)
            {
                if (dr != null && !dr.IsClosed)
                {
                    if (dr.Read())
                    {
                        tb_id.Text = dr["ID"].ToString();
                        tb_name.Text = dr["Name"].ToString();
                        tb_salary.Text = dr["Salary"].ToString();

                    }
                    else
                    {
                        End();
                        MessageBox.Show("All Records Displayed");
                    }
                }
                else
                {
                    MessageBox.Show("Click Display button First");
                    flag = true;
                }
            }
        }

        private void btn_populate_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;
            dataGridView1.Columns["ID"].HeaderText = "EmpID";
            dataGridView1.Columns["Name"].HeaderText = "EmpName";
        }
    }
}
