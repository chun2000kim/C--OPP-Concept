using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //call and out put Abstract class
            EmployeeBaseSalary employeeBaseSalary = new EmployeeBaseSalary();

            Console.WriteLine("Call Class and Abstract Method\n----------------------------------");
            Console.WriteLine("Employee Name :" + employeeBaseSalary.Name + " Salary : " + employeeBaseSalary.Salary());

            //call and out put Encapsulation

            AccountBalance account = new AccountBalance(5000);
            Console.WriteLine("\nCall Encapsulation\n---------------------------------------");
            account.withdraw(100);
            account.diposit(200);

            //call and out put Polymorphisms Compile Time 

            Console.WriteLine("\nCall Polymorphisms Compile Time\n----------------------------------------");
            BankTransactions bankTransactions = new BankTransactions();
            bankTransactions.Transaction(2500);
            bankTransactions.Transaction(2500, 500);
            bankTransactions.Transaction(2500, 500, 500);


            //call and out put Polymorphisms Run Time
            Console.WriteLine("\nCall Polymorphisms Compile Time\n----------------------------------------");
            BankAccount bankAccount = new BankAccount();
            bankAccount.AccountInformation();
            Customer customer = new Customer();
            customer.AccountInformation();

            //call and out put Polymorphisms Run Time
            Console.WriteLine("\nCall Inheritant\n----------------------------------------");
            BankAccountInfor bankAccountInfor = new BankAccountInfor();
            bankAccountInfor.BankName = "ABC Bank";
            //Console.WriteLine(bankAccountInfor.GetBankName());

            Client client = new Client();
            client.BankName = bankAccountInfor.BankName;
            client.GetBankName();
            client.CustomerID = "202301";
            client.CustomerName = "Kim";
            Console.WriteLine("Bank Name : "+ client.GetBankName() +"\nClient ID : " + client.CustomerID + "\nClient Name : " + client.CustomerName);

        }
    }
}
