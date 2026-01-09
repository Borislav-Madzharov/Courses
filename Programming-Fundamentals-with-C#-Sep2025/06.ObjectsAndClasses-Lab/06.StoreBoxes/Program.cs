using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
19861519 Dove 15 2,50
86757035 Butter 7 3,20
39393891 Orbit 16 1,60
37741865 Samsung 10 1000
end

 
 
 */


namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            List<Box> Boxes = new List<Box>();

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commands = command.Split(' ');

                string serialNum = commands[0];
                string itemName = commands[1];
                int itemQuantity = int.Parse(commands[2]);
                decimal itemPrice = decimal.Parse(commands[3]);

                Box box = new Box();

                box.Name = itemName;
                box.SerialNumber = serialNum;
                box.PricePerBox = itemPrice;
                box.ItemQuantity = itemQuantity;
                box.Total = box.PricePerBox * box.ItemQuantity;

                Boxes.Add(box);




            }

            List<Box> sortedBoxes = new List<Box>();

            Boxes.Sort((x, y) => y.Total.CompareTo(x.Total));


            foreach (Box box in Boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Name} - ${box.PricePerBox:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Total:f2}");
            }






        }
    }


    public class Item
    {
        public decimal Price { get; set; }
    }
    public class Box
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PricePerBox { get; set; }
        public decimal Total { get; set; }
    }
}
