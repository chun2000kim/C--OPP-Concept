using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class BankAccountInfor
    {
        public string BankName { get; set; }
        public string GetBankName()
        {
            return BankName;
        }
    }
    public class Client : BankAccountInfor
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
    }


}
