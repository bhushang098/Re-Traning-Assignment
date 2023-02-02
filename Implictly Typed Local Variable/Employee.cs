using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implictly_Typed_Local_Variable
{
    internal class Employee
    {
        private int _empId;

        public int EmployeeId { get { return _empId; } set { _empId = value; }}

    }
}
