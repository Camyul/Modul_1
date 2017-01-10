namespace Range_Exceptions
{
    using System;
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
