using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_ClassLibrary
{
    public class Display
    {
        private double displaySize;
        private int numberOfColor;

        public Display()
        {
            this.displaySize = 5;
            this.numberOfColor = 4096;
        }
        public Display(double displaySize, int numberOfColor)
        {
            this.displaySize = displaySize;
            this.numberOfColor = numberOfColor;
        }
        public double DisplaySize
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                if (value <= 0 || value > 15)
                {
                    throw new IndexOutOfRangeException("Value can't be smaller from \"0\" and biggest from 15 ");
                }
                this.displaySize = value;
            }
        }
        public int NumberOfColor
        {
            get
            {
                return this.numberOfColor;
            }
            set
            {
                if (value <= 0 )
                {
                    throw new IndexOutOfRangeException("Value can't be smaller from \"0\" and biggest from 15 ");
                }
                this.numberOfColor = value;
            }
        }
        public override string ToString()
        {
            return String.Format("Display Size: {0}\"\n\rNumber Of Color: {1}", 
                this.displaySize, this.numberOfColor);
        }
        
    }
}
