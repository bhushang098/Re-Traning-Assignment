using Product_Delegate;
using Employe_delegate;
using customer_delegate;


Customer cust = new Customer(101, "Sachin");
Product prod = new Product(111, "Mobile");
Employee emp = new Employee(1001, "Sacchu", 15000, 7000, 9000);
cust.AvailService();
Console.WriteLine("-----------------");
prod.UseService();
Console.WriteLine("-----------------");
emp.GenerateSalarySlip();