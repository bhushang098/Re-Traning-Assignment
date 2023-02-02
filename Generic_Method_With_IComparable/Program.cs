
using System;
using System.Collections;

struct Student : IComparable
{
    public int marks;
    public Student(int i)
    {
        this.marks = i;
    }
    public int CompareTo(object o)
    {

        Student s = (Student)o;
        return this.marks.CompareTo(s.marks);
    }
    public override string ToString()
    {
        return this.marks.ToString();
    }
}


public class GenericMethod
{
    // Prohram to swap 2 numbers 
    public static void SwapValues<vType>(ref vType a, ref vType b)
    {
        vType t = a;
        a = b;
        b = t;

        Console.WriteLine(" After Swap \n Student 1 = {0} \n Student 2 = {1} ", a, b);
    }

    public static void Main(string[] args)
    {
        Student stud1;
        Student stud2;

        stud1.marks = 55;
        stud2.marks = 65;

        Console.WriteLine(" Before Swap \n Student 1 = {0} \n Student 2 = {1} ", stud1, stud2);

        SwapValues<Student>(ref stud1, ref stud2);



    }
}
