// Greeting Program
using System;

public class MainClass
{
    static void PrintLargestNumber(int number1, int number2, int number3)
    {
        if (number1 > number2)
        {
            // Number 1 is larger 
            if (number1 > number3)
            {
                // number 1 is largest 
                Console.WriteLine("{0} is Largest Number", number1);
            }
            else
            {
                // number 3 is largest 
                Console.WriteLine("{0} is Largest Number", number3);
            }
        }
        else
        {
            // Number 2 is greater
            if (number2 > number3)
            {
                // number 2 is largest
                Console.WriteLine("{0} is Largest Number", number2);
            }
            else
            {
                // number 3 is largest 
                Console.WriteLine("{0} is Largest Number", number3);
            }
        }
    }

    static void PrintSmallestNumber(int number1, int number2, int number3)
    {
        if (number1 < number2)
        {
            //number 1 is smaller
            if (number1 < number3)
            {
                // Number 1 is samllest
                Console.WriteLine("{0} is Smallest Number", number1);
            }
            else
            {
                // number 3 is smallest
                Console.WriteLine("{0} is Smallest Number", number3);
            }
        }
        else
        {
            // number 2 is smalles
            if (number2 < number3)
            {
                // number 2 is smallest
                Console.WriteLine("{0} is Smallest Number", number2);
            }
            else
            {
                // Number 3 is smallest
                Console.WriteLine("{0} is Smallest Number", number3);
            }
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Input Number 1");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Input Number 2");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Input Number 3");
        int number3 = int.Parse(Console.ReadLine());


        PrintLargestNumber(number1, number2, number3);
        PrintSmallestNumber(number1, number2, number3);
    }

}