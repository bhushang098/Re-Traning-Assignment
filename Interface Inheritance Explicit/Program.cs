// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

interface Interface1
{
    void M();
}
interface Interface2 : Interface1
{
    void M();
    void N();
}

class Class1 : Interface1, Interface2
{ // Implementing Interface 

    void Interface1.M()
    {
        Console.WriteLine("Interface 1 Implementatiom");
    }

    void Interface2.M()
    {
        Console.WriteLine("Interface 2 Implementation");
    }

    public void M()
    {
        Console.WriteLine("Common Implementation of M");
    }

    public void N()
    {
        Console.WriteLine("Common Implementation of N");
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        Class1 c1 = new Class1();
        Interface1 i1 = c1;
        Interface2 i2 = c1;

        c1.M();

        i1.M(); // Explicit Implemented method can be called by Interfece Reference only
        i2.M();

        c1.N();
    }
}