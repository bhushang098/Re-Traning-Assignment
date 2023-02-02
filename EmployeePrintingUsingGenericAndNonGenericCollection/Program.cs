using System;
using System.Collections;
using System.Collections.Generic;



class Employee
{



    public static int num = 101;
    public readonly int _empId;
    private String _empName;



    //int _empSalary=0;



    public Employee()
    {
        this._empId = num++;
    }
    public Employee(String _empName)
    {
        this._empId = num++;
        this._empName = _empName;



    }
    public int EmployeeId
    {
        get
        {
            return _empId;
        }
    }




    public override String ToString()
    {



        return String.Format("Employee Id {0}\nEmployee Name {1}", this._empId, this._empName);




    }



}
class MainClass
{
    static void ArryList()
    {
        ArrayList arry = new ArrayList();
        arry.Add(new Employee("Sachin"));
        arry.Add(new Employee("Alok"));
        arry.Add(new Employee("Bhushan"));
        arry.Add(new Employee("Sarla"));
        arry.Add(new Employee("Rohan"));



        foreach (Employee e in arry)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine("---------------------------");
    }
    static void ListGeneric()
    {
        List<Employee> list = new List<Employee>();
        list.Add(new Employee("Sachin"));
        list.Add(new Employee("Nitin"));
        list.Add(new Employee("Mayank"));
        list.Add(new Employee("Manas"));
        list.Add(new Employee("Roshan"));



        foreach (Employee emp in list)
        {
            Console.WriteLine(emp);
        }
        Console.WriteLine("---------------------------");
    }
    static void SortedListImplementation()
    {
        Employee emp1 = new Employee("Hari");
        Employee emp2 = new Employee("Alok");
        Employee emp3 = new Employee("Mohit");
        Employee emp4 = new Employee("Santosh");
        Employee emp5 = new Employee("Harshit");
        SortedList sl = new SortedList();



        sl.Add(emp1.EmployeeId, emp1);
        sl.Add(emp2.EmployeeId, emp2);
        sl.Add(emp3.EmployeeId, emp3);
        sl.Add(emp4.EmployeeId, emp4);
        sl.Add(emp5.EmployeeId, emp5);



        ICollection c = sl.Values;
        foreach (object o in sl.Values)
        {
            Console.WriteLine(o);
        }
        Console.WriteLine("---------------------------");
    }
    static void EnumerablePrinting()
    {
        Employee[] emp = new Employee[5];
        emp[0] = new Employee("Hari");
        emp[1] = new Employee("Golu");
        emp[2] = new Employee("Alok");
        emp[3] = new Employee("Mohit");
        emp[4] = new Employee("Santosh");



        IEnumerable ens = emp;
        IEnumerator ia = ens.GetEnumerator();
        while (ia.MoveNext())
        {
            Console.WriteLine(ia.Current);
        }
        Console.WriteLine("---------------------------");
    }
    static void HashTableImplementation()
    {
        Employee emp1 = new Employee("Harry");
        Employee emp2 = new Employee("John");
        Employee emp3 = new Employee("Nina");
        Employee emp4 = new Employee("Santo");
        Employee emp5 = new Employee("Alfred");
        Hashtable h = new Hashtable();
        h.Add(emp1.EmployeeId, emp1);
        h.Add(emp2.EmployeeId, emp2);
        h.Add(emp3.EmployeeId, emp3);
        h.Add(emp4.EmployeeId, emp4);
        h.Add(emp5.EmployeeId, emp5);
        foreach (int i in h.Keys)
        {
            Console.WriteLine(h[i]);
        }
        ////  foreach (object o in h.Values)
        //  {
        //     Console.WriteLine(o);
        //  }
    }




    static void Main()
    {
        ArryList();
        ListGeneric();
        SortedListImplementation();
        EnumerablePrinting();
        HashTableImplementation();
    }
}