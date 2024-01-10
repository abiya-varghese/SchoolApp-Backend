using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsOnlinq
{
    internal class Demo2
    {
        public static void Main(string[] args)
        {
            List<Student1> stud = new List<Student1>()
            {
                new Student1(1,"hari"),
                new Student1(2,"ravi"),
                new Student1(3,"narender"),
                new Student1(4,"sandeep")
            };
            Student1 s=stud.First();
            Console.WriteLine(s.Name);
            s = stud.Where(s => s.Name.Length>4).First() ;
            Console.WriteLine(s.Name);
            Console.WriteLine();
            s=stud.Last();
            Console.WriteLine(s.Name);
            Console.WriteLine();
            s=stud.Where(s=>s.Name.Length>4).Last() ;
            Console.WriteLine(s.Name);
            Console.WriteLine();
            s = stud.Where(s => s.Name.Length > 14).FirstOrDefault();
            if (s == null)
                Console.WriteLine("no student");
            Console.WriteLine();
            s = stud.Where(s => s.Name.Length > 14).LastOrDefault();
            if (s == null)
                Console.WriteLine("no student");
            Console.WriteLine();
            s=stud.Single(s=>s.Id==3);
            Console.WriteLine(s.Name);
            Console.WriteLine();
            s=stud.SingleOrDefault(s=>s.Id==4);
            if (s != null) Console.WriteLine(s.Name);
            else
                Console.WriteLine("invalid id");
            s=stud.SingleOrDefault(s=>s.Id==5&&s.Name=="sdf");
            if (s != null) Console.WriteLine("present");
            else
                Console.WriteLine("invalid id or name");
            Console.WriteLine();
            List<Student1> list=stud.Where(s=>s.Name.Length>4).ToList();
            //foreach (var i in list)
            //    Console.WriteLine($"{list[1]}");
            Student1[] student1s = stud.Where(s => s.Name.Length > 4).ToArray();
            Student1 s1=stud.Where(s=>s.Name.Length>4).ElementAt(0);
            s1 = stud.Where(s => s.Name.Length > 4).ElementAt(1);
        }
    }
}
