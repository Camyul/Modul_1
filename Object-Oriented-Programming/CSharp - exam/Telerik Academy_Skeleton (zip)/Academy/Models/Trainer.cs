namespace Academy.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Trainer : Human, ITrainer
    {
        private IList<string> technologies;

        public Trainer(string userName, IList<string> technologi) : base(userName)
        {
            this.Technologies = technologi;
        }

        public IList<string> Technologies
        {
            get
            {
                return this.technologies;
            }

            set
            {
                this.technologies = value;
            }
        }

      
       
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("* Trainer: \n");
            result.AppendFormat(" - Username: {0}\n", this.Username);
            result.AppendFormat(" - Technologies: {0}\n", String.Join("; ", this.Technologies));

            return result.ToString();
        }
    }
}
