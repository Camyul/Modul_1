using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_ClassLibrary
{
    public class Call
    {
        //private DateTime date;
        //private DateTime time;
        //private string dialledNumbers;
        //private ulong duration;

        public string Date { get; set; }
        public string Time { get; set; }
        public string DialledNumbers { get; set; }
        public ulong Duration { get; set; }
        public Call(string Date, string Time, string DialledNumbers, ulong Duration)
        {
            this.Date = Date;
            this.Time = Time;
            this.DialledNumbers = DialledNumbers;
            this.Duration = Duration;
        }

    }
}
