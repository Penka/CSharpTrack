using System;

namespace _07.Delegate
{
    class TimerDemo
    {
        public static void PrintSomethingStupid()
        {
            Console.WriteLine("This delegate is confusing me!");
        }

        static void Main(string[] args)
        {
            Timer t = new Timer(PrintSomethingStupid);
            t.Tick(1000);
        }
    }
}
