﻿using System;
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
            Battery firstBattery = new Battery();
            Display firstDisplay = new Display();
            
            firstBattery.BatModel = "BS-50HL";
            firstBattery.HoursIdle = 100;
            firstBattery.HoursTalk = 4;
            firstDisplay.DisplaySize = 5.5;
            firstDisplay.NumberOfColor = 65000;

            GSM secondGSM = new GSM("G4", "LG");
            GSM thirdGSM = new GSM("S7 Edge", "Samsung");
            GSMTest gsmTest = new GSMTest(new GSM[] { firstGSM, secondGSM, thirdGSM} ) ;


            Console.WriteLine(firstGSM.ToString());
            Console.WriteLine(firstBattery.ToString());
            Console.WriteLine(firstDisplay.ToString());
            Console.WriteLine("IPhone4S CPU: {0}", GSM.IPhone4S);

            gsmTest.DisplayTest();
            Console.WriteLine(GSM.IPhone4S.ToString());

            //List<Call> callHist = new List<Call>();

            HistoryTest callTest = new HistoryTest();
            callTest.TestHistory();

        }
    }
}
