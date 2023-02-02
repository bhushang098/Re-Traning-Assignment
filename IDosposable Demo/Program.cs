
using System;
using System.Threading;

public class Class1 : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("Inside Dispose Method");
    }

    ~Class1()
    {
        Console.WriteLine("Destructor For Class1");
    }
}
public class MainClass
{
    static void M()
    {
        Class1[] c = new Class1[10];

        for (int i = 0; i < 10; i++)
        {
            using (c[i] = new Class1())
            {

            }
            Thread.Sleep(100);
        }


    }
    public static void Main(string[] args)
    {
        M();
        GC.Collect();
        Thread.Sleep(2000);
        Console.WriteLine("******************************");
    }
}