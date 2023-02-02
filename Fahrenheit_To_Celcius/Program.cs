
using System;

public class MainClass
{
    static float ConvertToCelsius(float tempInF)
    {
        return ((tempInF - 32) * 5 / 9);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Temprature in Fahrenheit : ");
        float tempInF = float.Parse(Console.ReadLine());

        Console.WriteLine("Temprature in Celsius is : {0}", ConvertToCelsius(tempInF));

    }

}