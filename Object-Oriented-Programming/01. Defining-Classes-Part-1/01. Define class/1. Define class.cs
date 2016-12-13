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
            firstGSM.Price = uint.Parse(Console.ReadLine());
            Console.Write("Enter GSM Owner Name: ");
            firstGSM.Owner = Console.ReadLine();

            firstGSM.PrintGSM();
            firstBattery.PrintBattery();
            firstDisplay.PrintDisplay();

        }
    }
}
