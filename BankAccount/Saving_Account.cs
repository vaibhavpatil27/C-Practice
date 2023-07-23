using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Saving_Account : Account
    {
        double interest_rate, rate;
        public void calculateintrest()
        {
            interest_rate = 0.02;
            //calculation
            rate = tobal * (interest_rate / 100);
            final_Amt = tobal + rate;
            Console.WriteLine("Total Balance Amount with Interest : " + final_Amt);
        }

    }
}
