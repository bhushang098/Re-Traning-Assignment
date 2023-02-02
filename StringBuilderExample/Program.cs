
using System;
using System.Text;
public class MainClass
{

    static void StringBuilderOperstion()
    {
        StringBuilder sb = new StringBuilder("Bhushan");
        sb[3] = 't';
        Console.WriteLine(sb);

    }
    public static void Main(string[] args)
    {
        StringBuilderOperstion();
    }
}