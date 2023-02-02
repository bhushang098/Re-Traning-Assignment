// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<string> myList = new List<string>();

        myList.Add("c#");
        myList.Add("Bhushan");
        myList.Add("Average Numbers");
        myList.Add("new object()");
        myList.Add("Karthick");
        myList.Add("Kajal");

        myList.Remove("new object()");
        myList.RemoveAt(0);

        foreach (string s in myList)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("Capacity : {0}", myList.Capacity);
        Console.WriteLine("Count : {0}", myList.Count);
    }
}