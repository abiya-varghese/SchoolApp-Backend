using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsOnlinq
{
     class Flower
    {
        public Flower(string n,int p) {
            Name = n;
            Petals = p;
        }
        public string Name {  get; set; }
        public int Petals { get; set; }
    }
}
