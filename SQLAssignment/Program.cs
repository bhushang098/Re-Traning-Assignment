using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SQLAssignment
{
    public class Program
    {
        static EmployeeDBEntities mdc = new EmployeeDBEntities();
        static Employee SelectEmployeesDetailsWithEmpId(int id)
        {
            List<Employee> list = (from emp in mdc.Employees
                                   where emp.ID == id
                                   select emp).ToList<Employee>();
            return list[0];
        }
        static List<Employee> SelectAllEmployees()
        {
            return (from emp in mdc.Employees
                    select emp).ToList<Employee>();
        }

        static List<Employee> SelectEmployeeWithDepartmentId(int id)
        {

            return (from emp in mdc.Employees
                    where emp.DID == id
                    select emp).ToList<Employee>();

        }
        static List<Employee> SelectEmployeeByGender(char gender)
        {

            return (from emp in mdc.Employees
                    where emp.DID.Equals(gender)
                    select emp).ToList<Employee>();

        }
        static void UpdateEmployeeByName(int id, string Name) //int id
        {
            // Console.WriteLine("Enter Employee Id");
            // int id = int.Parse(Console.ReadLine());
            // int id = int.Parse(Console.ReadLine());

            List<Employee> list = (from emp in mdc.Employees
                                   where emp.ID == id
                                   select emp).ToList<Employee>();

            //  Name;
            // string gender = "M";
            // decimal salary = 36987;
            //  DateTime dob = new DateTime(2000, 05, 09);
            //  DateTime doj = DateTime.Now;
            //  int pid = 4;// did = 1;
            // Employee emp1 = new Employee();

            list[0].Name = Name;
            // emp.EmpGender = gender;
            // list[0].EmpSalary = salary;
            //  emp.EmpDoj = doj;
            //emp.EmpDob = dob;
            // list[0].ProjectId = pid;
            // emp.DeptId = did;

            // mdc.Employees.Up(emp);
            mdc.SaveChanges();
            Console.WriteLine("Employee Name of EmpId {0} Updated Successfully", list[0].ID);



        }
        static void UpdateEmployeeBySalary(int id, decimal Salary) //int id
        {
            // Console.WriteLine("Enter Employee Id");
            // int id = int.Parse(Console.ReadLine());
            // int id = int.Parse(Console.ReadLine());

            List<Employee> list = (from emp in mdc.Employees
                                   where emp.ID == id
                                   select emp).ToList<Employee>();

            // string Name = "Rohit Sardana";
            // string gender = "M";
            //decimal salary = 36987;
            //  DateTime dob = new DateTime(2000, 05, 09);
            //  DateTime doj = DateTime.Now;
            //  int pid = 4;// did = 1;
            // Employee emp1 = new Employee();

            //  list[0].EmpName = Name;
            // emp.EmpGender = gender;
            list[0].Salary = Salary;
            //  emp.EmpDoj = doj;
            //emp.EmpDob = dob;
            //  list[0].ProjectId = pid;
            // emp.DeptId = did;

            // mdc.Employees.Up(emp);
            mdc.SaveChanges();
            Console.WriteLine("Employee Salary of EmpId {0} Updated Successfully", list[0].ID);



        }
        static void UpdateEmployeeByProject(int id, int PID) //int id
        {
            // Console.WriteLine("Enter Employee Id");
            // int id = int.Parse(Console.ReadLine());
            // int id = int.Parse(Console.ReadLine());

            List<Employee> list = (from emp in mdc.Employees
                                   where emp.ID == id
                                   select emp).ToList<Employee>();

            //  string Name = "Rohit Sardana";
            // string gender = "M";
            //  decimal salary = 36987;
            //  DateTime dob = new DateTime(2000, 05, 09);
            //  DateTime doj = DateTime.Now;
            // int pid = 4;// did = 1;
            // Employee emp1 = new Employee();

            // list[0].EmpName = Name;
            // emp.EmpGender = gender;
            //   list[0].EmpSalary = salary;
            //  emp.EmpDoj = doj;
            //emp.EmpDob = dob;
            list[0].ID = PID;
            // emp.DeptId = did;

            // mdc.Employees.Up(emp);
            mdc.SaveChanges();
            Console.WriteLine("Employee Project of EmpId {0} Updated Successfully", list[0].ID);



        }

        static void InsertEmployee()
        {
            /*
               string Name;
               string gender;
               decimal salary;
               DateTime dob;// = new DateTime(2000,05,09);
               DateTime doj;// =  DateTime.Now;
               int pid, did; */
            Employee emp = new Employee();

            emp.Name = Name;

            emp.Salary = Salary;


            emp.DID = 1;

            mdc.Employees.Add(emp);
            mdc.SaveChanges();

            Console.WriteLine("Employee with EmpId {0} Insterted Successfully", emp.ID);


        }


        static void SelectMostAndLeastEmployeeByExp()
        {

            List<Employee> Empexperience = (from emp in mdc.Employees
                                            orderby emp.ID descending
                                            select emp).ToList<Employee>();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Most Experienced Employee details");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("ID ={0}\t", Empexperience[0].ID);
            Console.WriteLine("\nName ={0}\t", Empexperience[0].Name);
            Console.WriteLine("\nSalary ={0}\t", Empexperience[0].Salary);

            Console.WriteLine("\nDeptId ={0}", Empexperience[0].DID);
            Console.WriteLine();

            Empexperience = (from emp in mdc.Employees
                             orderby emp.ID descending
                             select emp).ToList<Employee>();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Least Experienced Employee details ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("ID ={0}\t", Empexperience[0].ID);
            Console.WriteLine("\nName ={0}\t", Empexperience[0].Name);
            Console.WriteLine("\nSalary ={0}\t", Empexperience[0].Salary);

            Console.WriteLine("\nDeptId ={0}", Empexperience[0].DID);

        }

        static void DeleteEmployee(int id)//int id
        {
            // Console.WriteLine("Enter Employee Id");
            //  int id = int.Parse(Console.ReadLine());
            List<Employee> list = (from emp in mdc.Employees
                                   where emp.ID == id
                                   select emp).ToList<Employee>();

            mdc.Employees.Remove(list[0]);
            mdc.SaveChanges();

            Console.WriteLine("Employee with empId {0} Deleted Successfully", list[0].ID);
        }
        static List<Employee> SelectEmployeeByIncreasingSalary()
        {

            return (from emp in mdc.Employees
                    orderby emp.Salary
                    select emp).ToList<Employee>();

        }

        static void PrintingDepartmentMinMaxAndTotalSalary(int id)
        {
            decimal sum = 0;
            // Console.WriteLine("Enter Department Id");
            // int id = int.Parse(Console.ReadLine());

            List<decimal> sal = (from emp in mdc.Employees
                                 where emp.DID == id
                                 orderby emp.Salary.Value
                                 select emp.Salary.Value).ToList<decimal>();
            Console.WriteLine("Minimum Salary is {0}", sal[0]);

            sal = (from emp in mdc.Employees
                   where emp.DID == id
                   orderby emp.Salary.Value descending
                   select emp.Salary.Value).ToList<decimal>();
            Console.WriteLine("Maximum Salary is {0}", sal[0]);
            foreach (decimal d in sal)
            {
                sum += d;

            }
            Console.WriteLine("Total Salary is {0}", sum);

        }


        static List<Employee> SelectEmployeeByDOB()
        {

            return (from emp in mdc.Employees
                    orderby emp.DID descending
                    select emp).ToList<Employee>();

        }
        static void SelectEmployeeNameProjectNameAndDeptName()
        {

            var query = from emp in mdc.Employees
                        join dept in mdc.Depts
                        on emp.DID equals dept.DeptId
                        join pro in mdc.Depts on
                        emp.DID equals pro.DeptId
                        select new
                        {
                            EmpName = emp.Name,
                            DeptName = dept.DeptName,
                            

                        };

            Console.Write("Employee Name\t");
            Console.Write("\tDepartment Name");
            Console.WriteLine("\t\tProject Name");
            Console.WriteLine("---------------------------------------------------------------");


            foreach (var e in query)
            {
                Console.Write("{0}\t", e.EmpName);
                Console.Write("\t{0}\t", e.DeptName);
               

            }

        }

        static List<Employee> SelectEmployeeWorkindInSameProjectId(int id)
        {

            return (from emp in mdc.Employees
                    where emp.DID == id
                    select emp).ToList<Employee>();

        }
        static void PrintEmployeeDOBWise()
        {
            foreach (var e in SelectEmployeeByDOB())
            {
                Console.WriteLine("ID ={0}\t", e.ID);
                Console.WriteLine("\nName ={0}\t", e.Name);
                Console.WriteLine("\nSalary ={0}\t", e.Salary);
              

            }
        }
        static void PrintEmployeeSalaryWise()
        {
            foreach (var e in SelectEmployeeByIncreasingSalary())
            {
                Console.WriteLine("ID ={0}\t", e.ID);
                Console.WriteLine("\nName ={0}\t", e.Name);
                Console.WriteLine("\nSalary ={0}\t", e.Salary);


                Console.WriteLine("-------------------------------");

            }
        }
        static void PrintEmployeeAccToGender(char gender)

        {
            // Console.WriteLine("Enter Gender");
            //  char gender = char.Parse(Console.ReadLine());

            foreach (var e in SelectEmployeeByGender(gender))
            {
                Console.WriteLine("ID ={0}\t", e.ID);
                Console.WriteLine("\nName ={0}\t", e.Name);
                Console.WriteLine("\nSalary ={0}\t", e.Salary);


                Console.WriteLine("-------------------------------");

            }
        }

        static void PrintEmployeeDetails(int id)
        {
            //  Console.WriteLine("Enter Employee Id");
            //  int id = int.Parse(Console.ReadLine());
            var e = SelectEmployeesDetailsWithEmpId(id);

            Console.WriteLine("ID ={0}\t", e.ID);
            Console.WriteLine("\nName ={0}\t", e.Name);
            Console.WriteLine("\nSalary ={0}\t", e.Salary);


            Console.WriteLine("-------------------------------");


        }
        static void PrintAllEmployeeQuery()
        {
            foreach (var e in SelectAllEmployees())
            {
                Console.WriteLine("ID ={0}\t", e.ID);
                Console.WriteLine("\nName ={0}\t", e.Name);
                Console.WriteLine("\nSalary ={0}\t", e.Salary);


                Console.WriteLine("-------------------------------");

            }
        }
        static void PrintDeptQuery(int id)
        {
            // Console.WriteLine("Enter Department Id");
            // int id = int.Parse(Console.ReadLine());
            // PrintDeptQuery(id);
            foreach (var e in SelectEmployeeWithDepartmentId(id))
            {
                Console.WriteLine("ID ={0}\t", e.ID);
                Console.WriteLine("\nName ={0}\t", e.Name);
                Console.WriteLine("\nSalary ={0}\t", e.Salary);


                Console.WriteLine("--------------------------------------");
            }
        }
        static void PrintProjectQuery(int id)
        {
            // Console.WriteLine("Enter Project Id");
            // int id = int.Parse(Console.ReadLine());
            // PrintDeptQuery(id);
            foreach (var e in SelectEmployeeWorkindInSameProjectId(id))
            {
                Console.WriteLine("ID ={0}\t", e.ID);
                Console.WriteLine("\nName ={0}\t", e.Name);
                Console.WriteLine("\nSalary ={0}\t", e.Salary);


                Console.WriteLine("--------------------------------------");
            }
        }

        static byte choice, selectChoice, updateChoice;
        static string Name;
        static char option;
        static decimal Salary;
        static DateTime dob, doj;
        static int PID, DID, ID;
        static char Gender;
        static string gender;


        static void Menu()
        {
            do
            {
                Console.Write("Select an option: \n1.Select Based on Requirements \n2.Insert an Employee \n3.Update Employee Details \n4.Delete An Employee \n5. Exit\nYour Choice: ");
                choice = byte.Parse(Console.ReadLine());



                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Select an Option \n1.Select All Employees \n2.Select Employees Based on Gender \n3.Select Employees Based on Department \n4.Select Employees Based on Projects \n5.Order Employees Based on their Age \n6.Order Employees Based on their Salary \n7.Find Min,Max and Total Salary From a department \n8.Find The Most And Least Experienced Employee \n9.Select Employee by ID \n10.Print Employee Name,Department Name,Project Name");
                        selectChoice = byte.Parse(Console.ReadLine());
                        switch (selectChoice)
                        {
                            case 1:

                                PrintAllEmployeeQuery();

                                break;
                            case 2:
                                Console.Write("Enter Gender By Which YOu Want To Filter(M/F): ");
                                Gender = char.Parse(Console.ReadLine());
                                PrintEmployeeAccToGender(Gender);


                                break;



                            case 3:
                                Console.Write("Select Department By ID \n 1.Hr \n2.Admin \n3.Software \n4.Sales");
                                DID = int.Parse(Console.ReadLine());
                                PrintDeptQuery(DID);
                                break;



                            case 4:
                                Console.Write("Select Project By ID \n 1.Addidas \n2.Deloitte \n3.Amazon \n4.Dassault \n5.Starbucks \n6.Byjus");
                                PID = int.Parse(Console.ReadLine());
                                PrintProjectQuery(PID);
                                break;



                            case 5:

                                PrintEmployeeDOBWise();

                                break;



                            case 6:

                                PrintEmployeeSalaryWise();

                                break;



                            case 7:
                                Console.Write("Select Department By ID \n 1.Hr \n2.Admin \n3.Software \n4.Sales");
                                DID = int.Parse(Console.ReadLine());
                                PrintingDepartmentMinMaxAndTotalSalary(DID);
                                break;



                            case 8:

                                SelectMostAndLeastEmployeeByExp();

                                break;



                            case 9:
                                Console.WriteLine("Enter Employee ID: ");
                                ID = int.Parse(Console.ReadLine());
                                PrintEmployeeDetails(ID);

                                break;



                            case 10:

                                SelectEmployeeNameProjectNameAndDeptName();

                                break;
                        }
                        break;

                    case 2:
                        Console.Write("Enter Employee Name: ");
                        Name = Console.ReadLine();
                        Console.Write("Enter Employee Salary: ");
                        Salary = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter Employee Gender (M/F): ");
                        gender = Console.ReadLine();
                        Console.Write("Enter Employee DOB: ");
                        dob = Convert.ToDateTime(Console.ReadLine());
                        doj = DateTime.Now;
                        Console.Write("Enter Project ID: ");
                        PID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Department ID: ");
                        DID = Convert.ToInt32(Console.ReadLine());
                        InsertEmployee();
                        break;
                    case 3:
                        Console.WriteLine("Enter Employee ID");
                        ID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Which Field To Update: \n1.Name \n2.Salary \n3.Project \nEnter: ");
                        updateChoice = byte.Parse(Console.ReadLine());
                        switch (updateChoice)
                        {
                            case 1:
                                Console.WriteLine("Enter the Name you want to choose");
                                Name = Console.ReadLine();
                                UpdateEmployeeByName(ID, Name);

                                break;



                            case 2:
                                Console.WriteLine("Enter the New Updated Salary");
                                Salary = decimal.Parse(Console.ReadLine());
                                UpdateEmployeeBySalary(ID, Salary);

                                break;



                            case 3:
                                Console.WriteLine("Enter the New Updated ProjectId");
                                PID = int.Parse(Console.ReadLine());
                                UpdateEmployeeByProject(ID, PID);

                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Employee ID To Delete");
                        ID = Convert.ToInt32(Console.ReadLine());
                        DeleteEmployee(ID);
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using our services !");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Kindly ! Enter a valid option");
                        break;
                }
                Console.WriteLine("Continue?(Y/N): ");
                option = char.Parse(Console.ReadLine());
            } while (option == 'Y' || option == 'y');
        }
        static void Main(string[] args)
        {
            Menu();
            // PrintQuery();
            // PrintDeptQuery();
            //  PrintProjectQuery();
            //PrintEmployeeDetails();
            //PrintEmployeeAccToGender();
            // PrintEmployeeSalaryWise();
            // PrintEmployeeDOBWise();
            //SelectEmployeeNameProjectNameAndDeptName();
            // PrintingDepartmentMinMaxAndTotalSalary();
            // SelectMostAndLeastEmployeeByExp();
            // DeleteEmployee();
            //InsertEmployee();
            // UpdateEmployee();

        }

    }
}

