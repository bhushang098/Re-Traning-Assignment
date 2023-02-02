// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public interface InterfaceOne
{
    void MethodOne();
}
public interface InterfaceTwo
{
    void MethodTwo();
}
public interface InterfaceThree
{
    void MethodThree();
}
public interface InterfaceFour
{
    void MethodFour();
}

public abstract class ClassOne : InterfaceThree
{
    public void MethodOne()
    {
        Console.WriteLine("Method One : Class One");
    }

    public void MethodTwo()
    {
        Console.WriteLine("Method Two : Class One");
    }

    public abstract void MethodThree();

}

public class ClassTwo : ClassOne, InterfaceFour
{
    public override void MethodThree()
    {
        Console.WriteLine("Method Three : Class Two");
    }

    public void MethodFour()
    {
        Console.WriteLine("Method Four : Class Two");
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        ClassTwo c2 = new ClassTwo();
        c2.MethodOne();
        c2.MethodTwo();
        c2.MethodThree();
        c2.MethodFour();

        ClassOne c1 = new ClassTwo();
        c1.MethodOne();
        c1.MethodTwo();
        c1.MethodThree();



    }
}