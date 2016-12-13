using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_ClassLibrary
{
    public class Display
    {
        private string displaySize;
        private string numberOfColor;

        public Display()
        {
            this.displaySize = null;
            this.numberOfColor = null;
        }
        public Display(string displaySize, string numberOfColor)
        {
            this.displaySize = displaySize;
            this.numberOfColor = numberOfColor;
        }
        public void PrintDisplay()
        {
            Console.WriteLine("Display Size: {0}\n\rNumber Of Color: {1}",
                            this.displaySize ?? "n\\a", this.numberOfColor ?? "n\\a");
        }
    }
}
