using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_With_Exception_And_Partial
{
    internal partial class Student
    {
        private static int id = 1001;

        private int _ID;
        private string _Name;
        private int _Marks;

        public int ID
        {
            get { return this._ID; }
        }
    }
}
