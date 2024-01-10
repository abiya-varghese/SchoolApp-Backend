using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsOnlinq
{
    internal class Time
    {
        static void Main(string[] args)
        {
            DateTime dt;
            dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine(DateTime.Now.ToLongTimeString());// return time only
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongDateString());
            dt= DateTime.Parse("2/23/2000");
            Console.WriteLine(dt);
        }
    }
}
