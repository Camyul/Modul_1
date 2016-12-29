namespace _07.Timer
{
    using System;


    public class Timer_Task7
    {
        static void Main()
        {
            Timer start = new Timer(3);
            start.DlgAddMethod += FirstMethod;
            start.DlgAddMethod += SecondMethod;
            start.Execute();
        }
        private static void FirstMethod()
        {
            Console.WriteLine("I am a first Method");
        }
        private static void SecondMethod()
        {
            Console.WriteLine("I am a second Method");
        }
    }
}
