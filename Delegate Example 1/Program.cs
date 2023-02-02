// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

delegate void MyDelegate();
delegate int AnotherDelegate(int x);

public class MainClass
{
    static void M()
    {
        Console.WriteLine("Printing Method M");
    }

    static void N()
    {
        Console.WriteLine("Printing Method N");
    }

    static int O(int x)
    {
        return x * x;

    }

    static int P(int x)
    {
        return x + x;
    }

    public static void Main(string[] args)
    {
        MyDelegate d1 = M;
        d1 = d1 + N;

        d1(); // Calls 2 Methods By Default

        AnotherDelegate d2 = O;
        d2 += P;

        foreach (AnotherDelegate d in d2.GetInvocationList())
        {
            Console.WriteLine(d.Invoke(12));
        }
    }
}


