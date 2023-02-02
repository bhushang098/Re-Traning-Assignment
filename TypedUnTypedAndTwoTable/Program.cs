using System;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using TypedUnTypedAndTwoTable.EmployeeDatasetTableAdapters;

namespace TypedUnTypedAndTwoTable
{
    internal class Program
    {
        public static void UnTypedDatSet()
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
            Console.Write("ID \t Name \t Salary \t DepartMent");
            Console.WriteLine("\n --------------------------");

            foreach (var e in query)
            {
                //Console.WriteLine(e.DID);
                Console.WriteLine("{0} \t {1} \t {2} \t {3}", e.ID, e.Name, e.Salary, e.DID);
            }


        }
        
        public static void TypeddatSet()
        {
            EmployeeDataset eds = new EmployeeDataset();
            EmployeeDatasetTableAdapters.EmployeesTableAdapter employeeTableAdapter = new EmployeeDatasetTableAdapters.EmployeesTableAdapter();
           // EmployeeDatasetTableAdapters.EmployeeTableAdapter employeeTableAdapter = new EmployeeDatasetTableAdapters.EmployeeTableAdapter();
            employeeTableAdapter.Fill(eds.Employees);




            var query = from emp in eds.Employees
                        select new
                        {
                            EmpId = emp.ID,
                            EmpName = emp.Name,
                            EmpSalary = emp.Salary,
                            DeptId = emp.DID
                        };


            // EmployeeDataset.EmployeeRow row =  eds.Employee.NewEmployeeRow();
            // row.EmpName = "Sachin";
            // row.EmpSalary = 45000;
            // row.DeptId = 2;
            // eds.Employee.Row.add(row);
            // employeeTableAdapter.Update(eds.Employee);



            Console.Write("Id\t");
            Console.Write("Name\t");
            Console.Write("\tSalary\t");
            Console.WriteLine("\tDeptId");
            Console.WriteLine("---------------------");



            foreach (var e in query)
            {
                Console.Write("{0}\t", e.EmpId);
                Console.Write("{0}\t", e.EmpName);
                Console.Write("{0}\t", e.EmpSalary);
                Console.WriteLine("{0}", e.DeptId);
            }

        }

        static void TwoTableQuery()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = objConn.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter();



            string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            objConn.ConnectionString = strConn;
            string Cmd = @"Select * From Employees";
            objCmd.Connection = objConn;
            objCmd.CommandText = Cmd;



            DataSet ds = new DataSet();
            da.SelectCommand = objCmd;
            da.Fill(ds, "Employees");
            DataTable dt = ds.Tables["Employees"];



            Cmd = @"Select * From Departments";
            objCmd.CommandText = Cmd;
            da.Fill(ds, "Departments");
            DataTable dt2 = ds.Tables["Departments"];



            var query =
                from Employee in dt.AsEnumerable()
                join Department in dt2.AsEnumerable()
                on Employee.Field<Int16>("DID") equals
                Department.Field<Int16>("DID")
                orderby Department.Field<Int16>("DID")
                select new
                {
                    EmployeeID = Employee.Field<Int16>("ID"),
                    EmployeeName = Employee.Field<string>("Name"),
                    EmployeeSalary = Employee.Field<decimal>("Salary"),
                    DepartmentName = Department.Field<string>("DeptName")
                };
            foreach (var data in query)
            {
                Console.WriteLine("EmployeeID={0}", data.EmployeeID);
                Console.WriteLine("EmployeeName={0}", data.EmployeeName);
                Console.WriteLine("EmployeeSalary={0}", data.EmployeeSalary);
                Console.WriteLine("DepartmentName={0}", data.DepartmentName);
                Console.WriteLine("--------------------------------------------------");
            }



        }

        static void TwoTableTypedQuery()
        {
            EmployeesTableAdapter employeesTableAdapter = new EmployeesTableAdapter();
            DepartmentDatasetTableAdapters.DeptsTableAdapter departmentsTableAdapter = new DepartmentDatasetTableAdapters.DeptsTableAdapter();
            EmployeeDataset ds1 = new EmployeeDataset();
            DepartmentDataset ds2 = new DepartmentDataset();
            employeesTableAdapter.Fill(ds1.Employees);
            departmentsTableAdapter.Fill(ds2.Depts);
            var query = from emp in ds1.Employees
                        join dept in ds2.Depts
                        on emp.DID equals dept.DeptId
                        orderby emp.DID
                        select new
                        {

                            Name = emp.Name,
                            Department = dept.DeptName
                        };

            Console.Write("Name\t");
            Console.WriteLine("\tDepartment");
            Console.WriteLine("---------------------------------------------------");




            foreach (var e in query)
            {
                Console.Write("{0}\t", e.Name);
                Console.WriteLine("{0}\t", e.Department);



            }
        }

        static void Main(string[] args)
        {
            UnTypedDatSet();
            TypeddatSet();
        }
    }
}
