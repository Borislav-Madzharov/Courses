using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double freeBelts = 0.16 * lightsaberPrice * students;

            double totalPrice = ((Math.Ceiling(1.10 * students) * lightsaberPrice) + (students * robesPrice) +  (students * beltsPrice + freeBelts));

            Console.WriteLine();
        }
    }
}
