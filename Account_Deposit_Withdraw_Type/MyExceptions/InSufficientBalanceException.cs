using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Deposit_Withdraw_Type.MyExceptions
{
    internal class InSufficientBalanceException : Exception
    {
        public InSufficientBalanceException(string message) : base(message)
        {

        }
    }
}
