// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using StudentPolymorphisom;
using System;


public class MainClass
{
    static bool toBeContuned = true;
    static string name = "";
    static int engMarks, envMarks, genMarks;
    public static void Main(string[] args)
    {
        StudentHolder studentHolder = new StudentHolder();
        int roll_no = 0;



        while (true)
        {

            Console.Write("Which Operation To Perform ? \n 1 : Create Student \n 2: Print marksheet of perticular student \n 3 : Print All Marksheets \n 4 : Exit \n");

            Console.WriteLine("Enter Choice :  ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1://Create Student 
                    Console.WriteLine("Which Streams student You Want To Create ? \n 1 : Science \n 2 : Commerce \n 3 : Arts \n Enter Your Choice \n");
                    int schoice = int.Parse(Console.ReadLine());
                    switch (schoice)
                    {
                        case 1: // Sceince Student
                            getStudentInput();
                            Console.WriteLine("Enter Science Subject marks ");
                            int sciMarks = int.Parse(Console.ReadLine());
                            studentHolder.createStudent(sciMarks, name, engMarks, genMarks, envMarks, schoice);
                            break;
                        case 2: // Commerce Student
                            getStudentInput();
                            Console.WriteLine("Enter Commerce Subject marks ");
                            int comMarks = int.Parse(Console.ReadLine());
                            studentHolder.createStudent(comMarks, name, engMarks, genMarks, envMarks, schoice);
                            break;
                        case 3: // Art Student 
                            getStudentInput();
                            Console.WriteLine("Enter Art Subject marks ");
                            int artMarks = int.Parse(Console.ReadLine());
                            studentHolder.createStudent(artMarks, name, engMarks, genMarks, envMarks, schoice);
                            break;
                        default:
                            break;
                    }
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


    static void getStudentInput()
    {
        Console.WriteLine("Enter Name Of Student : ");
        name = Console.ReadLine();
        Console.WriteLine("Enter English Marks : ");
        engMarks = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter General Studies Marks : ");
        genMarks = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter EnvironMent Studies Marks : ");
        envMarks = int.Parse(Console.ReadLine());
    }
}







