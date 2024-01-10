using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
   
        //You have created Order class in the previous exercise and that has order id , item name, order date and quantity . Create another class called Item that has item name and  price. Write a LINQ query such that it returns order id, item name, order date and the total price (price * quantity ) grouped by the month in the descending order of the order date.
        class Order2
        {
            public Order2(int id, string name, DateTime date, int quantity)
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
        class Item
        {
            public Item(string name, double price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; set; }
            public double Price { get; set; }
        }
    class Tot
    {
        public double Total_Price { get; set; }
        public string Item_Name { get; set; }
        public int Order_ID { get; set; }
        public DateTime Order_Date { get; set; }
    }
    internal class Question5
    {
        static void Main(string[] args)
        {//. You have created Order class in the previous exercise and that has order id , item name, order date and quantity . Create another class called Item that has item name and  price. Write a LINQ query such that it returns order id, item name, order date and the total price (price * quantity ) grouped by the month in the descending order of the order date.
            List<Order2> list = new List<Order2>()
        {
            new Order2(100,"Pen",new DateTime(2023,09,05),2),
            new Order2(101,"Book",new DateTime(2023,12,01),5),
            new Order2(102,"Pencil",new DateTime(2023,12,12),6),
            new Order2(103,"phone",new DateTime(2023,08,10),1),
            new Order2(104,"mouse",new DateTime(2023,12,02),3),
            new Order2(105,"Paper",new DateTime(2023,11,02),10),
        };
            List<Item> list2 = new List<Item>()
            {
                new Item("Pen",5),
                new Item("Book",40),
                new Item("Pencil",10),
                new Item("phone",46577),
                new Item("mouse",576),
                new Item("Paper",2)

            };
            var result = from d in list
                         join i in list2
                         on d.Name equals i.Name
                         select new Tot() { Order_ID = d.Id, Item_Name = d.Name, Order_Date = d.Date, Total_Price = d.Quantity * i.Price };
                        var res=from r in result
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
