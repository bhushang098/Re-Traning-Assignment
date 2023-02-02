using System;
using System.Collections;
using System.Collections.Generic;

public class Employee
{
    public static int Id = 101;
    private int _EmpId;
    private string _EmpName;

    public int EmpId
    {
        get { return this._EmpId; }
    }

    public Employee(string name)
    {
        this._EmpId = Id++;
        this._EmpName = name;
    }

    public override string ToString()
    {
        return string.Format("Id : {0} \nName : {1} \n ------------------------\n", this._EmpId, this._EmpName);

    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        IEnumerator iEnum;
        ICollection col;

        List<Employee> emps = new List<Employee>();
        emps.Add(new Employee("Bhushan"));
        emps.Add(new Employee("Kartik"));
        emps.Add(new Employee("Pratiksha"));
        emps.Add(new Employee("Pranay"));
        emps.Add(new Employee("Kajal"));

        iEnum = emps.GetEnumerator();

        // Using Generic List 
        Console.WriteLine("--------Using Generic List-------");
         while(iEnum.MoveNext())
         {
             Console.WriteLine(iEnum.Current);
         }

        ArrayList arrayList = new ArrayList(5);

        foreach (Employee e in emps)
        {
            arrayList.Add(e);
        }

        iEnum = arrayList.GetEnumerator();

        // Using Array List 
        Console.WriteLine("--------Using Array List-------");
        while (iEnum.MoveNext())
         {
             Console.WriteLine(iEnum.Current);
         }

        SortedList sortedList = new SortedList(5);
        foreach (Employee e in emps)
        {
            sortedList.Add(e.EmpId, e);
        }

        iEnum = sortedList.GetEnumerator();
        col = sortedList.Values;

        // Using Sorted List 
        Console.WriteLine("--------Using Sorted List-------");
        foreach (Employee e in col)
        {
            Console.WriteLine(e);
        }

        Hashtable hashTable = new Hashtable();

        foreach (Employee e in emps)
        {
            hashTable.Add(e.EmpId, e);
        }

         col = sortedList.Values;

        // Using Hast Table List 
        Console.WriteLine("--------Using Hast Table-------");
        foreach (Employee e in col)
         {
             Console.WriteLine(e);
         }

    }
}


