namespace Bank_accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class MortgageAccount : Accounts, Ideposit
    {
        public MortgageAccount(Customers client, decimal balance, decimal interestRate) : base(client, balance, interestRate)
        {
        }

        public void AddMoney(decimal money)
        {
            this.Balance += money;
        }

        public override decimal CalcInterest(decimal numberMounts)
        {
            decimal result = 0;
            if ((this.Customer.GetType().Name == "Individual") && (numberMounts > 6))
            {
                result += (numberMounts - 6) * this.InterestRate;
            }
            else if ((this.Customer.GetType().Name == "Company"))
            {
                if (numberMounts <= 12)
                {
                    result += numberMounts * (this.InterestRate / 2);
                }
                else
                {
                    result += 12 * (this.InterestRate / 2);
                    result += (numberMounts - 12) * this.InterestRate;
                }
                
            }
            return result;
        }
    }
}
