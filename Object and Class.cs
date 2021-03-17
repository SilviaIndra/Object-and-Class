using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_and_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek TAXI
            TAXI taxi = new TAXI();

            // pengesetan nilai properties
            taxi.DriverName = " Gilang ";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPasesenger();

            Console.ReadKey();
        }
    }
}
