using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
/*
%Angela%willbevalid<pc>quantity|2|valid12,2$
end of shift
 */
namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z][a-z]+)%[^|$%.\d]*<(\w+)>[^|$%.\d]*\|(\d+)\|[^|$%.\d]*(\d+(?:[.,]\d+)?)\$";
            List<OrderInfo> orders = new List<OrderInfo>();
            decimal sum = 0;

            string command = null;
            while ((command = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(command, pattern);
                if (!match.Success)
                {
                    continue;
                }
                string name = match.Groups[1].Value;
                string item = match.Groups[2].Value;
                int quantity = int.Parse(match.Groups[3].Value);
                decimal price = decimal.Parse(match.Groups[4].Value);
                sum += price * quantity;
                OrderInfo order = new OrderInfo(name, item, quantity, price);
                orders.Add(order);
            }

            foreach (OrderInfo order in orders)
            {
                Console.WriteLine($"{order.Name}: {order.Item} - {order.GetTotal(order.Quantity, order.Price):f2}");
            }
            Console.WriteLine($"Total income: {sum:f2}");


        }
    }
    public class OrderInfo
    {
        public string Name { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public OrderInfo(string name, string item, int quantity, decimal price)
        {
            Name = name;
            Item = item;
            Quantity = quantity;
            Price = price;
        }


        public decimal GetTotal(int quantity, decimal price)
        {
            return quantity * price;
        }
    }
}
