
using ExceptionLib;
using System;



public class Student
{
    private static int id = 1001;

    private int _ID;
    private string _Name;
    private int _Marks;

    public int ID
    {
        get { return this._ID; }
    }

    public Student(string name, int marks)
    {
        this._ID = id++;
        this._Name = name;

        if (marks < 0)
            throw new MarksNegativeException("You Entered Negative Marks for Student");

        if (marks > 100)
            throw new MarksOverException("Marks Over Exception Occured : Enter marks less than 100");

        this._Marks = marks;

    }

    public void printMarksheet()
    {
        Console.WriteLine(" ID : {0} \n Name : {1} \n Marks : {2} ", this._ID, this._Name, this._Marks);

    }

}

public class StudentHolder
{

    byte counter;
    static Student[] students;

    public StudentHolder()
    {
        counter = 0;
        students = new Student[10];
    }

    public Student createStudent(string studentName, int marks)
    {
        Student newStudnet = new Student(studentName, marks);
        students[counter++] = newStudnet;
        return newStudnet;
    }

    public void printMarksheets()
    {
        foreach (Student student in students)
        {
            if (student != null)
            {
                student.printMarksheet();
            }
            else
            {
                break;
            }
        }
    }

    public void printMarksheet(int id)
    {
        Student s = getStudent(id);
        if (s != null)
        {
            s.printMarksheet();
        }

    }

    public static Student getStudent(int id)
    {
        foreach (Student s in students)
        {
            if (s != null)
            {
                if (s.ID == id)
                {
                    return s;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                return null;
            }
        }
        return null;
    }
    public bool isValidStudent(int id)
    {
        foreach (Student s in students)
        {
            if (s != null)
            {
                if (s.ID == id)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                return false;
            }
        }
        return false;
    }

}

public class MainClass
{
    static bool toBeContuned = true;

    public static void Main(string[] args)
    {
        StudentHolder studentHolder = new StudentHolder();
        int id = 0;

        Console.Write("Which Operation To Perform ? \n 1 : Create Student \n 2: Print marksheet of perticular student \n 3 : Print All Marksheets \n 4 : Exit \n");

        while (true)
        {

            Console.WriteLine("Enter Choice :  ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1://Create Student 
                    Console.WriteLine("Enter Name Of Student : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Marks : ");
                    int marks = int.Parse(Console.ReadLine());
                    try
                    {
                        Student stud = studentHolder.createStudent(name, marks);
                        Console.WriteLine("Student Added with ID : {0}", stud.ID);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
                case 2: // Print Result of an student
                    Console.WriteLine("Enter ID of The Student To Print Result");
                    id = int.Parse(Console.ReadLine());
                    if (studentHolder.isValidStudent(id))
                    {
                        studentHolder.printMarksheet(id);
                    }
                    else
                    {
                        Console.WriteLine("Please  Enter Valid Roll Number");
                    }
                    break;
                case 3: //Print All student Result
                    studentHolder.printMarksheets();
                    break;
                case 4:
                    toBeContuned = false;
                    break;
                default:
                    toBeContuned = false;
                    break;
            }
            if (!toBeContuned)
            {
                break;
            }

        }

    }
}