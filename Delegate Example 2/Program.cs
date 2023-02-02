
using System;

class CalculatorService
{
    public static void DoCalculation(MyDelegate dl)
    {
        dl(10, 15);
    }
}
delegate void MyDelegate(int x, int y);

public class MainClass
{
    private static void Add(int a, int b)
    {
        Console.WriteLine("Addition : {0} ", (a + b));
    }

    private static void Subtract(int a, int b)
    {
        Console.WriteLine("Subtraction : {0} ", (a - b));
    }

    public static void Main(string[] args)
    {
        MyDelegate d1 = Add;
        d1 += Subtract;

        CalculatorService.DoCalculation(d1);
        Console.WriteLine("---------------------");

        // Getting All Delifgate Methods in Array 
        Delegate[] dArray = d1.GetInvocationList();

        foreach (MyDelegate d in dArray)
        {
            Console.WriteLine(d.Method);
            d.DynamicInvoke(20, 25);
        }

    }
}


