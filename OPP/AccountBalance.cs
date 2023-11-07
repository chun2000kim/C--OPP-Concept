using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class AccountBalance
    {
       private decimal balance;

        public AccountBalance(decimal availableBalance)
        {
                balance = availableBalance;
        }
        public void diposit(decimal amount) 
        {
              balance += amount;
              Console.WriteLine("you have diposit amount : " + amount);
              Console.WriteLine("you available amount : " + balance);
        }
        public void withdraw(decimal amount) 
        {
            if (balance < amount)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("you have withdraw  amount :" + amount);
            }
        }
    }
}
