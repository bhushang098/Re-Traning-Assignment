using Account_Deposit_Withdraw_Type.MyExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Deposit_Withdraw_Type
{
    internal class AccountHolder
    {
        private Account[] accounts;
        private static int counter = 0;

        public AccountHolder()
        {
            accounts = new Account[10];
        }

        public void CreateAccount(string name, float amount)
        {
            accounts[counter++] = new Account(name, amount);
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
                    throw new InvalidAccountNumberException("Invalid Account Number Given");
                }
            }
            throw new InvalidAccountNumberException("Invalid Account Number Given"); ;
        }

        public bool DepositAmount(int account_no, float amount)
        {
            if(amount<=0)
            {
                Console.WriteLine("Enter valid Amount");
                return false;
            }
            foreach (Account a in accounts)
            {
                if (a != null)
                {
                    if (a.AccountNumber == account_no)
                    {
                        a.Credit(amount);
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
            if (amount <= 0)
            {
                Console.WriteLine("Enter valid Amount");
                return false;
            }
            foreach (Account a in accounts)
            {
                if (a != null)
                {
                    if (a.AccountNumber == account_no)
                    {
                        try
                        {
                            a.Debit(amount);
                            return true;
                        }
                        catch (InSufficientBalanceException e)
                        {
                            Console.WriteLine(e.ToString());
                            return false;
                        }
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
}
