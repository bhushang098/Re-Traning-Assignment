using Hello2.Models;
using Hello2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello2.Controllers
{
    public class TestController : Controller
    {
        public string SayHello()
        {
            return "Hello i Am Learming MVC";
        }

        public string NoHello()
        {
            return String.Empty;
        }

        public ActionResult NoGreeting()
        {
            return new EmptyResult();
        }

        [NonAction]
        public String SimpleMethod()
        {
            return "I am not an Action Method !";
        }

        public Customer GetCustomer()
        {
            Customer customer = new Customer();
            customer.CustomerName = "Bhushan";
            customer.Address = "Pune";
            return customer;
        }

        public ActionResult GetMyView()
        {
            return View("MyView");
        }

        public ActionResult GetView()
        {
            return View();
        }

        public ActionResult GetAnotherEmployee()
        {
            Employee emp = new Employee();
            emp.FirstName = "Bhushan";
            emp.LastName = "Gurnule";
            emp.Salary = 20000;
            //ViewBag.MyEmployee = emp;
            ViewData["MyEmployee"] = emp;
            return View();
        }


        public ActionResult GetEmployee()
        {
            //Controller Action Method is taking object from Model adding for properties 
            Employee emp = new Employee();
            emp.FirstName = "Bhushan";
            emp.LastName = "Gurnule";
            emp.Salary = 20000;
            //ViewDataDictionary d = base.ViewData;
            //d["MyEmployee"] = emp;
            //ViewData["MyEmployee"] = emp;



            ViewBag.MyEmployee = emp;//pass it as viewbag and get it as viewData
            return View();
        }

        public ActionResult GetEmployeeView()
        {
            return View();
        }

        public ActionResult EmployeeTypedView()
        {
            Employee e = new Employee();
            e.FirstName = "Bhushan";
            e.LastName = "Gurnule";
            e.Salary = 1200000;

            EmployeeTypedViewModel viewModel = new EmployeeTypedViewModel();
            viewModel.Employee = e;
            if(e.Salary >=100000)
            {
                viewModel.colour = "green";
            }
            else
            {
                viewModel.colour = "yellow";
            }

            return View(viewModel);
        }


    }

}