using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsOnlinq
{
    internal class QueryMethods
    {
        public static void Main(string[] args)
        {
            string[] flowers = { "dahlia", "rose", "lotus", "lily", "hibiscus", "daffodil" };
            IEnumerable<string> f = flowers.Where(flower => flower.StartsWith("d"));

            foreach (string g in f) {
                Console.WriteLine(g);
            }
            f = flowers.OrderBy(flower => flower);
            foreach (string g in f)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine();
            f= flowers.Where(flower=>flower.StartsWith("d")).OrderByDescending(f=>f);
            foreach (string g in f)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine();
            var res = flowers.GroupBy(e => e.Length);
            foreach(var item in res)
            {
                Console.WriteLine("flower with length:"+item.Key);
                foreach(var g in item)
                { Console.WriteLine(g); }
            }
        }
    }
}
