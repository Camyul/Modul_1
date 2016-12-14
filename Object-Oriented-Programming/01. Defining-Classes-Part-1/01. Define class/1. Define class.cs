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

            GSM firstGSM = new GSM("3310", "Nokia");
            Battery firstBattery = new Battery("BS-50HL", 100, 4);
            Display firstDisplay = new Display(5.5, 65000);
            
            GSM secondGSM = new GSM("G4", "LG", 330, "Pesho");
            GSM thirdGSM = new GSM("S7 Edge", "Samsung");
            GSMTest gsmTest = new GSMTest(new GSM[] { firstGSM, secondGSM, thirdGSM} ) ;

            Console.WriteLine("Display info about class: GSM, Battery, Display\n");
            Console.WriteLine(firstGSM.ToString());
            Console.WriteLine(firstBattery.ToString());
            Console.WriteLine(firstDisplay.ToString());
            Console.WriteLine();
            //Console.WriteLine("\nIPhone4S: {0}\n\n", GSM.IPhone4S);
            
            gsmTest.DisplayTest();
            Console.WriteLine(GSM.IPhone4S.ToString());

            //List<Call> callHist = new List<Call>();

            HistoryTest callTest = new HistoryTest();
            callTest.TestHistory();

        }
    }
}
