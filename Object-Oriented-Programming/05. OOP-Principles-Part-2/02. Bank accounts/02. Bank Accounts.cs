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

            var testCompanyLoanAcc = new LoanAccount(new Company("Adsys LTD", 114579311, "Todor Alexiev"), -25000, 20);
            var testIndivLoanAcc = new LoanAccount(new Individual("Ivan Ivanov", 640588555, Gender.Male), -4500M, 20);

            var testCompanyMortgageAcc = new MortgageAccount(new Company("Adsys LTD", 114579311, "Todor Alexiev"), -25000, 20);
            var testIndivMortgageAcc = new MortgageAccount(new Individual("Ivan Ivanov", 640588555, Gender.Male), -4500M, 20);

            testDeposit.AddMoney(150M);         //Add Money to Deposit Account
            testDeposit.WithDraw(200M);         //With Draw Money
            Console.WriteLine(testDeposit);     //Print Deposit Account
            decimal mounts = 5M;                //Set Interest Rate
            Console.WriteLine("Interest Rate for {0} mounts is: {1}%", mounts, testDeposit.CalcInterest(mounts));
            Console.WriteLine(new string('-',75));

            testCompanyLoanAcc.AddMoney(350);
            testIndivLoanAcc.AddMoney(440);
            Console.WriteLine("Company Loan account");
            Console.WriteLine(testCompanyLoanAcc);
            Console.WriteLine("Interest Rate for {0} mounts is: {1}%", mounts, testCompanyLoanAcc.CalcInterest(mounts));
            Console.WriteLine("\nIndividual Loan account");
            Console.WriteLine(testIndivLoanAcc);
            Console.WriteLine("Interest Rate for {0} mounts is: {1}%", mounts, testIndivLoanAcc.CalcInterest(mounts));
            Console.WriteLine(new string('-', 75));

            mounts = 13M;
            testCompanyMortgageAcc.AddMoney(555);
            testIndivMortgageAcc.AddMoney(333);
            Console.WriteLine("Company Mortgage account");
            Console.WriteLine(testCompanyMortgageAcc);
            Console.WriteLine("Interest Rate for {0} mounts is: {1}%", mounts, testCompanyMortgageAcc.CalcInterest(mounts));
            Console.WriteLine("\nIndividual Mortgage account");
            Console.WriteLine(testIndivMortgageAcc);
            Console.WriteLine("Interest Rate for {0} mounts is: {1}%", mounts, testIndivMortgageAcc.CalcInterest(mounts));
            Console.WriteLine(new string('-', 75));
        }
    }
}
