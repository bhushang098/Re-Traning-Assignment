// Greeting Program
using System;

public class MainClass
{
    static void PrintResult(int marks1, int marks2, int marks3)
    {

        if (CalculateAverage(marks1, marks2, marks3) > 50)
        {
            Console.WriteLine("Student Passed ");
        }
        else
        {
            Console.WriteLine("Student Failed ");
        }
    }

    static int CalculateAverage(int num1, int num2, int num3)
    {
        return ((num1 + num2 + num3) / 3);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Marks for C# : ");
        int cSharpMarks = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks for ASP.NET : ");
        int aspMarks = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks for SQL Server : ");
        int sqlMarks = int.Parse(Console.ReadLine());

        PrintResult(cSharpMarks, aspMarks, sqlMarks);

    }

}