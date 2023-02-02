using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace EmpoyeeService.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: api/employee
        public IEnumerable<Employee> Get()
        {
            EmployeeDBEntities entities = new EmployeeDBEntities();
            
            entities.Configuration.ProxyCreationEnabled = false;
               
            IEnumerable<Employee> employees = entities.Employees.ToList();
            return employees;

        }

        [HttpPost]
        public  Employee AddEmployee([FromBody] Employee emp)
        {
            
            EmployeeDBEntities entities = new EmployeeDBEntities();

            entities.Employees.Add(emp);
             entities.SaveChanges();
            return emp;
            
        }

       
        public string Put(int id, [FromBody] Employee emp)
        {
            EmployeeDBEntities entities = new EmployeeDBEntities();
            var tmp = entities.Employees.FirstOrDefault(e => e.ID == id);

            tmp.Name = emp.Name;
            tmp.Salary = emp.Salary;

            entities.SaveChanges();
            return "Objected Updated";

        }

        [HttpGet]
        public IEnumerable<Employee> AllWithDID(int id)
        {
            EmployeeDBEntities entities = new EmployeeDBEntities();

            entities.Configuration.ProxyCreationEnabled = false;

            IEnumerable<Employee> employees = entities.Employees.Where(e => e.DID == id).ToList();
            return employees;
        }
    }
}