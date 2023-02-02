
using System;

public class MainClass
{
    static void StringOperations()
    {
        string myName = "Bhushan";

        Console.WriteLine("Orignal String is {0}", myName);

        string newName = "Bhushan";
        Console.WriteLine("New Name string is {0}", newName);

        // Compare orignal and New Name ny Its Reference 

        bool b = object.ReferenceEquals(myName, newName);
        Console.WriteLine("\n both Strings Refernce equals = {0}", b);

        // Replacing string characters 

        string repName = myName.Replace("u", "i");
        Console.WriteLine("Replaced String is {0} ", repName);

        // Spliting of String 
        string fullName = "Bhushan Kishor Gurnule";

        foreach (string s in fullName.Split(" "))
        {
            Console.WriteLine(s);
        }



    }
    public static void Main(string[] args)
    {
        StringOperations();
    }
}