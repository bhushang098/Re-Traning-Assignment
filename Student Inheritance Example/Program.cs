
using System;

public abstract class Student
{
    public static int totalStudents = 0;
    private string _name;
    private string _class;

    public Student(string name, string sclass)
    {
        totalStudents++;
        this._name = name;
        this._class = sclass;
    }

    public abstract int getPercentage();
    public static int getTotalNoStudents()
    {
        return totalStudents;
    }

}

public class ScienceStudent : Student
{
    public static int noOfStudents = 0;
    private int _phisicsMarks;
    private int _chemistryMarks;
    private int _mathsMarks;

    public int PhysicsMarks
    {
        get { return this._phisicsMarks; }
        set { this._phisicsMarks = value; }
    }

    public int ChemistryMarks
    {
        set { this._chemistryMarks = value; }
    }

    public int MathsMarks
    {
        set { this._mathsMarks = value; }
    }

    public ScienceStudent(string name, string sclass) : base(name, sclass)
    {
        noOfStudents++;
    }

    public override int getPercentage()
    {
        int percent = ((this._phisicsMarks + this._chemistryMarks + this._mathsMarks) * 100) / 300;

        return percent;
    }
}

public class HistoryStudent : Student
{
    public static int noOfStudents = 0;
    private int _historyMarks;
    private int _civicsMarks;

    public int HistoryMarks
    {
        set { this._historyMarks = value; }
    }

    public int CivicsMarks
    {
        set { this._civicsMarks = value; }
    }

    public HistoryStudent(string name, string sclass) : base(name, sclass)
    {
        noOfStudents++;
    }

    public override int getPercentage()
    {
        return ((this._historyMarks + this._civicsMarks) * 100) / 200;
    }
}


public class MainClass
{
    public static void Main(string[] args)
    {

        ScienceStudent s1 = new ScienceStudent("Bhushan", "12th");
        ScienceStudent s2 = new ScienceStudent("Kajal", "10th");

        HistoryStudent s3 = new HistoryStudent("kartik", "12th");
        HistoryStudent s4 = new HistoryStudent("Pratiksha", "10th");

        s1.PhysicsMarks = 56;
        s1.ChemistryMarks = 84;
        s1.MathsMarks = 64;

        s2.PhysicsMarks = 64;
        s2.ChemistryMarks = 76;
        s2.MathsMarks = 49;

        s3.HistoryMarks = 46;
        s3.CivicsMarks = 89;

        s4.HistoryMarks = 76;
        s4.CivicsMarks = 82;

        Console.WriteLine(s1.getPercentage());
        Console.WriteLine(s2.getPercentage());
        Console.WriteLine(s3.getPercentage());
        Console.WriteLine(s4.getPercentage());

        Console.WriteLine(ScienceStudent.noOfStudents);

    }
}
