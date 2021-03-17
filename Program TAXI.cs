using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_and_Class
{
    class TAXI
    {
        // properties
        public bool DriverName { get; set; }
        public bool OnDuty { get; set; }
        public bool NumPassenger { get; set; }

        // medthod
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name          : {0}", DriverName);
            if (OnDuty) Console.WriteLine("OnDuty   : yes");
            else Console.WriteLine("On Duty         : No");
            Console.WriteLine("Number of Passenger  : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine(" {0} Sedang menjemput penumpang\n", DriverName);
        }
        public void DropOffPasesenger()
        {
            Console.WriteLine(" {0} Selesai mengantar penumpang", DriverName);
        }
    }
}
