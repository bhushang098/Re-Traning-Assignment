using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExampleDay3
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

        public Student createStudent(string studentName, int engMarks, int genMarks, int envMarks)
        {
            Student newStudnet = new Student(studentName, engMarks, genMarks, envMarks);
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

        public void printMarksheet(int rollNo)
        {
            Student s = getStudent(rollNo);
            if (s != null)
            {
                s.printMarksheet();
            }

        }

        public static Student getStudent(int rollNo)
        {
            foreach (Student s in students)
            {
                if (s != null)
                {
                    if (s.RollNo == rollNo)
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
        public bool isValidStudent(int rollNo)
        {
            foreach (Student s in students)
            {
                if (s != null)
                {
                    if (s.RollNo == rollNo)
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
