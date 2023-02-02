using System;

public class Employee : IDisposable
{
    public bool isDisposed;
    public int employeeId;
    public int salary;

    public int Salary
    {
        get
        {
            return this.salary;
        }
        set
        {
            this.salary = salary;
        }
    }
    public Employee(int id)
    {
        this.isDisposed = false;
        this.employeeId = id;
    }
    ~Employee()
    {
        if (!isDisposed)
        {
            this.Dispose();
        }
        Console.WriteLine("Object Destroyed for Id :{0}", this.employeeId);
    }
    public void workStatus()
    {
        if (this.isDisposed)
        {
            throw new ObjectDisposedException(this.employeeId.ToString(), "Employee has been terminated");
        }
        else
        {
            Console.WriteLine("Id :{0} is working properly", this.employeeId);
        }
    }
    public void IncrementSalary(int increment)
    {
        if (this.isDisposed)
        {
            throw new ObjectDisposedException(this.employeeId.ToString(), "Employee has been terminated");
        }
        else
        {
            Console.WriteLine("Salary Incremented for Id {0} ", this.employeeId);
            this.salary += increment;
        }

    }
    public void Dispose()
    {
        Console.WriteLine("Id {0} is being Disposed", this.employeeId);
        GC.SuppressFinalize(this);
        this.isDisposed = true;
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        using (Employee e1 = new Employee(1))
        {
            e1.Salary = 30000;
            e1.workStatus();
            e1.IncrementSalary(20000);
        }
        Console.WriteLine("*******************");
        using (Employee e2 = new Employee(2))
        {
            e2.Salary = 60000;
            e2.workStatus();
            e2.IncrementSalary(15000);

        }
        Console.WriteLine("------------------");
    }
}