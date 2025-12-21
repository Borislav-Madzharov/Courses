using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double coins;
            double wallet = 0;

            while (input != "Start")
            {
                coins = double.Parse(input);

                if (coins == 0.1)
                {
                    wallet += coins;
                }
                else if (coins == 0.2)
                {
                    wallet += coins;
                }
                else if (coins == 0.5)
                {
                    wallet += coins;
                }
                else if (coins == 1)
                {
                    wallet += coins;
                }
                else if (coins == 2)
                {
                    wallet += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                input = Console.ReadLine();
            }

            string products = Console.ReadLine();

            while (products != "End")
            {
                if (products == "Nuts")
                {
                    if (wallet - 2 >= 0) 
                    {
                        wallet -= 2;

                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (products == "Water")
                {
                    if (wallet - 0.7 >= 0)
                    {
                        wallet -= 0.7;

                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (products == "Crisps")
                {
                    if (wallet - 1.5 >= 0)
                    {
                        wallet -= 1.5;

                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (products == "Soda")
                {
                    if (wallet - 0.8 >= 0)
                    {
                        wallet -= 0.8;

                        Console.WriteLine($"Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (products == "Coke")
                {
                    if (wallet - 1.0 >= 0)
                    {
                        wallet -= 1.0;

                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                products = Console.ReadLine();

            }
            Console.WriteLine($"Change: {wallet:f2}");
        }
    }
}
