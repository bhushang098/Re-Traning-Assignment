using System;

public class Employee
{
    public int ID;
    public Employee(int id)
    {
        this.ID = id;
        Console.WriteLine("Constructor For Employee : {0}", this.ID);
    }
    ~Employee()
    {
        Console.WriteLine("Destructor For Employee : {0}", this.ID);
    }
}
public class MainClass
{
    public static void Main(string[] args)
    {
        Employee obj;
        for (int i = 0; i < 10; i++)
        {
            if (i % 10 == 0)
            {
                Console.WriteLine("----------------------");
                GC.Collect();
            }
            obj = new Employee(i + 1);
        }
        Console.WriteLine("******************************");
    }
}