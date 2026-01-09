using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Beer 2,40 350
Beer 1,20 200
buy

 
 
 */
namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> priceOfItem = new Dictionary<string, decimal>();
            List<Item> items = new List<Item>();


            string command = "";
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] arguments = command.Split();

                string item = arguments[0];
                decimal pricePer = decimal.Parse(arguments[1]);
                int count = int.Parse(arguments[2]);
                decimal total = pricePer * count;

                Item thing = new Item(item, count, pricePer, total);
                items.Add(thing);



                if (!priceOfItem.ContainsKey(item))
                {
                    priceOfItem.Add(item, 0);
                }
                if (priceOfItem.ContainsKey(item))
                {

                }

                priceOfItem[item] += total;


            }

            foreach (var item in priceOfItem)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }


        }





    }
    public class Item
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal PricePer { get; set; }
        public decimal Total { get; set; }

        public Item(string name, int count, decimal pricePer, decimal total)
        {
            Name = name;
            Count = count;
            PricePer = pricePer;
            Total = total;
        }

    }
}

