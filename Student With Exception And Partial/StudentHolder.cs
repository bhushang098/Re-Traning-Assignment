using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_With_Exception_And_Partial
{
    internal class StudentHolder
    {
        byte counter;
        static Student[] students;

        public StudentHolder()
        {
            counter = 0;
            students = new Student[10];
        }

        public Student createStudent(string studentName, int marks)
        {
            Student newStudnet = new Student(studentName, marks);
            students[counter++] = newStudnet;
            return newStudnet;
        }

        public void printMarksheets()
        {
            foreach (Student student in students)
            {
                if (student != null)
                {
                    student.printMarksheet();
                }
                else
                {
                    break;
                }
            }
        }

        public void printMarksheet(int id)
        {
            Student s = getStudent(id);
            if (s != null)
            {
                s.printMarksheet();
            }

        }

        public static Student getStudent(int id)
        {
            foreach (Student s in students)
            {
                if (s != null)
                {
                    if (s.ID == id)
                    {
                        return s;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
        public bool isValidStudent(int id)
        {
            foreach (Student s in students)
            {
                if (s != null)
                {
                    if (s.ID == id)
                    {
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

    }
}
