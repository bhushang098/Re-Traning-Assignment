
using System;

public class MainClass
{
    static int CalculateAverage(int[] array)
    {
        int sum = 0;
        foreach (int ele in array)
        {
            sum += ele;
        }
        return sum / (array.Length + 1);
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

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Size of Array");
        int arraySize = int.Parse(Console.ReadLine());

        int[] myArray = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine("Enter value in Index {0} : ", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Average Value of Array is : {0}", CalculateAverage(myArray));

        PrintMinMax(myArray);

    }

}