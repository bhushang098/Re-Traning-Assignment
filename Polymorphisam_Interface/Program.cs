
using System;

interface Shape
{
    void Draw();
}

class Circle : Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Square : Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Square");
    }
}

class Rectangle : Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new Circle();
        shapes[1] = new Square();
        shapes[2] = new Rectangle();

        foreach (Shape s in shapes)
        {
            s.Draw();
        }
    }
}