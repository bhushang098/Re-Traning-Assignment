using System;

public static class ExtendedMethods
{

    public static int Int32(this string s)
    {
        return int.Parse(s);
    }
}

class MainClass
{
    static void Main()
    {
        string str = "123456";
        int i = str.Int32();
        Console.WriteLine(i);
    }
}


