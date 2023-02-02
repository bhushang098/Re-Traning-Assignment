using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPIConsumer
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public short DID { get; set; }

        public virtual Dept Dept { get; set; }
    }
}
