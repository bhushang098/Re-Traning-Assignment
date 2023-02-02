using CustomerLibrary;
using DelegateLibrary;
using EmployeeLibrary;
using PrinterLibrary;
using StudentLibrary;

public class MainClass
{
    public static void Main(string[] args)
    {

        Employee emp = new Employee(12, "Bhushan");
        Student stud = new Student(11, "Pranay");
        Customer cust = new Customer(10, "Pratiksha");

        PrintDelegate dl = new PrintDelegate(emp.Display);
        dl += stud.Display;
        dl += cust.Display;

        Printer.Print(dl);

    }
}