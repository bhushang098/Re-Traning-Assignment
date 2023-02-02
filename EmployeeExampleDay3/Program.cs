
using EmployeeExampleDay3;
using System;


public class MainClass
{
    static float basic, da, hra;
    static string employeeName;
    public static void Main(string[] args)
    {
        Console.WriteLine("#### Menu #### \n 1 : Join New  Employee \n 2 : Print Salary Slip of an employee \n 3 : Print All Salary Slips \n 4 : Exit \n ");

        EmployeeHolder empHolder = new EmployeeHolder();

        do
        {
            Console.WriteLine("Enter your Choice");
            int choice = int.Parse(Console.ReadLine());
            if (choice is int)
            {
                switch (choice)
                {
                    case 1:// Add Emplyee 
                        Input();
                        empHolder.AddEmployee(new Employee(employeeName, basic, da, hra));
                        break;
                    case 2: // Print salary Slip of an employee
                        Console.WriteLine("Enter ID of an employee to Print Salary Slip");
                        int id = int.Parse(Console.ReadLine());
                        empHolder.PrintSalarySlip(id);
                        break;
                    case 3: // Print All Salary Slips
                        empHolder.PrintSalarySlips();
                        break;
                    case 4:
                        break;
                    default:
                        break;

                }

            }
            else
            {
                Console.WriteLine("Please Enter Input Again");
                continue;
            }

            Console.WriteLine("Do yoy wish to Continue Y|N ");

        } while (Console.ReadLine() == "y" || Console.ReadLine() == "Y");

    }

    public static void Input()
    {
        Console.WriteLine("Enter Name of The New Employee");
        employeeName = Console.ReadLine();

        Console.WriteLine("Enter basic Salary of {0} :", employeeName);
        basic = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter Dearence Allowance of the Employee {0} : ", employeeName);
        da = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter House Rent Allowance for New Employee {0} : ", employeeName);
        hra = float.Parse(Console.ReadLine());

    }

}

