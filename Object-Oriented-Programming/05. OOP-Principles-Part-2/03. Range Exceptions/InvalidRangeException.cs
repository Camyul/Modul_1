namespace Range_Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class InvalidRangeException<T> : ArgumentOutOfRangeException
    {
        public InvalidRangeException(string msg, T Start, T End) : base(msg)
        {
            this.Min = Start;
            this.Max = End;
        }

        public T Min { get; private set; }
        public T Max { get; private set; }
    }
}
