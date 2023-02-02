
using System;
using System.Collections;

public class MainClass
{
    public static void Main(string[] args)
    {
        ArrayList myList = new ArrayList(3);

        myList.Add(12);
        myList.Add("Bhushan");
        myList.Add(new MainClass());
        myList.Add(new object());
        myList.Add('b');
        myList.Add(13.46f);

        myList.Remove('b');
        myList.RemoveAt(0);

        foreach (object obj in myList)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("Capacity : {0}", myList.Capacity);
        Console.WriteLine("Count : {0}", myList.Count);
    }
}