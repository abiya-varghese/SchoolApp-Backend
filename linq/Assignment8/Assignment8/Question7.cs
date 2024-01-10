using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Order4
    {
        public Order4(int id, string name, DateTime date, int quantity)
        {
            Id = id;
            Name = name;
            Date = date;
            Quantity = quantity;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }

    }
    internal class Question7
    {
        //Check if all the quantities in the Order collection is >0.
        static void Main(string[] args)
        {
            List<Order4> list = new List<Order4>()
        {
            new Order4(100,"Pen",new DateTime(2023,09,05),2),
            new Order4(101,"Book",new DateTime(2023,12,01),5),
            new Order4(102,"Pencil",new DateTime(2023,12,12),6),
            new Order4(103,"phone",new DateTime(2023,08,10),1),
            new Order4(104,"mouse",new DateTime(2023,12,02),3),
            new Order4(105,"Paper",new DateTime(2023,11,02),10)
        };
            foreach (Order4 item in list)
            {
                if(item.Quantity > 0)
                {
                    var result=from i in list
                               orderby i.Quantity descending
                               select item;
                }
            }
        }
    }
}
