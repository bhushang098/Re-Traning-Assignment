using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Department
{
    public int DID { get; set; }
    public string Name { get; set; }
}

public class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public int DeptId { get; set; }
}

public class Student
{
    public string LastName { get; set; }
    public List<int> Scores { get; set; }
}
public class MainClass
{
    static void SimpleSelection()
    {
        // Select Number Less Than 5 and when divided by 2 having remidner 0

        // A Sample data Source

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 45, 93, 28, 23, 67, 354 };

        // create Query
        //lowNums is IEnumerable<int> 

        var lowNums = from num in numbers
                      where num < 5 && num % 2 == 0
                      select num;

        // Execute the query 
        foreach (int i in lowNums)
        {
            Console.WriteLine(i + " ");
        }

    }

    static void InnerJoin()
    {
        List<Department> departments = new List<Department>
        {
            new Department{DID=101,Name="Development"},
            new Department{DID=102,Name="Sales"},
            new Department{DID=103,Name="HR"}

        };

        List<Employee> employees = new List<Employee> {

            new Employee {EmpId = 201,Name = "Bhushan",DeptId=1},
            new Employee {EmpId = 202,Name = "kartik",DeptId=2},
            new Employee {EmpId = 203,Name = "kajal",DeptId=3},
            new Employee {EmpId = 204,Name = "Pratiksha",DeptId=3},
            new Employee {EmpId = 205,Name = "Pranay",DeptId=1}

        };

        // Inner Join 
        var innerJoinQuery = from emp in employees
                             join dept in departments on emp.DeptId equals dept.DID
                             select new { EmployeeName = emp.Name, DeptName = dept.Name };

        foreach (var emp in innerJoinQuery)
        {
            Console.Write(emp.EmployeeName + "\t");
            Console.WriteLine(emp.DeptName);
        }

    }

    static void GroupBy()
    {
        string[] Names = { "Bhushan", "Pratiksha", "karthick", "kajal", "Pranay", "Sitara" };

        var nameGropus = from name in Names
                         group name by name[0];

        foreach (var names in nameGropus)
        {
            Console.WriteLine("names that  starts with letter {0} : ", names.Key);

            foreach (string s in names)
            {
                Console.WriteLine(s);
            }
        }
    }

    static void UsingInTo()
    {
        string[] words = { "apple", "balls", "cat", "dog", "elephent", "fish" };

        var wordsGroup = from w in words
                         group w by w[0] into animals
                         where animals.Count() >= 2
                         select new
                         {
                             FirstLetter = animals.Key,
                             Count = animals.Count()
                         };

        foreach (var item in wordsGroup)
        {
            Console.WriteLine("{0} has {1} Elements. ", item.FirstLetter, item.Count);
        }

    }

    static void ConpoundForm()
    {
        List<Student> students = new List<Student>
        {
            new Student {LastName = "Bhushan",Scores = new List<int> {89,63,27,37}},
            new Student {LastName = "Kartik",Scores = new List<int> {84,39,77,39}},
            new Student {LastName = "Pratiksha",Scores = new List<int> {67,43,67,55}},
            new Student {LastName = "Kajal",Scores = new List<int> {99,66,62,43}},
            new Student {LastName = "Pranay",Scores = new List<int> {91,62,12,67}},
        };

        var scoreQuery = from student in students
                         from score in student.Scores
                         where score > 90
                         select new { Last = student.LastName, score };

        foreach (var stud in scoreQuery)
        {
            Console.WriteLine("{0} Score : {1}", stud.Last, stud.score);
        }

    }

    public static void Main(string[] args)
    {
        //SimpleSelection();
        //InnerJoin();
        //GroupBy();
        //UsingInTo();
        ConpoundForm();


    }
}