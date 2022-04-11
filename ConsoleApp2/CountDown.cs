using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CountDown 
    {
        public delegate void MethodContainer(int ms);
        public event MethodContainer onCount;
        public void Count(int ms)
        {
            for (int i = 100; i > 0; i--)
            {
                if (i == 10)
                {
                    onCount(ms);
                }
            }
        }
    }
}
