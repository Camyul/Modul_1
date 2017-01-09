namespace Bank_accounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class BancAccounts
    {
        static void Main()
        {
            Customers individTest = new Individual("Ivan Ivanov", 640588555, Gender.Male);
            Customers companyTest = new Company("Adsys LTD", 114597311, "Todor Alexiev");

            Console.WriteLine(individTest);
            Console.WriteLine(companyTest);
        }
    }
}
