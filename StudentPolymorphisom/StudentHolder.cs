using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPolymorphisom
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

        public Student createStudent(int dynamicMarks, string studentName, int engMarks, int genMarks, int envMarks, int choice)
        {
            switch (choice)
            {
                case 1: // science Student
                    Student sciStudnet = new ScienceStudent(dynamicMarks, studentName, engMarks, genMarks, envMarks);
                    students[counter++] = sciStudnet;
                    return sciStudnet;
                case 2: // Commerse Student
                    Student comStudnet = new CommerceStudent(dynamicMarks, studentName, engMarks, genMarks, envMarks);
                    students[counter++] = comStudnet;
                    return comStudnet;
                case 3: // Art Student 
                    Student artStudnet = new ArtStudent(dynamicMarks, studentName, engMarks, genMarks, envMarks);
                    students[counter++] = artStudnet;
                    return artStudnet;
                default:
                    return null;
            }
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
