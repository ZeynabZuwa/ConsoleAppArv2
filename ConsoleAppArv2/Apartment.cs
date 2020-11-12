using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArv2
{
    class Apartment : Property
    {
        // private string Address;
        private double MonthlyFee;

        public void SetMonthlyFee(double NewFee)
        {
            MonthlyFee = NewFee;
        }

        public double GetMonthlyFee()
        {
            return MonthlyFee;
        }
    }
}
