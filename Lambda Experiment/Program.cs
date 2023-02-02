class MainClass
{
    static void GetEmployee(List<Employee> employeeList)
    {
        //   var empl = employeeList.FindAll((Employee emp) =>
        //{
        //    return emp.Salary < 10000;
        //});
        var empl = employeeList.FindAll((e) => { return e.Salary < 10000; });
        foreach (Employee emp in empl)
        {
            Console.WriteLine(emp);
            Console.WriteLine("------------------------------------------");
        }

    }
    static void SortPrint(List<Employee> employeeList)
    {
        employeeList.Sort();
        employeeList.ForEach(e => Console.WriteLine(e + "\n-------------------------------"));


    }
    static void RemoveEmployee(List<Employee> employeeList)
    {
        // employeeList.RemoveAll((Employee emp) =>
        //{
        //    return emp.Salary > 30000;
        //});
        employeeList.RemoveAll((e) => { return e.Salary > 30000; });



        foreach (Employee e in employeeList)
        {
            Console.WriteLine(e);
            Console.WriteLine("---------------------------------");
        }




    }




    //static void Sort()
    static void Main()
    {
        var empList = new List<Employee>()
            {
                new Employee{EmpId=101,EmpName="Alok",Salary=50000},
                new Employee{EmpId=102,EmpName="Blok",Salary=5000},
                new Employee{EmpId=103,EmpName="Clok",Salary=9000},
                new Employee{EmpId=104,EmpName="Dlok",Salary=10000},
                new Employee{EmpId=105,EmpName="Elok",Salary=40000},
            };
        //empList.Add(new Employee());
        //empList.Add(new Employee());
        //empList.Add(new Employee());
        //empList.Add(new Employee());
        //empList.Add(new Employee());



        //empList[0].EmpId = 101; empList[0].EmpName = "alok"; empList[0].Salary = 500000;
        //empList[1].EmpId = 102; empList[1].EmpName = "blok"; empList[1].Salary = 300000;
        //empList[2].EmpId = 103; empList[2].EmpName = "clok"; empList[2].Salary = 20000;
        //empList[3].EmpId = 104; empList[3].EmpName = "dlok"; empList[3].Salary = 9000;
        //empList[4].EmpId = 105; empList[4].EmpName = "elok"; empList[4].Salary = 5000;



        GetEmployee(empList);
        Console.WriteLine("==========================================");
        SortPrint(empList);
        Console.WriteLine("==========================================");
        RemoveEmployee(empList);
        Console.WriteLine("==========================================");
    }
}