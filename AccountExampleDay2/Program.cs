
using AccountExampleDay2;
using System;

public class MainClass
{

    static bool toBeContuned = true;

    public static void Main(string[] args)
    {
        AccountHolder accountHolder = new AccountHolder();
        int account_no = 0;
        float amount = 0f;
        Console.Write("Which Operation To Perform ? \n 1 : Create Account \n 2: PrintSummary \n 3 : Deposit \n 4 : Withdraw \n 5 : Exit \n");

        while (true)
        {

            Console.WriteLine("Enter Choice :  ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // Create Account
                    Console.WriteLine("Enter Name Of Account Holder : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Initial Balance : ");
                    float balance = float.Parse(Console.ReadLine());
                    accountHolder.createAccount(balance, name);
                    break;
                case 2: // Print Summary 
                    accountHolder.printSummary();
                    break;
                case 3: // Deposit
                    Console.WriteLine("Enter The Account Number to Deposit In : ");
                    account_no = int.Parse(Console.ReadLine());

                    if (accountHolder.isValidAccount(account_no))
                    {
                        Console.WriteLine("Enter The Amount to Deposit In Accoount Number {0}: ", account_no);
                        amount = float.Parse(Console.ReadLine());
                        accountHolder.DepositAmount(account_no, amount);
                    }
                    else
                    {
                        Console.WriteLine("Please Enter Valid Account Number");
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter The Account Number to Withdraw from : ");
                    account_no = int.Parse(Console.ReadLine());
                    if (accountHolder.isValidAccount(account_no))
                    {
                        Console.WriteLine("Enter The Amount to Withdraw from Accoount Number {0}: ", account_no);
                        amount = float.Parse(Console.ReadLine());
                        accountHolder.WithdrawAmount(account_no, amount);
                    }
                    else
                    {
                        Console.WriteLine("Please Enter Valid Account NO");
                    }

                    break;
                case 5: // Exit 
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






