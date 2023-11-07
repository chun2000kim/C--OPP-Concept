using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class BankAccount
    {
        public virtual void AccountInformation()
        {
            string AccountID = "0000120230711";
            string AccountType = "Payroll";

            Console.WriteLine("Account ID : "+ AccountID + "\nAccount Type :" + AccountType);
        } 
    }
    public class Customer : BankAccount 
    {
        public override void AccountInformation()
        {
            string AccountHolder = "Kim";
            string AccountID = "0000120230712";
            string AccountType = "Payroll";
            
            Console.WriteLine("\nAccount Holder : "+ AccountHolder +"\nAccount ID : " + AccountID + "\nAccount Type :" + AccountType);
        }
    }
}
