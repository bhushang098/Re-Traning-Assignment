using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountExampleDay2
{
    internal class Account
    {
        public static int accntNo = 101;
        private int _accountNumber;
        private string _customerName;
        private float _balance;

        public float Balance
        {
            get { return this._balance; }
        }

        public int AccountNo
        {
            get { return this._accountNumber; }

        }

        public string CustomerName
        {
            get { return this._customerName; }

        }

        public Account(float balance, string customerName)
        {
            this._accountNumber = accntNo++;
            this._balance = balance;
            this._customerName = customerName;

        }

        public void Deposit(float amount)
        {
            this._balance += amount;
        }

        public void Withdraw(float amount)
        {
            if (amount <= this._balance)
            {
                // Perform operations
                this._balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public static void printAccount(Account a)
        {
            if (a != null)
            {
                Console.WriteLine("Account Number is : {0} \n  Name of Account Holder is : {1} \n Total Balance is RS : {2} ", a.AccountNo, a.CustomerName, a.Balance);

                Console.WriteLine("------------------------\n");

            }

        }
    }
}
