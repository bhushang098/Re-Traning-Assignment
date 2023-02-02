var person = new { Name = "Bhushan", Age = 23 }; //Anonymus type Created

// person.Name = "kartik";  Not Allowed because Anonymus type  Create only Read onnly Peoperties 

Console.WriteLine(" name : {0} \n Age : {1}", person.Name,person.Age);

var p = person; // Anonymus type are Reference type That Are Derived from Object Type

Console.WriteLine(" name : {0} \n Age : {1}", p.Name, p.Age);

var per = new { Name = "kartik", Age = 24 };

if(p.Equals(per))
{
    Console.WriteLine("Equal objects");
}
else
{
    Console.WriteLine("Non-Equal objects");
}

if (object.ReferenceEquals(p,per))
{
    Console.WriteLine("Referenece Equal objects");
}
else
{
    Console.WriteLine("Refernece Non-Equal objects");
}

