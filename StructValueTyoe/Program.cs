
using StructValueTyoe;
using System;

namespace classnStruct
{

    class MainClass
    {

        public static void Main(string[] a)
        {

            //Value Type
            Student s1;
            s1.id = 10;

            Student s2;
            s2.id = 20;

            Console.WriteLine("Value of student 1 : " + s1.id + "\n");
            Console.WriteLine("Value of student 2 : " + s2.id + "\n");

            // After assigning s1 and s2
            s1 = s2;

            Console.WriteLine(" After Assigning Value of student 1 : " + s1.id + "\n");
            Console.WriteLine("After Assigning  Value of student 2 : " + s2.id + "\n");

            // as its pass  by value chnage in s1 or will not be coupled 

            s1.id = 40;
            Console.WriteLine(" After Change s1.id Value of student 1 : " + s1.id + "\n");
            Console.WriteLine("After Change s1.id  Value of student 2 : " + s2.id + "\n");

        }


    }

}



