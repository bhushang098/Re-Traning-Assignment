
using System;
using System.Text;
public class MainClass
{

    class class1
    {
        public int x;

    }
    public static void Main(string[] args)
    {
        class1 c1 = new class1();
        c1.x = 10;
        class1 c2 = new class1();
        c2.x = 20;

        c1 = c2;
        c1.x = 30;

        Console.WriteLine(c1.x + "\n");
        Console.WriteLine(c2.x);
    }
}