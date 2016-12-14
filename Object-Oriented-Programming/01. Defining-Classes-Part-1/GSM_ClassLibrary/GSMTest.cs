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
            foreach (var gsm in gsmArray)
            {
                Console.Write("Model: {0}\n\rManufacturer: {1}\n\r",
                gsm.Model, gsm.Manufacturer);
            }
        }


    }
}
