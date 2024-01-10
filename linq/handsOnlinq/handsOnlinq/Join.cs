using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsOnlinq
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    class Enroll
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public Enroll(int id, string name)
        {
            this.Id = id;
            this.CourseName = name;
        }
    }
    class StudentEnroll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }
        public StudentEnroll(int id, string name,
                           string cname)
        {
            this.Id = id;
            this.Name = name;
            this.CourseName = cname;
        }
    }
    internal class Join
    { 
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student(1,"abiya"),
                new Student(2,"mubeena"),
                new Student(3,"deepa"),
                new Student(4,"abin")
            };
            Enroll[] enrolls =
            {
                new Enroll(1,".net"),
                new Enroll(2,".net"),
                new Enroll(3,"sap"),
                new Enroll(4,"java"),
                new Enroll(1,"java")
            };
            var res=from s in students
                    join e in enrolls
                    on s.Id equals e.Id
                    select new StudentEnroll(s.Id,s.Name,e.CourseName);
            foreach(var item in res)
            {
                Console.WriteLine($"Id:{item.Id} Name:{item.Name} Course:{item.CourseName}");
            }
            Console.WriteLine();
            var result=from s in students
                       join e in enrolls
                       on s.Id equals e.Id
                       select new {id=s.Id,name=s.Name,course=e.CourseName};
            foreach (var item in res)
            {
                Console.WriteLine($"Id:{item.Id} Name:{item.Name} Course:{item.CourseName}");
            }
        }
    }
}
