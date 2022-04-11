using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDown Counter = new CountDown();
            Handler_1 handler1 = new Handler_1();
            Handler_2 handler2 = new Handler_2();

            Counter.onCount += handler1.Message;
            Counter.onCount += handler2.Message;

            Counter.Count(5);
        }
    }
}
