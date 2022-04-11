using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Handler_1
    {
        public void Message(int ms)
        {
            Thread.Sleep(ms);
            Console.WriteLine("Обратный отсчет 10");
        }
    }
}
