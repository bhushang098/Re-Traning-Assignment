using Account_Deposit_Withdraw_Type.MyExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Deposit_Withdraw_Type
{
    internal class Account
    {
        private static int No = 101;
        private int _accountNumber;
        private string _customerName;
        private float _accountBalance;

        public int AccountNumber { get { return this._accountNumber; } }

        public Account(string name, float amount)
        {
            this._accountNumber = No++;
            this._customerName = name;
            this._accountBalance = amount;


        }
        public void Credit(float amount)
        {
            this._accountBalance += amount;
        }

        public void Debit(float amount)
        {
            if (amount <= this._accountBalance)
            {
                // Perform operations
                this._accountBalance -= amount;
            }
            else
            {
                throw new InSufficientBalanceException("Insufficient Balance in account please Deposit more amount and try again");
            }
        }

        public void printAccount()
        {
            Console.WriteLine("Name of Account Holder is : {0} \n Total Balance is RS : {1} ", this._customerName, this._accountBalance);
            Console.WriteLine("------------------------\n");
        }
    }
}
