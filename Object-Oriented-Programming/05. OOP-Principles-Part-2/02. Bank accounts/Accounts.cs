namespace Bank_accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public abstract class Accounts
    {

        private Customers customer;
        private decimal balance;
        private decimal interestRate;
        private DateTime regDate;

        public Accounts(Customers client, decimal balance, decimal interestRate)
        {
            this.Customer = client;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.regDate = DateTime.Now;
        }

        public Customers Customer {
            get
            {
                return this.customer;
            }
            private set
            {
                this.customer = value;
            }
        }
            
        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                this.balance = value;
            }
        }
        public decimal InterestRate
        {
            get { return this.interestRate; }
            private set
            {
                if (value <= 0 || value > 200)
                {
                    throw new ArgumentOutOfRangeException("The Interest Rate is negativ, zero or too big");
                }
                this.interestRate = value;
            }
        }

        public abstract decimal CalcInterest(decimal numberMounts);

        public override string ToString()
        {
            return String.Format("{1}\nOwner: {0}\nBalance: {2:C}\nInterest Rate: {3}%",
                        this.Customer.ToString(), GetType().Name, this.Balance, this.interestRate);
        }

    }
}
