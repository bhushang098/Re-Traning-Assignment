

using Student_With_Exception_And_Partial;

public class MainClass
{
    static bool toBeContuned = true;

    public static void Main(string[] args)
    {
        StudentHolder studentHolder = new StudentHolder();
        int id = 0;

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
                    Console.WriteLine("Enter Marks : ");
                    int marks = int.Parse(Console.ReadLine());
                    try
                    {
                        Student stud = studentHolder.createStudent(name, marks);
                        Console.WriteLine("Student Added with ID : {0}", stud.ID);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
                case 2: // Print Result of an student
                    Console.WriteLine("Enter ID of The Student To Print Result");
                    id = int.Parse(Console.ReadLine());
                    if (studentHolder.isValidStudent(id))
                    {
                        studentHolder.printMarksheet(id);
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