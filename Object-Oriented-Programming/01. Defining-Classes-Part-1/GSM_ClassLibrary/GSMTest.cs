using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_ClassLibrary
{
    public class GSMTest
    {
        private GSM[] gsmArray;

        public GSMTest(GSM[] gsmArray)
        {
            this.gsmArray = gsmArray;
        }
        public GSM[] GsmArray { get; set; }

        public void DisplayTest()
        {
            Console.WriteLine("GSM Test, Display the information about the GSMs in the array: ");
            Console.WriteLine("Model\t\tManufacturer\tPrice\tOwner");
            foreach (var gsm in gsmArray)
            {
                Console.Write("{0}\t\t{1}\t\t{2}\t{3}\n",
                gsm.Model, gsm.Manufacturer, gsm.Price, gsm.Owner ?? "No Owner");
            }
        }


    }
}
