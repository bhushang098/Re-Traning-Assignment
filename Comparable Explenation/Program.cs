using System;



struct Student : IComparable
{
    public int marks;

    public Student(int marks)
    {
        this.marks = marks;
    }
    public int CompareTo(object obj)
    {
        Student s = (Student)obj;
        return this.marks.CompareTo(s.marks);
    }
    public override string ToString()
    {
        return "Marks :" + this.marks;
    }
}
class MainClass
{

    // public static void SortData(IComparable [] objarray){
    //     Console.WriteLine(objarray[0].CompareTo(objarray[1]));
    //     foreach(object o in objarray){
    //         Console.WriteLine(o);
    //     }
    // }

    public static void Main(string[] args)
    {
        int i = 10;
        int j = 20;
        Console.WriteLine(i.CompareTo(j));
        Student s, p;
        s.marks = 10;
        p.marks = 20;
        Console.WriteLine(s.CompareTo(p));

        Console.WriteLine("--------------");

        int[] array = { 4, 7, 9, 2, 7, 5, 6 };
        Array.Sort(array);
        foreach (int l in array)
        {
            Console.WriteLine(l + " ");
        }

        Console.WriteLine("--------------");

        Student[] student = new Student[5];
        student[0].marks = 10;
        student[1].marks = 50;
        student[2].marks = 30;
        student[3].marks = 70;
        student[4].marks = 40;

        Array.Sort(student);
        foreach (Student r in student)
        {
            Console.WriteLine(r.marks + " ");
        }
        Console.WriteLine("--------------");

        IComparable[] students = new IComparable[5];
        students[0] = student[0];
        students[1] = student[1];
        students[2] = student[2];
        students[3] = student[3];
        students[4] = student[4];

        Array.Sort(students);
        //SortData(array);
        foreach (Student sa in students)
        {
            Console.WriteLine(sa + " ");
        }


        //Console.WriteLine ("Hello Mono World");
    }
}