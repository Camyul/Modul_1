using System;
using System.Collections.Generic;
using System.Text;

namespace GSM_ClassLibrary
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private int? price;
        private string owner;
        private static GSM iPhone4S = new GSM("IPhone 4S", "Apple");
        private List<Call> callHistory = new List<Call>();


        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, int? price):this(model, manufacturer)
        {
            this.price = price;
        }
        public GSM(string model, string manufacturer, int? price, string owner) : this(model, manufacturer, price)
        { // С двете точки Пренасочва към горния конструктор.
            this.owner = owner;
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                
                iPhone4S = value;
            }
        }

        internal Call FindLongestDial()
        {
            Call longestCall = new Call("", "", "", 0);
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (longestCall.Duration < callHistory[i].Duration)
                {
                    longestCall = callHistory[i];
                }
               
            }
            return longestCall;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
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
                if (!String.IsNullOrEmpty(value))
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentNullException("Manufacturer can't be Empty");
                }

            }
        }
        public int? Price
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
               this.owner = value;
            }
        }
        public decimal PriceAllCalls(decimal perMinute)
        {
            ulong totalSecond = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalSecond += callHistory[i].Duration;
            }
            int newMinute = (totalSecond % 60 == 0) ? 0 : 1;
            decimal allCalsPrice = ((totalSecond / 60) + (ulong)newMinute) * perMinute;
            return allCalsPrice;
        }
        public string CallsInfo()
        {
            if (callHistory.Count == 0)
            {
                return "Call history is empty!";
            }
            StringBuilder callsInfo = new StringBuilder();
            callsInfo.Append("Date\t\tTime\t\tDailed number\tDuration seconds\n");
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                callsInfo.Append(callHistory[i].Date.ToString());
                callsInfo.Append("\t");
                callsInfo.Append(callHistory[i].Time.ToString());
                callsInfo.Append("\t");
                callsInfo.Append(callHistory[i].DialledNumbers.ToString());
                callsInfo.Append("\t");
                callsInfo.Append("\t");
                callsInfo.Append(callHistory[i].Duration.ToString());
                callsInfo.Append("\n");
            }
            return callsInfo.ToString();
        }
        private List<Call> CallHistory { get; set; }

        public void AddCall(Call newCall)
        {
            this.callHistory.Add(newCall);
        }

        public void DeleteCall(Call callToDel)
        {
            if (!callHistory.Contains(callToDel))
            {
                return;
            }
            callHistory.Remove(callToDel);
        }
        public void DeleteAllHistory()
        {
            
            callHistory.Clear();
        }
        public override string ToString()
        {
            //Console.WriteLine("Model\tManufacturer\tPrice\tOwner");
            return String.Format("{0}\t{1}\t\t{2}\t{3}\n",
                this.Model, this.Manufacturer, this.Price, this.Owner ?? "No Owner");
            //return String.Format("Model: {0}\n\rManufacturer: {1}\n\rPrice: {2}\n\rOwner: {3}",
            //    this.model, this.manufacturer, this.price, this.owner ?? "No Owner");
        }
    }
}
