namespace Academy.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public abstract class Human
    {
        private string userName;
        public Human()
        {

        }

        public Human(string userName) : base()
        {
            this.Username = userName;
        }

        public string Username
        {
            get { return this.userName; }
            set
            {
                if (value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException("User's username should be between 3 and 16 symbols long!");
                }
                this.userName = value;
            }
        }

        public abstract override string ToString();
    }
}
