using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Order1
    {
        public Order1(int id, string name, DateTime date, int quantity)
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
    internal class Question4 
    {
        // For the previous exercise, write a LINQ query that displays the details grouped by the month in the descending order of the order date.
        static void Main(string[] args)
        {
            List<Order1> list = new List<Order1>()
        {
            new Order1(100,"Pen",new DateTime(2023,09,05),2),
            new Order1(101,"Book",new DateTime(2023,12,01),5),
            new Order1(102,"Pencil",new DateTime(2023,12,12),6),
            new Order1(103,"phone",new DateTime(2023,08,10),1),
            new Order1(104,"mouse",new DateTime(2023,12,02),3),
            new Order1(105,"Paper",new DateTime(2023,11,02),10),
        };
            var result1 = from d in list
                          orderby d.Date descending
                          group d by d.Date.Month;

            foreach (var item in result1)
            {
                Console.WriteLine("Order based on month:"+item.Key);
                foreach (var item2 in item)
                {
                    Console.WriteLine($"ID:{item2.Id} Name:{item2.Name} Date:{item2.Date.ToShortDateString()} Quantity:{item2.Quantity}");
                }
            }

            Console.WriteLine();
        }   
    }
}
