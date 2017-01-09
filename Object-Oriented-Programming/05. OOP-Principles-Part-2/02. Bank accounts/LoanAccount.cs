namespace Bank_accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class LoanAccount : Accounts, Ideposit
    {
        // Mortgage and loan accounts you have to return money to the bank
        // so them creating with negative balance.

        public LoanAccount(Customers client, decimal balance, decimal interestRate) : base(client, balance, interestRate)
        {
        }

        public void AddMoney(decimal money)
        {
            this.Balance += money;
        }

        public override decimal CalcInterest(decimal numberMounts)
        {
            decimal result = 0;
            if ((this.Customer.GetType().Name == "Individual") && (numberMounts > 3))
            {
                result += (numberMounts - 3) * this.InterestRate;
            }
            else if ((this.Customer.GetType().Name == "Company") && (numberMounts > 2))
            {
                result += (numberMounts - 2) * this.InterestRate;
            }
            return result;
        }
    }
}
