using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArv2
{
    class House : Property
    {
        private double OutsideAreaSize;

        public void SetOutsideAreaSize(double NewSize)
        {
            OutsideAreaSize = NewSize;
        }

        public double GetOutsideAreaSize()
        {
            return OutsideAreaSize;
        }
    }

}
