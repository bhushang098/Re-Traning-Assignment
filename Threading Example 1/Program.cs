
using System;
using System.Threading;
public class ManClass
{
    public static void M()
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("In M Thread : {0}", i + 1);
        }

    }

    public static void N()
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("In N Thread : {0}", i + 1);
        }

    }

    public static void P(object o)
    {
        Console.WriteLine("Hellow ... {0}",(string)o);
    }

   
    public static void Main(string[] args)
    {
        Thread t1 = new Thread(M);
        Thread t2 = new Thread(new ThreadStart(N));

        t1.Start();
        t2.Start();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("In main Thread : {0}", i + 1);

        }
        Thread t3 = new Thread(new ParameterizedThreadStart(P));
        t3.Start("Bhushan,....");

        Console.WriteLine("Hellow Back In main");
        Console.WriteLine("---------------------------");
    }
}



