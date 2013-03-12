using System;
using System.Threading;

namespace _08.Events
{
    class Timer
    {
        public event HandleTick Tick;

        public void StartTimer(int notificationInterval)
        {
            while (true)
            {
                Tick(DateTime.Now);
                Thread.Sleep(notificationInterval);
            }
        }
    }
}