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

            GSM firstGSM = new GSM();
            Battery firstBattery = new Battery();
            Display firstDisplay = new Display();
            Console.Write("Enter GSM Model: ");
            firstGSM.Model = Console.ReadLine();
            Console.Write("Enter Manufacturer Name: ");
            firstGSM.Manufacturer = Console.ReadLine();
            Console.Write("Enter GSM Price: ");
            firstGSM.Price = int.Parse(Console.ReadLine());
            Console.Write("Enter GSM Owner Name: ");
            firstGSM.Owner = Console.ReadLine();
            firstBattery.BatModel = "BS-50HL";
            firstBattery.HoursIdle = 100;
            firstBattery.HoursTalk = 4;
            firstDisplay.DisplaySize = 5.5;
            firstDisplay.NumberOfColor = 65000;

            Console.WriteLine(firstGSM.ToString());
            Console.WriteLine(firstBattery.ToString());
            Console.WriteLine(firstDisplay.ToString());


        }
    }
}
