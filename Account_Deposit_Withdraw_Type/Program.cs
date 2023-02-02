using Account_Deposit_Withdraw_Type;
using Account_Deposit_Withdraw_Type.MyExceptions;

public class MainClass
{
    static bool toBeContuned = true;

    public static void Main(string[] args)
    {

        AccountHolder accountHolder = new AccountHolder();
        int account_no = 0;
        bool isValid = false;
        float amount = 0f;
        Console.Write("Which Operation To Perform ? \n 1 : Create Account \n 2 : Transaction  \n 3 : Summary \n 4 : Exit\n");
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
                    accountHolder.CreateAccount(name, balance);
                    break;
                case 2: // Perform Transaction
                    Console.WriteLine("Wich Operations You Want to Perform ?\n 1 : Depost \n 2 : Withdrawal");
                    int tChoice = int.Parse(Console.ReadLine());
                    switch ((TransactionType)tChoice)
                    {
                        case TransactionType.Deposit:
                            Console.WriteLine("Enter The Account Number to Deposit In : ");
                            account_no = int.Parse(Console.ReadLine());
                            try
                            {
                                isValid = accountHolder.isValidAccount(account_no);
                            }
                            catch (InvalidAccountNumberException e)
                            {
                                Console.WriteLine(e.ToString());
                            }
                            if (isValid)
                            {
                                Console.WriteLine("Enter The Amount to Deposit In Accoount Number {0}: ", account_no);
                                amount = float.Parse(Console.ReadLine());
                                accountHolder.DepositAmount(account_no, amount);
                            }
                            break;
                        case TransactionType.Withdrawal:
                            Console.WriteLine("Enter The Account Number to Withdraw from : ");
                            account_no = int.Parse(Console.ReadLine());

                            try
                            {
                                isValid = accountHolder.isValidAccount(account_no);
                            }
                            catch (InvalidAccountNumberException e)
                            {
                                Console.WriteLine(e.ToString());
                            }
                            if (isValid)
                            {
                                Console.WriteLine("Enter The Amount to Withdraw from Accoount Number {0}: ", account_no);
                                amount = float.Parse(Console.ReadLine());
                                accountHolder.WithdrawAmount(account_no, amount);
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 3: // Print All
                    accountHolder.PrintAllAccounts();
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

