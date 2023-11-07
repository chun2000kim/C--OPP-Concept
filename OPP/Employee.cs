using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public abstract class Employee
    {
        public string Name { get; set; } = "Kim";
        public abstract int Salary();
    }
    public class EmployeeBaseSalary : Employee
    {
        public override int Salary()
        {
            return 2500;
        }
    }

}
