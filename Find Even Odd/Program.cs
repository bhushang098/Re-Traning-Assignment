
using System;

public class MainClass
{
    static bool IsEvenNumber(int numberToCheck)
    {
        if (numberToCheck % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number To Check if Even or Odd");
        int number = int.Parse(Console.ReadLine());

        if (IsEvenNumber(number))
        {
            Console.WriteLine("{0} is Even Number", number);
        }
        else
        {
            Console.WriteLine("{0} is Odd Number", number);
        }
    }

}