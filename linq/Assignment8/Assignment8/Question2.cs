using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{ class Player {
        public Player(string name, string country)
        {
            Name = name;
            Country = country;
        }

        public string Name { get; set; }
        public string Country { get; set; }
    }

    internal class Question2
    {
        static void Main(string[] args)
        {
            //Given a list of participants for a tennis match. Split the list into 2 equal halves and display all the possible combination of matches possible between the participants in the two lists. A condition is that no player should have an opponent who is from his own his own country.
            List<Player> list1 = new List<Player>()
            {
                new Player("player1:","India"),
            new Player("player2", "usa"),
                new Player("player4","UK")

            };
            List<Player> list2 = new List<Player>()
            {
                new Player("player3","India"),
                new Player("player4","UK"),
                new Player("player5","africa")
            };
            var result = from l1 in list1
                         from l2 in list2
                         where l1.Country != l2.Country
                         select new { op = l1.Name, op2 = l2.Name };
            foreach (var list in result)
            {
                Console.WriteLine($"{list.op} * {list.op2}");
            }
        
        }
    }
}
