using System;

namespace _08.Events
{
    class Events
    {
        static void Main(string[] args)
        {
            Timer t = new Timer();
            t.Tick += OnTick;
            t.StartTimer(1000);

        }

        static void OnTick(DateTime currentTime)
        {
            Console.WriteLine(currentTime);
        }
    }

}
