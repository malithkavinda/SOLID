using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.WrongSolution
{
    public class Employee
    {
        public virtual decimal CalculateSalary()
        {
            Console.WriteLine("This is Employee base class");
            return 200;
        }

        public virtual decimal CalculateBonus()
        {
            Console.WriteLine("This is Employee base class");
            return 20;
        }
    }
}
