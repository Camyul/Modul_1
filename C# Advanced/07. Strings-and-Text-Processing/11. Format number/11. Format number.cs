using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format_number
{
    class FormatNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string num;
            num = number.ToString("D").PadLeft(15, ' ');
            Console.WriteLine(num);
            num = number.ToString("X").PadLeft(15, ' ');
            Console.WriteLine(num);
            num = number.ToString("P2").PadLeft(15, ' ');
            Console.WriteLine(num);
            num = number.ToString("E").PadLeft(15, ' ');
            Console.WriteLine(num);
        }
    }
}
