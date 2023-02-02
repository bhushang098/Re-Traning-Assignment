
using StudentExampleDay3;
using System;


public class MainClass
{

    static bool toBeContuned = true;

    public static void Main(string[] args)
    {
        StudentHolder studentHolder = new StudentHolder();
        int roll_no = 0;

        Console.Write("Which Operation To Perform ? \n 1 : Create Student \n 2: Print marksheet of perticular student \n 3 : Print All Marksheets \n 4 : Exit \n");

        while (true)
        {

            Console.WriteLine("Enter Choice :  ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1://Create Student 
                    Console.WriteLine("Enter Name Of Student : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter English Marks : ");
                    int engMarks = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter General Studies Marks : ");
                    int genMarks = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter EnvironMent Studies Marks : ");
                    int envMarks = int.Parse(Console.ReadLine());

                    studentHolder.createStudent(name, engMarks, genMarks, envMarks);
                    break;
                case 2: // Print Result of an student
                    Console.WriteLine("Enter Roll Number of The Student  To Print Result");
                    roll_no = int.Parse(Console.ReadLine());
                    if (studentHolder.isValidStudent(roll_no))
                    {
                        studentHolder.printMarksheet(roll_no);
                    }
                    else
                    {
                        Console.WriteLine("Please  Enter Valid Roll Number");
                    }
                    break;
                case 3: //Print All student Result
                    studentHolder.printMarksheets();
                    break;
                case 4:
                    toBeContuned = false;
                    break;
                default:
                    toBeContuned = false;
                    break;
            }
            if (!toBeContuned)
            {
                break;
            }

        }

    }

}





