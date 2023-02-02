// I Comparable  Employee
using System;

class Employee : IComparable
{
    private int ID;

    public Employee(int id)
    {
        this.ID = id;
    }

    public int CompareTo(object obj)
    {
        Employee emp = (Employee)obj;
        return this.ID.CompareTo(emp.ID);
    }
    public override string ToString()
    {
        return this.ID.ToString();
    }
}

public class MainClass
{




    public static void Main(string[] args)
    {
        int[] intArray = { 4, 1, 8, 3, 7, 6, 5 };
        Array.Sort(intArray);

        foreach (int i in intArray)
        {
            // Console.WriteLine(i);
        }

        Employee[] empArray = new Employee[10];
        for (int i = 10; i > 0; i--)
        {
            empArray[i - 1] = new Employee(i);
        }

        Array.Reverse(empArray);
        Array.Sort(empArray);

        foreach (Employee e in empArray)
        {
            Console.WriteLine(e);
        }
    }
}





