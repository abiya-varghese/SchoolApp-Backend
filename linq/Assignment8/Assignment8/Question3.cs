using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{class Order
    {
        public Order(int id, string name, DateTime date, int quantity)
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
    internal class Question3
    {//. Create an Order class that has order id, item name, order date and quantity. Create a collection of Order objects. Display the data day wise from most recently ordered to least recently ordered and by quantity from highest to lowest.
        static void Main(string[] args)
        {
            List<Order> list = new List<Order>()
        {
            new Order(100,"Pen",new DateTime(2023,12,05),2),
            new Order(101,"Book",new DateTime(2023,12,01),5),
            new Order(102,"Pencil",new DateTime(2023,12,12),6),
            new Order(103,"phone",new DateTime(2023,12,10),1),
            new Order(104,"mouse",new DateTime(2023,12,02),3),
            new Order(105,"Paper",new DateTime(2023,11,02),10),
        };
            var result1 = from d in list
                          orderby d.Date descending
                          select d;
            Console.WriteLine("Order based on day");
            foreach (var item in result1)
                Console.WriteLine($"ID:{item.Id} Name:{item.Name} Date:{item.Date.ToShortDateString()} Quantity:{item.Quantity}");
            Console.WriteLine();
            Console.WriteLine("Highest to lowest quantity");
            Console.WriteLine();
            var result = from d in list
                          orderby d.Quantity descending
                          select d;
            foreach (var item in result)
                Console.WriteLine($"ID:{item.Id} Name:{item.Name} Date:{item.Date.ToShortDateString()} Quantity:{item.Quantity}");

        }
    }
}
    

