using System;

public class Student
{
    private int _rollNumber;
    private string _name;
    private string _class;
    private string _sme;
    private string _branch;
    private int[] _marks;

    public Student(int rollNo, string name, string sclass, string sme, string branch, int[] marks)
    {
        this._rollNumber = rollNo;
        this._name = name;
        this._class = sclass;
        this._sme = sme;
        this._branch = branch;
        this._marks = marks;
    }

    public void Displayresult()
    {
        int sum = 0;
        foreach (int mark in this._marks)
        {
            if (mark < 35)
            {
                Console.WriteLine("Failed");
                return;
            }
            sum += mark;
        }
        if ((sum / this._marks.Length) < 50)
        {
            Console.WriteLine("Failed");
            return;
        }
        Console.WriteLine("Passed");

    }

    public void DisplayData()
    {
        Console.WriteLine("Roll Number : {0} \nName : {1} \nClass : {2} \nSME : {3} \nBranch : {4} ", this._rollNumber, this._name, this._class, this._sme, this._branch);
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        int[] marks = new int[5];
        marks[0] = 90;
        marks[1] = 25;
        marks[2] = 99;
        marks[3] = 80;
        marks[4] = 60;

        Student student = new Student(101, "Bhushan", "12th", "Dhiraj", "Software", marks);
        //student.Displayresult();
        student.DisplayData();
    }
}



