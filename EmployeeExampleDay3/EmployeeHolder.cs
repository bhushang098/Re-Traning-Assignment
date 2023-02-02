using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExampleDay3
{
    internal class EmployeeHolder
    {
        private Employee[] employees;
        private byte counter;

        public EmployeeHolder()
        {
            counter = 0;
            employees = new Employee[10];
        }

        public void AddEmployee(Employee e)
        {
            e.calculatSalary();
            employees[counter++] = e;
        }

        public void PrintSalarySlips()
        {
            foreach (Employee e in employees)
            {
                if (e != null)
                {
                    Console.WriteLine(e.PrintSalarySlip());
                    Console.WriteLine("-----------------------------------------------------");
                }
                else
                {
                    break;
                }
            }
        }

        public void PrintSalarySlip(int empId)
        {
            foreach (Employee e in employees)
            {
                if (e != null)
                {
                    if (e.EmpId == empId)
                    {
                        Console.WriteLine(e.PrintSalarySlip());
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Employee with Id {0} Not Found", empId);
                    break;
                }
            }
        }
    }
}
