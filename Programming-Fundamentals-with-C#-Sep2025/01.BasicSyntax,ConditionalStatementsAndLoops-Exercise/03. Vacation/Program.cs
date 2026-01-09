using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;
            double Discount = 1;

            if (day == "Friday")
            {
                if (type == "Students")
                {
                    price = 8.45;
                }
                else if (type == "Business")
                {
                    price = 10.90;
                }
                else if (type == "Regular")
                {
                    price = 15;
                }
            }
            else if (day == "Saturday")
            {
                if (type == "Students")
                {
                    price = 9.80;
                }
                else if (type == "Business")
                {
                    price = 15.60;
                }
                else if (type == "Regular")
                {
                    price = 20;
                }
            }
            else if (day == "Sunday")
            {
                if (type == "Students")
                {
                    price = 10.46;
                }
                else if (type == "Business")
                {
                    price = 16;
                }
                else if (type == "Regular")
                {
                    price = 22.50;
                }
            }

            if (people >= 30 && type == "Students")
            {
                Discount = 0.85;
            }
            else if (people >= 100 && type == "Business")
            {
                people = people - 10;
            }
            else if (people >= 10 && people <= 20)
            {
                Discount = 0.95;
            }

            totalPrice = price * people * Discount;

            Console.WriteLine($"Total price: {totalPrice:F2}");




        }
    }
}
