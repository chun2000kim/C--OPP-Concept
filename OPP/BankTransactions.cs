using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class BankTransactions
    {
        public void Transaction(decimal avalableBalance)
        {
            Console.WriteLine(" + your available balance : " + avalableBalance);
        }

        public void Transaction(decimal avalableBalance, decimal dipositAmount)
        {
            if (dipositAmount > avalableBalance)
            {
                Console.WriteLine("insufition fun!");
            }
            else
            {
                avalableBalance -= dipositAmount;
                Console.WriteLine(" + you have diposit : " + dipositAmount);
                Console.WriteLine(" + Available Balance : " + avalableBalance);
            }
        }
        public void Transaction(decimal avalableBalance, decimal withdrawAmount, decimal dipositAmount)
        {
            avalableBalance += withdrawAmount;
            Console.WriteLine(" + Withdraw​ : " + withdrawAmount);
            if (dipositAmount > avalableBalance)
            {
                Console.WriteLine("insufition fun!");
            }
            else
            {
                avalableBalance -= dipositAmount;
                Console.WriteLine(" + you have diposit : " + dipositAmount);
                Console.WriteLine(" + Available Balance : " + avalableBalance);
            }

        }


    }

}
