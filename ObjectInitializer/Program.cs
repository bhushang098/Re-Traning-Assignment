
using ObjectInitializer;

class MainClass
{

    static void Main(string[] a)
    {
        Person p = new Person { Id = 12, Name =  "Bhushsan", Age = 34, City = "Nagpur" };
        p.Age = 50;
        p.Name = "Panya";

        Console.WriteLine("Age= {0} \n Name = {1}",p.Age,p.Name);


    }
}

