using System.Threading;

namespace _07.Delegate
{
    class Timer
    {
        private readonly MyDelegate theAction;

        public Timer(MyDelegate theAction)
        {
            this.theAction = theAction;
        }

        public void Tick(int milliseconds)
        {
            while (true)
            {
                theAction();
                Thread.Sleep(milliseconds);
            }
        }
    }
}