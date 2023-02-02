using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializationWithList
{
    [Serializable]
    internal class Student
    {
        public readonly int ID;
        static int id = 100;

        public Student()
        {
            this.ID = ++id;
        }
    }
}
