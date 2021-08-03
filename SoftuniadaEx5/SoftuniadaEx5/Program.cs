using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftuniadaEx5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sweets = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int packages = int.Parse(Console.ReadLine());

            int sweetsSum = sweets.Sum();

            if (sweetsSum % packages != 0)
            {
                Console.WriteLine("Packaging is not possible!");
            }
            else
            {
                int targetSum = sweetsSum / packages;
            }
        }

        
    }
}
