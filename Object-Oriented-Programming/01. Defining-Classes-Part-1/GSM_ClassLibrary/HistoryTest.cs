using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_ClassLibrary
{
    public class HistoryTest
    {
        private GSM testHistoryGSM = new GSM("S7", "Samsung");
        public const decimal perMinute = 0.37m;

        public GSM TestHistoryGSM { get; set; }
        public void TestHistory()
        {
            testHistoryGSM.AddCall(new Call("14.12.2016", "09:39:25", "0888975656", 300));
            testHistoryGSM.AddCall(new Call("04.12.2016", "11:25:20", "0898543212", 100));
            testHistoryGSM.AddCall(new Call("03.12.2016", "03:27:17", "0877455645", 287));
            testHistoryGSM.AddCall(new Call("11.12.2016", "09:05:34", "0899454566", 545));
            Console.WriteLine("Print Call History:");
            Console.WriteLine(testHistoryGSM.CallsInfo());
            Console.WriteLine("Total price of the calls in the history:");
            Console.WriteLine("Total Cals Price: {0:F2}BGN\n", testHistoryGSM.PriceAllCalls(perMinute));          
            Call longestCall = testHistoryGSM.FindLongestDial();
            testHistoryGSM.DeleteCall(longestCall);
            Console.WriteLine("Total price of the calls in the history without Longest Call:");
            Console.WriteLine("Total Cals Price: {0:F2}BGN\n", testHistoryGSM.PriceAllCalls(perMinute));
            testHistoryGSM.DeleteAllHistory();
            Console.WriteLine("Print Call History:");
            Console.WriteLine(testHistoryGSM.CallsInfo());

        }
    }
}
