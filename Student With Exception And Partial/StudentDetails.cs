using ExceptionLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_With_Exception_And_Partial
{
    internal partial class Student
    {
        public Student(string name, int marks)
        {
            this._ID = id++;
            this._Name = name;

            if (marks < 0)
                throw new MarksNegativeException("You Entered Negative Marks for Student");

            if (marks > 100)
                throw new MarksOverException("Marks Over Exception Occured : Enter marks less than 100");

            this._Marks = marks;

        }
    }
}
