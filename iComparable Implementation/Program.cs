

using System;

struct student : IComparable
{
    public int marks;
    public student(int i)
    {
        this.marks = i;
    }
    public int CompareTo(object o)
    {

        student s = (student)o;
        return this.marks.CompareTo(s.marks);
    }
    public override string ToString()
    {
        return this.marks.ToString();
    }
}
public class MainClass
{
    public static void Main(string[] args)
    {
        int[] intArray = { 50, 10, 30, 20, 40 };
        student[] stud = new student[3];
        stud[0] = new student(20);
        stud[1] = new student(10);
        stud[2] = new student(30);


        Array.Sort(stud);
        foreach (student s in stud)
        {
            Console.WriteLine(s.ToString());
        }
        Array.Sort(intArray);
        foreach (int i in intArray)
        {
            System.Console.WriteLine(i);


        }
        int[] myArray = new int[3];
        myArray[0] = 10;
        myArray[1] = 20;
        myArray[2] = 30;
        IComparable i1 = myArray[0];
        IComparable i2 = myArray[1];
        Console.WriteLine(i1.CompareTo(i2));
    }

}