namespace Bank_accounts
{
    using System;
    public abstract class Customers
    {
        private string name;
        private long idNumber;

        public Customers(string name, long idNum)
        {
            this.Name = name;
            this.idNumber = idNum;
        }

        public string Name { get; private set; }
        public long IdNumber
        {
            get { return this.idNumber; }
            private set
            {
                if (value < 100000000 || value > 999999999)
                {
                    throw new ArgumentOutOfRangeException("Enter valid IDNumber");
                }
                this.idNumber = value;
            }
        }

        public void ChangeIDNumber(long newIdNumber)  //Method for change IDNumber
        {
            this.IdNumber = newIdNumber;
        }

        public override string ToString()
        {
            return String.Format("{0}\tIDNumber: {1}", this.Name, this.IdNumber);
        }
    }
}
