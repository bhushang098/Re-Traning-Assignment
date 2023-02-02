using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPolymorphisom
{
    internal class ArtStudent : Student
    {
        protected int artMarks;

        public ArtStudent(int aMarks, string studentName, int engMarks, int genMarks, int envMarks) : base(studentName, engMarks, genMarks, envMarks)
        {
            this.artMarks = aMarks;
        }

        public override void printMarksheet()
        {
            base.printMarksheet();
            Console.WriteLine(+this.artMarks);

        }
    }
}
