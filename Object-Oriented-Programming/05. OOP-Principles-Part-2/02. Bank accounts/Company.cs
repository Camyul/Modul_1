namespace Bank_accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Company : Customers
    {
        public Company(string name, long idNum, string mangerName) : base(name, idNum)
        {
            this.CompanyManager = mangerName;
        }

        public string CompanyManager { get; private set; }

    }
}
