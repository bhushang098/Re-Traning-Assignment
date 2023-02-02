using System;
using System.Collections;
class IEnumerableIterators
{

    public static IEnumerable getAllUsers()
    {
        yield return 1;
        yield return 2;
        yield return 3;
        yield return 4;
    }

    static void Main()
    {
        foreach (int i in getAllUsers())
        {
            Console.WriteLine(i);
        }
        string name = "Sachin";
        IEnumerator e = name.GetEnumerator();

        while (e.MoveNext())
        {
            Console.WriteLine(e.Current);
        }
        e.Reset();
        while (e.MoveNext())
        {
            Console.WriteLine(e.Current);
        }
        foreach (char c in name)
        {
            while (e.MoveNext())
            {
                Console.WriteLine(c);
            }
        }
    }
}