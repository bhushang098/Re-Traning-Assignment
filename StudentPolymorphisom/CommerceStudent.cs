using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPolymorphisom
{
    internal class CommerceStudent : Student
    {
        protected int commerceMarks;

        public CommerceStudent(int comMarks, string studentName, int engMarks, int genMarks, int envMarks) : base(studentName, engMarks, genMarks, envMarks)
        {
            this.commerceMarks = comMarks;
        }

        public override void printMarksheet()
        {
            base.printMarksheet();
            Console.WriteLine(" \n Commerse Marks : " + this.commerceMarks);
        }
    }
}
