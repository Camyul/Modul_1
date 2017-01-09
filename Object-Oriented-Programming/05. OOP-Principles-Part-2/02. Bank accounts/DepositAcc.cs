namespace Bank_accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class DepositAccount : Accounts, Ideposit, IWithDraw
    {

        public DepositAccount(Customers client, decimal balance, decimal interestRate) : base(client, balance, interestRate)
        {
            if (balance < 0)
            {
                throw new ArgumentOutOfRangeException("Deposit balans cannot be negative!");
            }
        }

        
        public void AddMoney(decimal money) //Method to deposit Money
        {
            this.Balance += money;
        }

        public void WithDraw(decimal money)     //Method to WithDraw Money
        {
            if (this.Balance - money >= 0)
            {
                this.Balance -= money;
            }
            else
            {
                throw new ArithmeticException("Not Enough Money!");
            }
        }

        public override decimal CalcInterest(decimal numberMounts)
        {
            decimal result = 0;
            if (this.Balance >= 1000)
            {
               result = numberMounts * this.InterestRate;
            }
            return result;
        }

        
    }
}
