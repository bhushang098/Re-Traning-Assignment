using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataLayerStart.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }



/*

        public ActionResult GetEmployees()
        {
            EmployeeRecordsViewModel empRecords = new EmployeeRecordsViewModel();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();
            EmployeeBusinessLayer empBusiness = new EmployeeBusinessLayer();
            List<Employee> employees = empBusiness.GetEmployees();





            foreach (Employee emp in employees)
            {
                EmployeeViewModel evm = new EmployeeViewModel();
                evm.EmployeeID = emp.EmployeeId;
                evm.EmployeeName = emp.FirstName + " " + emp.LastName;
                evm.Salary = (int)emp.Salary;
                if (emp.Salary > 18000)
                {
                    evm.SalaryColor = "Green";
                }
                else
                {
                    evm.SalaryColor = "Red";
                }
                empViewModels.Add(evm);






            }
            empRecords.MyEmployees = empViewModels;
            return View(empRecords);
        }
        public ActionResult AddNew()
        {
            return View("createEmployee", new CreateEmployeeViewModel());
        }
        //public ActionResult SaveEmployee(Employee e)
        //{
        //    EmployeeBusinessLayer empBusiness = new EmployeeBusinessLayer();
        //    empBusiness.SaveEmployee(e);
        //    return RedirectToAction("GetEmployees");
        //}
        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if (ModelState.IsValid)
                    {
                        EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
                        empBal.SaveEmployee(e);
                        return RedirectToAction("GetEmployees");
                    }
                    else
                    {
                        //return View("CreateEmployee");
                        //to retain value back in case of validation faliure
                        CreateEmployeeViewModel vm = new CreateEmployeeViewModel();
                        vm.FirstName = e.FirstName;
                        vm.LastName = e.LastName;
                        if (e.Salary.HasValue)
                        {
                            vm.Salary = e.Salary.ToString();
                        }
                        else
                        {
                            vm.Salary = ModelState["Salary"].Value.AttemptedValue;
                        }
                        return View("CreateEmployee", vm);
                    }
                case "Cancel":
                    return RedirectToAction("GetEmployees");





            }
            return new EmptyResult();
        }*/
        [Authorize]
        public string SayHello()
        {
            return "Hello";
        }
    }
}