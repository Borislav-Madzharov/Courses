using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ZagZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] firstArray = new string[count];
            string[] secondArray = new string[count];
            string[] currentArray = new string[2];
            int counter = 0;
            bool oddEven = true;

            for (int i = 0; i < count; i++)
            {
                
                while (counter < 2)
                {
                    currentArray = Console.ReadLine().Split();
                    if (oddEven == true)
                    {
                        firstArray[i] = currentArray[0];
                        secondArray[i] = currentArray[1];
                        oddEven = false;
                        break;
                    }
                    else if (oddEven == false)
                    {
                        firstArray[i] = currentArray[1];
                        secondArray[i] = currentArray[0];
                        oddEven = true;
                        break;
                    }
                    counter++;
                    
                }


            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));

            /*
            for (int i = 0; i < count; i++)
            {
                for (int q = 0; q <= 2; q++)
                {
                    currentArray = Console.ReadLine().Split();

                    firstArray[q] = currentArray[q];
                }
            }
            */






        }
    }
}
