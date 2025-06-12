using OpenClose.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Calculation
{
    public class CurrentAccount : ICalculation
    {
        readonly decimal Interest_rate = 9.23M;
        public decimal InterestCalculation(decimal balance)
        {
           return (balance * Interest_rate )/100;
        }
    }
}
