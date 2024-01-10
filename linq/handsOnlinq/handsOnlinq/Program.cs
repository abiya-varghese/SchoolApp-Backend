using System.Diagnostics.CodeAnalysis;

namespace handsOnlinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Flower> list = new List<Flower>();
            list.Add(new Flower("lotus", 5));
            list.Add(new Flower("dahlia", 15));
            list.Add(new Flower("lily", 6));
            list.Add(new Flower("daffodils", 5));
            var result=from f in list
                       where f.Name.StartsWith("d")
                       select f;
            foreach (var f in result)
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petals}");
            }
            Console.WriteLine();
            result=from f in list
                   where f.Petals==5
                   select f;
            foreach (var f in result)
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petals}");
            }
            Console.WriteLine();
            result = from f in list
                     where f.Petals == 5 && f.Name.StartsWith("d")
                     select f;
            foreach (var f in result)
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petals}");
            }
            Console.WriteLine();
            result= from f in list
                    where f.Name=="lily"
                    select f;
            foreach (var f in result)
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petals}");
            }
            Console.WriteLine();
            result=from f in list
                   orderby f.Name
                   select f;
            foreach (var f in result)
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petals}");
            }
            Console.WriteLine();
            result=from f in list
                   orderby f.Petals descending
                   select f;
            foreach (var f in result)
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petals}");
            }
            //filter flower by group
           var result1 = from   f in list
                     orderby f.Petals
                     group f by f.Petals;
            foreach (var f in result1)
            {
                Console.WriteLine("flowers with " + f.Key + "petals:");
                foreach(var f2 in f)
                { Console.WriteLine(" " + f2.Name); }
            }
                  

        }
    }
}