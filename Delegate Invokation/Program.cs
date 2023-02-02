
using System;
delegate void CalculatorDelegate(int x, int y);

class Calculator
{
    public static void Add(int x, int y)
    {
        Console.WriteLine(x + y);
    }
    public static void Sub(int x, int y)
    {
        Console.WriteLine(x - y);
    }
    public static void Mul(int x, int y)
    {
        Console.WriteLine(x * y);
    }
    public static void Div(int x, int y)
    {
        Console.WriteLine(x / y);
    }
}
public class MainClas
{
    public static void Main(string[] args)
    {
        CalculatorDelegate d = new CalculatorDelegate(Calculator.Add);
        d += Calculator.Sub;
        d += Calculator.Mul;
        d += Calculator.Div;

        d(10, 15);

        Console.WriteLine("----------------------------");

        Delegate[] dArray = d.GetInvocationList();

        foreach (CalculatorDelegate dl in dArray)
        {
            dl.DynamicInvoke(30, 35);
        }
        Console.WriteLine("----------------------------");

        CalculatorDelegate d1 = new CalculatorDelegate(Calculator.Add);
        CalculatorDelegate d2 = new CalculatorDelegate(Calculator.Sub);
        CalculatorDelegate d3 = new CalculatorDelegate(Calculator.Mul);
        CalculatorDelegate d4 = new CalculatorDelegate(Calculator.Div);

        Delegate myDelegates = CalculatorDelegate.Combine(d1, d2, d3, d4);

        foreach (Delegate del in myDelegates.GetInvocationList())
        {
            del.DynamicInvoke(23, 12);
        }

    }
}


