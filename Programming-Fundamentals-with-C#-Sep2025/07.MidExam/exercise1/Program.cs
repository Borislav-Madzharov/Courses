using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
50
2
1,0
0,10
10,0

100
25
4,0
1,0
6,0

946
20
12,05
0,42
27,89

 
 */


namespace exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal flourPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());

            int freeFlour = 0;
            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    freeFlour++;
                }
            }

            decimal flourNeeded = flourPrice * (students - freeFlour);
            decimal eggsNeeded = eggPrice * (students * 10);
            decimal apronNeeded = apronPrice * Math.Ceiling(students * (6m / 5m));

            decimal total = flourNeeded + eggsNeeded + apronNeeded;

            if (total <= budget)
            {
                Console.WriteLine($"Items purchased for {total:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(total - budget):f2}$ more needed.");
            }











        }
    }
}
