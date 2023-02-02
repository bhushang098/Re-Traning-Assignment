

using Implictly_Typed_Local_Variable;

int k = 10;

var intValue = k++;

Console.WriteLine("Int Value {0} : ",intValue);

/*declator must include initializer 
    var i;
int = 100;
*/

/*The compile rtime type of the initializer experssion can not be null 
    var t = null;*/

var stringValye = "Bhushan";

Console.WriteLine("String Value {0}",stringValye);

var intArray = new int[] {1,2,3,4};

foreach(int i in intArray)
{
    Console.WriteLine(i);
}
Console.WriteLine("-------------------");

var empObj = new Employee();
empObj.EmployeeId = 101;

Console.WriteLine("Var emp Obj Id : {0}",empObj.EmployeeId);

Employee emp = new Employee();
empObj = emp;
empObj.EmployeeId = 102;

Console.WriteLine("Var emp Obj Id : {0}", empObj.EmployeeId);
Console.WriteLine("Employee emp Obj Id : {0}", emp.EmployeeId);

Student s = new Student();
var studObj = s;
studObj.RollNumber = 1001;

Console.WriteLine("Var Student Obj Roll NO : {0}", studObj.RollNumber);











