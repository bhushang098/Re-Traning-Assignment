using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_With_Exception_And_Partial
{
    internal partial class Student
    {
        public void printMarksheet()
        {
            Console.WriteLine(" ID : {0} \n Name : {1} \n Marks : {2} ", this._ID, this._Name, this._Marks);

        }
    }
}
