using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExampleDay3
{
    internal class Employee
    {
        public static int id = 101;

        private int _empId;
        private string _empName;
        private float _basic;
        private float _da;
        private float _hra;
        private float _empSalary;

        public int EmpId
        {
            get { return this._empId; }
        }
        public float Salary
        {
            get { return this._empSalary; }
        }

        public Employee(string name, float basic, float da, float hra)
        {

            this._empId = id++;
            this._empName = name;
            this._basic = basic;
            this._da = da;
            this._hra = hra;

        }

        public void calculatSalary()
        {
            this._empSalary = (this._basic + this._da + this._hra);

        }

        public string PrintSalarySlip()
        {
            return string.Format("Employee {0} \n Name : {1} \n Basics Salary : {2} RS  \n DA : {3} RS \n HRA {4} RS \n Total Salary : {5} RS", this._empId, this._empName, this._basic, this._da, this._hra, this.Salary);
        }
    }
}
