using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> quantityOfMaterial = new Dictionary<string, int>();

            string command = "";

            while ((command = Console.ReadLine()) != "stop")
            {
                string material = command;
                int quantity = int.Parse(Console.ReadLine());

                if (! quantityOfMaterial.ContainsKey(material))
                {
                    quantityOfMaterial.Add(material, 0);
                }
                quantityOfMaterial[material] += quantity;

            }

            foreach (var mat in quantityOfMaterial)
            {
                Console.WriteLine($"{mat.Key} -> {mat.Value}");
            }





        }
    }
}
