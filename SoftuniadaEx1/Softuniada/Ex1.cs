using System;

namespace Softuniada
{
    class Ex1
    {
        static void Main(string[] args)
        {
            int lowerBound = int.Parse(Console.ReadLine());
            int upperBound = int.Parse(Console.ReadLine());
            int primeNumCount = 0;
            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (CheckPrime(i))
                {
                    primeNumCount++;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The total number of prime numbers between {lowerBound} to {upperBound} is {primeNumCount}");
        }

        public static bool CheckPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
