using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.WrongSolution
{
    public class ContractEmployee : Employee
    {
        public override decimal CalculateSalary()
        {
            return 100;
        }
    }
}
