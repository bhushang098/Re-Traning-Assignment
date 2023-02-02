// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;

public class MainClass
{
    public static void Main(string[] args)
    {
        int[] myArray = { 2, 3, 4, 6, 34, 7 };

        foreach (int a in myArray)
        {
            Console.WriteLine(a);
        }
        Console.WriteLine("-------------");

        IEnumerator t = myArray.GetEnumerator();

        while (t.MoveNext())
        {
            Console.WriteLine(t.Current);
        }
        t.Reset();
        Console.WriteLine("-------------");

        IEnumerable en = myArray; // Array has Implemented IEnumerator Interface
        t = en.GetEnumerator();
        while (t.MoveNext())
        {
            Console.WriteLine(t.Current);
        }
        t.Reset();
        Console.WriteLine("-------------");


    }
}




