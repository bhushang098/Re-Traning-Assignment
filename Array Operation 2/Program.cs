
using System;

public class MainClass
{
    static int CalculateSum(int[] array)
    {
        int sum = 0;
        foreach (int ele in array)
        {
            sum += ele;
        }
        return sum;
    }

    static int CalculateAverage(int[] array)
    {

        return CalculateSum(array) / (array.Length + 1);
    }

    static void PrintMinMax(int[] array)
    {
        if (array.Length <= 0)
            return;

        int min = array[0];
        int max = array[0];

        foreach (int ele in array)
        {
            if (min > ele)
                min = ele;

            if (max < ele)
                max = ele;
        }
        Console.WriteLine("Minimun of Array is : {0} \nMaximum of Array is : {1}", min, max);
    }

    static void PrintAscending(int[] array)
    {
        Array.Sort(array);
        foreach (int marks in array)
        {
            Console.Write(marks + " ");
        }
    }

    static void PrintDescending(int[] array)
    {

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
    }

    public static void Main(string[] args)
    {

        int[] subjectMarks = new int[10];

        for (int i = 0; i < subjectMarks.Length; i++)
        {
            Console.WriteLine("Enter Marks of in Subject {0} : ", i + 1);
            subjectMarks[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(" ");

        Console.WriteLine("Total of All Subject Marks is : {0}", CalculateSum(subjectMarks));

        Console.WriteLine("Average  of All Subject Marks is : {0}", CalculateAverage(subjectMarks));

        PrintMinMax(subjectMarks);

        PrintAscending(subjectMarks);
        Console.WriteLine("------------------");
        PrintDescending(subjectMarks);

    }

}