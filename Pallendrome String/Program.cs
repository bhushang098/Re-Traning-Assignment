
using System;

public class MainClass
{

    static bool IsPallendrome(string s)
    {
        if (s.Equals(ReverseString(s)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static string ReverseString(string s)
    {

        string reversedString = "";

        for (int i = s.Length - 1; i >= 0; i--)
        {
            reversedString = reversedString + s[i];
        }

        return reversedString;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Word to Check for Pallendrome");
        string word = Console.ReadLine();

        if (IsPallendrome(word))
        {
            Console.WriteLine("Entered Word is Pallendrome");
        }
        else
        {
            Console.WriteLine("Entered Word is NOT Pallendrome");
        }


    }

}