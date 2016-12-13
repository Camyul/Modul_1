using System;
using GSM_ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_class
{
    class Program
    {
        static void Main()
        {
            GSM firstGSM = new GSM("N70", "Nokia");
            firstGSM.PrintGSM();
            Battery firstBattery = new Battery("BS-50HL", 120, 6);
            firstBattery.PrintBattery();
            Display firstDisplay = new Display("5.5", 16K)
        }
    }
}
