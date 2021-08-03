using System;
using System.Linq;

namespace SoftuniadaEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int total = 0;
            while ((input = Console.ReadLine()) != "stop")
            {
                string name = input;
                int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                int bonus = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    int subtotal = 1;
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (i != j)
                        {
                            subtotal *= nums[j];
                        }
                    }
                    bonus += subtotal;
                }
                total += bonus;
                Console.WriteLine("{0} has a bonus of {1} lv.", name, bonus);
            }
            Console.WriteLine("The amount of all bonuses is {0} lv.", total);
        }
    }
}