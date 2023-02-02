using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountExampleDay3
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
            Console.WriteLine(AccountSummary());
        }

        // Member Functions

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

        public string AccountSummary()
        {
            return string.Format("New Account User with Account Number : {0} \n with name : {1} \n is Created Successfully\n ", this._accountNumber, this._customerName);
        }

    }
}
