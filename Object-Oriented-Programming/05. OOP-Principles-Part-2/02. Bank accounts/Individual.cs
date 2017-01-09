namespace Bank_accounts
{
    using System;
    public class Individual : Customers
    {

        public Individual(string name, long idNum, Gender gender) : base(name, idNum)
        {
            this.Gender = gender;
        }

        public Gender Gender { get; private set; }

    }
}
