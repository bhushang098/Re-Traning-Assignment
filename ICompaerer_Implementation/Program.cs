
using System;
using System.Collections;

public class Vehicle
{
    public int capacity;
    string name;

    public Vehicle(string vname, int vcapacity)
    {
        this.name = vname;
        this.capacity = vcapacity;
    }
}

public class CapacityComparer : IComparer
{
    public int Compare(object o1, object o2)
    {
        Vehicle v1 = (Vehicle)o1;
        Vehicle v2 = (Vehicle)o2;
        return v1.capacity.CompareTo(v2.capacity);
    }
}

public class MainClass
{
    public static void Main(string[] a)
    {
        Vehicle[] vehicles = new Vehicle[5];

        vehicles[0] = new Vehicle("Tata", 230);
        vehicles[1] = new Vehicle("Honda", 30);
        vehicles[2] = new Vehicle("Skoda", 20);
        vehicles[3] = new Vehicle("Suzuki", 120);
        vehicles[4] = new Vehicle("Mahindra", 78);

        Array.Sort(vehicles, new CapacityComparer());

        foreach (Vehicle v in vehicles)
        {
            Console.WriteLine(" Capacity {0} ", v.capacity);
        }


    }
}

