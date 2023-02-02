// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using Interface_Polymorphisam_Assignment;
using System;


public class MainClass
{
    static bool toBeContuned = true;
    static string cookName = "";
    static string workingName = "";
    static int experience = 0;
    static string cuisine = "";

    public static void Main(string[] args)
    {

        CookHolder holder = new CookHolder();

        while (true)
        {

            Console.Write("Which Operation To Perform ? \n 1 : Add New Cook \n 2: make All Cook Cook Nice Food \n 3 : Exit ");

            Console.WriteLine("Enter Choice :  ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:// Add Cook 
                    Console.WriteLine("What Type of Cook You Want To Add ? \n 1 : Home Cook \n 2 : Master Chef \n 3 : World Cook \n Enter Your Choice \n");
                    int schoice = int.Parse(Console.ReadLine());
                    switch (schoice)
                    {
                        case 1: // Home Cook
                            getCookInput();
                            holder.createCook(CookType.HomeCook, cookName, experience, cuisine, workingName);
                            break;
                        case 2: // Master Chef
                            getCookInput();
                            holder.createCook(CookType.MasterChef, cookName, experience, cuisine, workingName);
                            break;
                        case 3: // World Cook 
                            getCookInput();
                            holder.createCook(CookType.WorldCook, cookName, experience, cuisine, workingName);
                            break;
                        default:
                            break;
                    }
                    break;
                case 2: // <ake All cook Cook food
                    holder.makeAllCookFood();
                    break;
                case 3:
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

    static void getCookInput()
    {
        Console.WriteLine("Enter Name Of Cook : ");
        cookName = Console.ReadLine();

        Console.WriteLine("Enter Name of Place cook works in ");
        workingName = Console.ReadLine();

        Console.WriteLine("Enter Experinece of cook ");
        experience = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter cuisine name in which cook Cooks food ");
        cuisine = Console.ReadLine();


    }
}







