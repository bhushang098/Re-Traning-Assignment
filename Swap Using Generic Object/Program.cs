using System;



struct Student : IComparable
{
    private int _id;
    private string _name;
    public Student(int id, string name)
    {
        _id = id;
        _name = name;
    }







    public int CompareTo(object obj)
    {
        Student stud = (Student)obj;
        return this._id.CompareTo(stud._id);
    }







    public override string ToString()
    {
        return "Student Details:\n1.Student id: " + this._id + "\n2.Student Name: " + this._name;
    }
}







class MainClass
{
    static void Swap<t>(t x, t y)
    {
        t temp;
        temp = x;
        x = y; y = temp;
        Console.WriteLine("After Swap");
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
    static void Main()
    {
        Console.WriteLine("before swap");
        Student s1 = new Student(1, "Sachin");
        Student s2 = new Student(2, "Sarla");
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Swap<Student>(s1, s2);
    }
}