using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsOnlinq
{
    internal class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student1(int id,string name)
        {
            Id = id;
            this.Name = name;
        }
    }
}
