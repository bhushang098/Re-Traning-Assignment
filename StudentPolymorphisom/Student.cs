using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPolymorphisom
{
    internal class Student
    {
        public static int No = 101;
        protected int _rollNumber;
        protected string _studentName;
        protected int _englishMarks;
        protected int _generalStudiesmarks;
        protected int _environmentStudiesMarks;


        public string StudentName
        {
            get { return this._studentName; }

        }

        public int RollNo
        {
            get { return this._rollNumber; }
        }

        public Student(string studentName, int engMarks, int genMarks, int envMarks)
        {
            this._rollNumber = No++;
            this._studentName = studentName;
            this._englishMarks = engMarks;
            this._generalStudiesmarks = genMarks;
            this._environmentStudiesMarks = envMarks;

        }

        public virtual void printMarksheet()
        {
            Console.WriteLine("Student  Roll Number is : {0} \n  Name of Student is : {1} \n English Marks : {2} \n General Studies marks {3} : \n Environmantal Studies Marks {4}: ", this._rollNumber, this._studentName, this._englishMarks, this._generalStudiesmarks, this._environmentStudiesMarks);

        }
    }
}
