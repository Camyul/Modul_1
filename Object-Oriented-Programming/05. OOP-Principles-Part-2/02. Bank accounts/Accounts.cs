namespace Bank_accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public abstract class Accounts
    {

        // Mortgage and loan accounts you have to return money to the bank
        // so them creating with negative balance.

        private Customers customer;
        private decimal balance;
        private decimal interestRate;
        private DateTime regDate;

        public Accounts(Customers client, decimal balance, decimal interestRate)
        {
            this.customer = client;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.regDate = DateTime.Now;
        }

        public decimal Balance
        {
            get { return this.balance; }
            private set
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
    }
}
