using System;
using System.Collections;

public class MainClass
{
    public static void M(string name, bool b = false, ArrayList mylist = null)
    {
        Console.WriteLine("name : " + name);
        Console.WriteLine(b);

    }
    public static void Main(string[] args)
    {
        M("Bhushan");
        M("Kartik", true);
        M("kajal", true, new ArrayList());
        M("Prtaiksha", b: true, mylist: new ArrayList());

    }
}