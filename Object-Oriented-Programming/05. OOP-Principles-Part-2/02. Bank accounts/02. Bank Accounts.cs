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
            Customers companyTest = new Company("Adsys LTD", 114597311, "Todor Alexiev");

            var testDeposit = new DepositAccount(new Individual("Ivan Ivanov", 640588555, Gender.Male), 1500M, 5);
            
            
            testDeposit.AddMoney(150M);         //Add Money to Deposit Account
            testDeposit.WithDraw(2000M);         //With Draw Money
            Console.WriteLine(testDeposit);     //Print Deposit Account
            decimal mounts = 5M;                //Set Interest Rate
            Console.WriteLine("Interest Rate for {0} mounts is: {1}%", mounts, testDeposit.CalcInterest(mounts));
            Console.WriteLine(new string('-',80));
        }
    }
}
