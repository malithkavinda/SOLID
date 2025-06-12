using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.WrongSolution
{
    public class PermanentEmployee : Employee
    {
        public override decimal CalculateBonus()
        {
            return 30;
        }

        public override decimal CalculateSalary()
        {
            return 500;
        }
    }
}
