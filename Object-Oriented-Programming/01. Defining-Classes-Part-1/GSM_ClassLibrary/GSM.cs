﻿using System;

namespace GSM_ClassLibrary
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        //private static string iPhone4S;
        private static GSM iPhone4S = new GSM("IPhone 4S", "Apple");


        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, int price):this(model, manufacturer)
        {
            this.price = price;
        }
        public GSM(string model, string manufacturer, int price, string owner) : this(model, manufacturer, price)
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
        public int Price
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
        public override string ToString()
        {
            return String.Format("Model: {0}\n\rManufacturer: {1}\n\rPrice: {2}\n\rOwner: {3}",
                this.model, this.manufacturer, this.price, this.owner ?? "No Owner");
        }
    }
}
