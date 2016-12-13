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
        private string price;
        private string owner;

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
        }
        public GSM(string model, string manufacturer, string price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        public GSM(string model, string manufacturer, string price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        public void PrintGSM()
        {
            Console.WriteLine("Model: {0}\n\rManufacturer: {1}", this.model, this.manufacturer);
            Console.WriteLine("Price: {0}\n\rOwner: {1}", this.price ?? "No Price", this.owner ?? "No Owner");
        }
    }
}
