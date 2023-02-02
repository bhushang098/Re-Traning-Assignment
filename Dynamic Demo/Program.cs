//Dynamic Demo 


using System;

public class Customer
{
    string customerName;
    public string CustomerName
    {
        get { return customerName; }
        set { customerName = value; }
    }

    int customerId;
    public int CustomerId
    {
        get { return customerId; }
        set { customerId = value; }
    }

    public Customer(int cid, string cname)
    {
        this.customerName = cname;
        this.CustomerId = cid;
    }

    public Customer()
    {

    }

    public string SayHellow(string name)
    {
        return "Hellow .. " + name;
    }
}

public class Product
{
    string productName;
    public string ProductName
    {
        get { return productName; }
        set { productName = value; }
    }

    int productID;
    public int ProductID
    {
        get { return productID; }
        set { productID = value; }
    }

    public Product(int pid, string pname)
    {
        this.productName = pname;
        this.productID = pid;
    }

    public Product()
    {

    }

    public string SayHellow(string name)
    {
        return "Hellow .. " + name;
    }
}


public class MainClass
{
    static dynamic x; // dynamic can be declared in class member also 
    public static object GetProduct()
    {
        return new Product();
    }
    public static object GetCustomer()
    {
        return new Customer();
    }
    public static void Main(string[] args)
    {
        MainClass.x = 100;
        Console.WriteLine(MainClass.x);

        dynamic obj;
        obj = GetCustomer();
        obj.CustomerId = 201;
        obj.CustomerName = "Bhushan";
        Console.WriteLine(obj.CustomerId);
        Console.WriteLine(obj.CustomerName);
        Console.WriteLine(obj.SayHellow("Kajal"));
        Console.WriteLine(obj.GetType());
        Console.WriteLine("--------------------------");

        obj = GetProduct();
        obj.ProductID = 301;
        obj.ProductName = "laddu";
        Console.WriteLine(obj.ProductID);
        Console.WriteLine(obj.ProductName);
        Console.WriteLine(obj.SayHellow("jadu"));
        Console.WriteLine(obj.GetType());
        Console.WriteLine("--------------------------");

        Customer cust = new Customer();
        dynamic dycust = cust;
        dycust.CustomerId = 1001;
        Console.WriteLine(cust.CustomerId);

        Customer newRef = dycust;
        newRef.CustomerId = 102;
        Console.WriteLine(dycust.CustomerId);
        cust.CustomerName = "Partiksha";
        Console.WriteLine(newRef.CustomerName);
        Console.WriteLine("--------------------------");

        int id = cust.CustomerId; // returns dynamic so converston occurs
        dynamic name = cust.CustomerName; // no conversion occurs
        object o = cust.CustomerId; // conversion occurs

        Console.WriteLine(id);
        Console.WriteLine(name);
        Console.WriteLine(o);



    }
}