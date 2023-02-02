
using CollectionInitializer;

class MainClass
{
    static void Main(string[] a)
    {
        List<Person> list = new List<Person>()
        {
            new Person() { Name = "Bhushan", Age = 23 },
            new Person {Name = "Kartik", Age = 32}
        };

        foreach(Person p in list)
        {
            Console.WriteLine(p.Name);
        }
}
}