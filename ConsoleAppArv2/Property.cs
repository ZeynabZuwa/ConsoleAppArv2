using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArv2
{
    class Property
    {
        private string Address;

        public void SetAddress(string NewAddress)
        {
            Address = NewAddress;
        }

        public string GetAddress()
        {
            return Address;
        }
    }
}
