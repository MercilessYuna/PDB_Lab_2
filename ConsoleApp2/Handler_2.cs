using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Handler_2
    {
        public void Message(int ms)
        {
            Thread.Sleep(ms);
            Console.WriteLine("До запуска 10 секунд");
        }
    }
}
