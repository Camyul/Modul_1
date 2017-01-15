

namespace _07.Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    public class Timer
    {
        public delegate void TimerDelegate(); //Декларирам делегата

        private int timeInterval;

        public Timer(int interval)
        {
            this.TimeInterval = interval;
        }

        public int TimeInterval
        {
            get {return this.timeInterval; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Interval must be > 0");
                }
                this.timeInterval = value;
            }
        }
        public TimerDelegate DlgAddMethod { get; set; } //Метод за добавяне на методи към делегата

        public void Execute()
        {
            
            while (true)
            {
                this.DlgAddMethod();
                Thread.Sleep(this.timeInterval * 1000);
            }
        }

    }
}
