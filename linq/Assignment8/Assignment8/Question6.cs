using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Question6
    {
        class Order3
        {
            public Order3(int id, string name, DateTime date, int quantity)
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
        class Item1
        {
            public Item1(string name, double price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; set; }
            public double Price { get; set; }
        }
        internal class Question5
        {
            static void Main(string[] args) {
                //. Do the previous exercise using anonymous types.
                List<Order3> list = new List<Order3>()
        {
            new Order3(100,"Pen",new DateTime(2023,09,05),2),
            new Order3(101,"Book",new DateTime(2023,12,01),5),
            new Order3(102,"Pencil",new DateTime(2023,12,12),6),
            new Order3(103,"phone",new DateTime(2023,08,10),1),
            new Order3(104,"mouse",new DateTime(2023,12,02),3),
            new Order3(105,"Paper",new DateTime(2023,11,02),10),
        };
                List<Item1> list2 = new List<Item1>()
            {
                new Item1("Pen",5),
                new Item1("Book",40),
                new Item1("Pencil",10),
                new Item1("phone",46577),
                new Item1("mouse",576),
                new Item1("Paper",2)

            };
               
                var result = from d in list
                             join i in list2
                             on d.Name equals i.Name
                             select new  { Order_ID = d.Id, Item_Name = d.Name, Order_Date = d.Date, Total_Price = d.Quantity * i.Price };
                var res = from r in result
                          orderby r.Order_Date descending
                          group r by r.Order_Date.Month;
                foreach (var item in res)
                {
                    Console.WriteLine("Order based on month:" + item.Key);
                    foreach (var item2 in item)
                    {
                        Console.WriteLine($"ID:{item2.Order_ID} Name:{item2.Item_Name} Date:{item2.Order_Date.ToShortDateString()} Total Price:{item2.Total_Price}");
                    }
                }
            }
        }
    }
}
