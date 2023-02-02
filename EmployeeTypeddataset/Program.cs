using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTypeddataset
{
    internal class Program
    {
        static void EmployeeDepartmentTypedDataset()
        {
            EmpDatSet eds = new EmpDatSet();
            EmpDatSetTableAdapters.EmployeesTableAdapter employeeTableAdapter = new EmpDatSetTableAdapters.EmployeesTableAdapter();
            employeeTableAdapter.Fill(eds.Employees);



            DepartmentDataSet ds = new DepartmentDataSet();
            DepartmentDataSetTableAdapters.DeptsTableAdapter departmentTableAdapter = new DepartmentDataSetTableAdapters.DeptsTableAdapter();
            departmentTableAdapter.Fill(ds.Depts);

            employeeTableAdapter.Fill(eds.Employees);
            departmentTableAdapter.Fill(ds.Depts);
            var query = from emp in eds.Employees
                        join dept in ds.Depts
                        on emp.ID equals dept.DeptId
                        orderby emp.ID
                        select new
                        {
                            Id = emp.ID,
                            Name = emp.Name,
                            Department = dept.DeptName
                        };




            Console.Write("Id\t");
            Console.Write("Name\t");
            Console.WriteLine("\tDepartmentName");
            Console.WriteLine("---------------------------------------------------");






            foreach (var e in query)
            {
                Console.Write("{0}\t", e.Id);
                Console.Write("{0}\t", e.Name);
                Console.WriteLine("{0}\t", e.Department);





            }
        }

        static void Main(string[] args)
        {
            EmployeeDepartmentTypedDataset();
        }
    }
}
