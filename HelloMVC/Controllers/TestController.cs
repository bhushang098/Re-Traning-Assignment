using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
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




    }
}