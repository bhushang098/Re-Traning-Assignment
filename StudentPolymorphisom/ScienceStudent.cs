using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPolymorphisom
{
    internal class ScienceStudent : Student
    {
        protected int scienceMarks;

        public ScienceStudent(int sciMarrks, string studentName, int engMarks, int genMarks, int envMarks) : base(studentName, engMarks, genMarks, envMarks)
        {
            this.scienceMarks = sciMarrks;
        }

        public override void printMarksheet()
        {
            base.printMarksheet();
            Console.WriteLine(" \n Science Marks : " + this.scienceMarks);
        }
    }
}
