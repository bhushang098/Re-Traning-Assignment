// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;

public class MainClass
{
    static void UsingHashTable()
    {
        Hashtable h = new Hashtable();
        h.Add(1, "Bhushan");
        h.Add(2, "Kartik");
        h.Add(13, "Pranay");
        h.Add(4, "Kajal");
        h.Add(5, "Pratiksha");
        h.Add(6, "Sonu");

        foreach (object o in h.Values)
        {
            Console.WriteLine(o);
        }
        Console.WriteLine("---------------------");

        foreach (int i in h.Keys)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("---------------------");

    }

    static void UsingSortedList()
    {
        SortedList sl = new SortedList();
        sl.Add("A1", "Bhushan");
        sl.Add("A4", new MainClass());
        sl.Add("A7", "karthick");
        sl.Add("A2", "Pranay");
        sl.Add("A5", "Kajal");
        sl.Add("A3", "raju");
        sl.Add("A6", "Kiran");

        foreach (object obj in sl.Values)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine("----------------------");

        ICollection c = sl.Values;

        foreach (string obj in sl.Keys)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine("----------------------");

        Console.WriteLine("{0} is at index 1 ", sl.GetByIndex(1));
    }

    static void UsingStack()
    {
        Stack myStack = new Stack();

        myStack.Push(12);
        myStack.Push(4);
        myStack.Push(445);
        myStack.Push(65);
        myStack.Push(99);

        foreach (int ele in myStack)
        {
            Console.WriteLine(ele);
        }
        Console.WriteLine("----------------------");
    }

    static void UsingQueue()
    {
        Queue myq = new Queue();

        myq.Enqueue(34);
        myq.Enqueue(67);
        myq.Enqueue(3);
        myq.Enqueue(4);

        foreach (int ele in myq)
        {
            Console.WriteLine(ele);
        }
        Console.WriteLine("----------------------");
    }

    public static void Main(string[] args)
    {
        //UsingHashTable();
        //UsingSortedList();();
        //UsingStack();
        UsingQueue();

    }
}




