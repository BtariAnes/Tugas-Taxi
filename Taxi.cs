using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_taxi
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            if (OnDuty != true)
                Console.WriteLine("On Duty : No");
            else
                Console.WriteLine("On Duty : Yes");
        }

        public void PickUpPassanger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang\n", DriverName);
        }

        public void PickOffPassanger()
        {
            Console.WriteLine("{0} selesai menjemput penumpang\n", DriverName);
        }

    }
}
