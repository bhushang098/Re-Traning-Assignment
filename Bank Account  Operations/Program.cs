
using System;
using System.Collections;

public enum AccountType
{
    Current = 1,
    Savings,
    Business,
    Loan
}

public class Account
{
    private static int No = 101;
    private int _accountNumber;
    private string _accountHolderName;
    private float _accountBalance;
    private AccountType _accountType;

    public int AccountNumber { get { return this._accountNumber; } }

    public Account(string name, float amount, AccountType type)
    {
        this._accountNumber = No++;
        this._accountHolderName = name;
        this._accountBalance = amount;
        this._accountType = type;

    }
    public void Deposit(float amount)
    {
        this._accountBalance += amount;
    }

    public void Withdraw(float amount)
    {
        if (amount <= this._accountBalance)
        {
            // Perform operations
            this._accountBalance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    public void printAccount()
    {
        Console.WriteLine("Name of Account Holder is : {0} \n Total Balance is RS : {1} \n Type of Account is : {2}", this._accountHolderName, this._accountBalance, this._accountType);
        Console.WriteLine("------------------------\n");
    }
}

public class AccountHolder
{
    private Account[] accounts;
    private static int counter = 0;

    public AccountHolder()
    {
        accounts = new Account[10];
    }

    public void CreateAccount(string name, float amount, AccountType type)
    {
        accounts[counter++] = new Account(name, amount, type);
    }

    public void PrintAllAccounts()
    {
        foreach (Account a in accounts)
        {
            if (a != null)
                a.printAccount();
            else
                break;
        }
    }

    public bool isValidAccount(int accountNo)
    {
        foreach (Account a in accounts)
        {

            if (a != null)
            {
                if (a.AccountNumber == accountNo)
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

    public bool DepositAmount(int account_no, float amount)
    {
        foreach (Account a in accounts)
        {
            if (a != null)
            {
                if (a.AccountNumber == account_no)
                {
                    a.Deposit(amount);
                    return true;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Please Enter Valid Account Number");
                break;
            }

        }

        return false;
    }

    public bool WithdrawAmount(int account_no, float amount)
    {
        foreach (Account a in accounts)
        {
            if (a != null)
            {
                if (a.AccountNumber == account_no)
                {
                    a.Withdraw(amount);
                    return true;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Enter Valid Account Number");
                break;
            }

        }
        return false;
    }

}

public class MainClass
{
    static bool toBeContuned = true;

    public static void Main(string[] args)
    {

        AccountHolder accountHolder = new AccountHolder();
        int account_no = 0;
        float amount = 0f;
        AccountType type = AccountType.Current;
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

                    Console.WriteLine("Select The Type of Account \n 1 = Current \n 2 = Savings \n 3 = Business \n 4 = Loan");

                    int typeChoice = int.Parse(Console.ReadLine());
                    switch (typeChoice)
                    {
                        case 1:
                            type = AccountType.Current;
                            break;
                        case 2:
                            type = AccountType.Savings;
                            break;
                        case 3:
                            type = AccountType.Business;
                            break;
                        case 4:
                            type = AccountType.Loan;
                            break;
                        default:
                            break;

                    }
                    accountHolder.CreateAccount(name, balance, type);
                    break;
                case 2: // Print All Accounts 
                    accountHolder.PrintAllAccounts();
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

