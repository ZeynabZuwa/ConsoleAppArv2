using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartment MyApartment = new Apartment();
            MyApartment.SetAddress("Lugna gatan 1");
            MyApartment.SetMonthlyFee(8500.0);

            House MyHouse = new House();
            MyHouse.SetAddress("Fina gatan 1");
            MyHouse.SetOutsideAreaSize(55.5);

            Property[] PrArray = new Property[2];
            PrArray[0] = MyApartment;
            PrArray[1] = MyHouse;

            for (int i = 0; i < PrArray.Length; i++)
            {
                Console.WriteLine(PrArray[i].GetAddress());
            }

        }
    }
}
