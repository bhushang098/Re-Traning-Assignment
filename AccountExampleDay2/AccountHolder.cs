using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountExampleDay2
{
    internal class AccountHolder
    {
        byte counter;
        static Account[] accounts;

        public AccountHolder()
        {
            counter = 0;
            accounts = new Account[10];
        }

        public Account createAccount(float balance, string name)
        {
            Account newAccount = new Account(balance, name);
            accounts[counter++] = newAccount;
            return newAccount;

        }


        public void printSummary()
        {
            foreach (Account account in accounts)
            {

                if (account != null)
                {
                    Account.printAccount(account);
                }
                else
                {
                    break;
                }



            }
        }

        public bool DepositAmount(int account_no, float amount)
        {
            foreach (Account a in accounts)
            {
                if (a != null)
                {
                    if (a.AccountNo == account_no)
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
                    if (a.AccountNo == account_no)
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

        public bool isValidAccount(int accountNo)
        {
            foreach (Account a in accounts)
            {

                if (a != null)
                {
                    if (a.AccountNo == accountNo)
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
    }
}
