
using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        //Creates and Applicatio Domain
        System.AppDomain newDomain = System.AppDomain.CreateDomain("NewApplicationDomain");

        //Load and Execute Assembly
        newDomain.ExecuteAssembly(@"C:\\user\\M1080758\\learningDotnet\\Hellow.exe");

        //Unload Application Domain
        System.AppDomain.Unload(newDomain);

        AppDomain.Unload(AppDomain.CurrentDomain);

    }
}