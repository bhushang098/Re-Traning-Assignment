
using System;
using System.Reflection;

public class MainClass
{
    public static void Main(string[] args)
    {
        int i = 10;
        Console.WriteLine(AppDomain.CurrentDomain);
        Console.WriteLine(i.GetType());
        Assembly a = Assembly.LoadFile("C:\\user\\M1080758\\dotnetassembly.dll");
        Console.WriteLine(a.FullName);
        Console.WriteLine(a.GetName());

        Type[] types = a.GetTypes();

        foreach (Type t in types)
        {
            Console.WriteLine(t.FullName);
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo m in methods)
            {
                Console.WriteLine(m.ReturnType);
                Console.WriteLine(m.ReturnParameter);
                ParameterInfo[] parameters = m.GetParameters();

                foreach (ParameterInfo p in parameters)
                {
                    Console.WriteLine(p.Name);
                    Console.WriteLine(p.ParameterType);
                    Console.WriteLine(p.GetType());
                    Console.WriteLine("..........................");
                }
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine("*********************************");
        }
    }
}