using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class CheckingAccount : Saving_Account
    {
        double fee_per = 15;
        public void fee()
        {
            Console.WriteLine("Balance After Transection Charges : " + (tobal - fee_per));
        }

    }
}
