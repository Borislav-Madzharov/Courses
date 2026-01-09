using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short century = short.Parse(Console.ReadLine());
            int years = century * 100;
            double days = Math.Truncate(years * 365.2422);
            double hours = days * 24;
            decimal minutes = (decimal)hours * 60;

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
