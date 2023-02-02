
using System;
using System.Collections;

public class GenericMethod
{
    // Prohram to swap 2 numbers 

    public static void SwapData<bhushan>(bhushan s1, bhushan s2)
    {
        bhushan t = s1;
        s1 = s2;
        s2 = t;

        Console.WriteLine(" After Swap \n s1 = {0} \n s2 = {1} ", s1, s2);
    }

    public static void Main(string[] args)
    {
        int a = 10;
        int b = 20;

        Console.WriteLine(" Before Swap \n A = {0} \n B = {1} ", a, b);
        // Swap 
        SwapData<int>(a, b);

        string s1 = "Bhushan";
        string s2 = "Kartik";

        Console.WriteLine(" Before Swap \n s1 = {0} \n s2 = {1} ", s1, s2);
        SwapData<string>(s1, s2);







    }
}




