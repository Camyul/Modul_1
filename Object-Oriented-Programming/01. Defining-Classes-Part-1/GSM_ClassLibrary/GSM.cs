using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_ClassLibrary
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private uint price;
        private string owner;

        

        public GSM()
        {
            this.model = null;
            this.manufacturer = null;
        }
        public GSM(string model, string manufacturer, uint price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        public GSM(string model, string manufacturer, uint price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value != null)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentNullException("Model can't be Empty");
                }

            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != null)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentNullException("Manufacturer can't be Empty");
                }

            }
        }
        public uint Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArithmeticException("Price can't be zero or negative value");
                }
                else
                {
                    this.price = value;
                }

            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length >  20)
                {
                    throw new ArgumentOutOfRangeException("name must be < 20 letters");
                }
                else
                {
                    this.owner = value;
                }

            }
        }
        public void PrintGSM()
        {
            Console.WriteLine("Model: {0}\n\rManufacturer: {1}", this.model, this.manufacturer);
            Console.WriteLine("Price: {0}\n\rOwner: {1}", this.price, this.owner ?? "No Owner");
        }
    }
}
