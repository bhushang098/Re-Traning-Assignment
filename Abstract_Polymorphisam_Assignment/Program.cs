// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using Abstract_Polymorphisam_Assignment;
using System;


public class MainClass
{
    static bool toBeContuned = true;
    static string modelName = "";
    static string CompanyName = "";
    static float price = 0f;
    static int footWearSize = 0;
    static bool footWearType = true;

    public static void Main(string[] args)
    {
        FootWearHolder holder = new FootWearHolder();

        while (true)
        {

            Console.Write("Which Operation To Perform ? \n 1 : Create FootWear Product \n 2: Print Details of All FootWears \n 3 : Exit \n");

            Console.WriteLine("Enter Choice :  ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1://Create Student 
                    Console.WriteLine("Which Type of Product You Want To Create ? \n 1 : Sleepers \n 2 : Formals \n 3 : Sports \n Enter Your Choice \n");
                    int schoice = int.Parse(Console.ReadLine());
                    switch (schoice)
                    {
                        case 1: // Sleepers
                            getProductInput();
                            holder.createFootWear(FootWearKind.Sleepers, footWearSize, footWearType, modelName, CompanyName, price);
                            break;
                        case 2: // Formals
                            getProductInput();
                            holder.createFootWear(FootWearKind.Sleepers, footWearSize, footWearType, modelName, CompanyName, price);
                            break;
                        case 3: // Sports 
                            getProductInput();
                            holder.createFootWear(FootWearKind.Sleepers, footWearSize, footWearType, modelName, CompanyName, price);
                            break;
                        default:
                            break;
                    }
                    break;
                case 2: // Print All footWear Details
                    holder.printAllproducts();
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

    static void getProductInput()
    {
        Console.WriteLine("Enter Name Of Footwear Company : ");
        CompanyName = Console.ReadLine();

        Console.WriteLine("Enter Model Name of Product ");
        modelName = Console.ReadLine();

        Console.WriteLine("Enter price of product ");
        price = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter Size of the FootWear : ");
        footWearSize = int.Parse(Console.ReadLine());

        Console.WriteLine("What is Type of Foot Wear (M/F) : ");
        if (Console.ReadLine() == "F" || Console.ReadLine() == "f")
            footWearType = false;


    }
}







