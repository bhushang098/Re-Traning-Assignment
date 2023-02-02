using Print_Delegate;

namespace Employe_delegate

{
    public class Employee
    {

        private int _empId;
        private string _empName;
        private int _empBasic;
        private int _empDa;
        private int _empHra;


        public Employee(int _empId, string _empName, int _empBasic, int _empDa, int _empHra)
        {
            this._empId = _empId;
            this._empName = _empName;
            this._empBasic = _empBasic;
            this._empDa = _empDa;
            this._empHra = _empHra;
        }

        public int Salary
        {
            get
            {
                return _empBasic + _empDa + _empHra;
            }
        }

        public void salarySlip()
        {
            Console.WriteLine("Employee Id {0}", this._empId);
            Console.WriteLine("Employee Name {0}", this._empName);
            Console.WriteLine("Employee Salary {0}", this.Salary);
        }
        public void GenerateSalarySlip()
        {
            PrintingService.Print(salarySlip);
        }
    }

}