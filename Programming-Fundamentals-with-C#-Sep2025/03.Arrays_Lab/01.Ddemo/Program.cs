using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
class Program
{
    static void Main()
    {
        // Input array (you can change it for testing)
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // Loop until only one number remains
        if (nums.Length == 1)
        {
            Console.WriteLine($"{nums[0]} is already condensed to number");
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        while (nums.Length > 1)
        {
            // New array is one element shorter
            int[] condensed = new int[nums.Length - 1];

            // Fill condensed by summing adjacent pairs
            for (int i = 0; i < condensed.Length; i++)
            {
                condensed[i] = nums[i] + nums[i + 1];
            }

            // Replace nums with condensed
            nums = condensed;
        }

        // Output the result
        Console.WriteLine(nums[0]);
    }
}
