
using System;

public class MainClass
{
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
        Console.WriteLine("Enter a Word to Reverse it");
        string word = Console.ReadLine();

        Console.WriteLine("Reversed Word is : {0} ", ReverseString(word));

    }

}