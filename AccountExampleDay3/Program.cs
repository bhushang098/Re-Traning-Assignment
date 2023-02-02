
using AccountExampleDay3;
using System;


public class MainClass
{

    static bool toBeContuned = true;
    static Account[] accounts = new Account[10];
    static int account_counter = 0;

    public static void Main(string[] args)
    {

        while (true)
        {
            Console.Write("Which Operation To Perform ? \n 1 : Create Account \n 2: PrintSummary \n 3 : Enquiry \n 4 : Nothing \n ");

            Console.WriteLine("Enter Choice : \n ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // Create Account
                    Console.WriteLine("Enter Name Of Account Holder : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Initial Balance : ");
                    float balance = float.Parse(Console.ReadLine());
                    accounts[account_counter++] = new Account(balance, name);
                    break;
                case 2: // Print Summary 
                    Console.WriteLine("Enter Account Number to print summary : \n ");
                    Console.WriteLine(BalanceEnquirey(Convert.ToInt32(Console.ReadLine())));
                    break;
                // Extras 
                // case 3: // Deposit 
                // Console.WriteLine("Enter Account Number ot deposit in");
                // int account_no = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Enter Amount To Depost in account No {0}",account_no);
                // float amount = ConvertToFloar32(Console.ReadLine());

                case 4: // Exit 
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

    public static string BalanceEnquirey(int account_no)
    {
        Account a = null;
        foreach (Account acc in accounts)
        {
            if (acc.AccountNo == account_no)
            {
                a = acc;
                break;
            }
        }
        return string.Format("User with Account Number : {0} \n with name : {1} \n has total balance of RS : {2} \n ", a.AccountNo, a.CustomerName, a.Balance);
    }
}





