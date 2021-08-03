using System;

namespace SoftuniadaEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int spaces = 0;
            while (rows > 0)
            {
                Console.Write(new string(' ',spaces));
                for (int i = 1; i <= rows; i++)
                {
                    Console.Write(i);
                }
                for (int i = rows-1; i > 0; i--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                rows--;
                spaces++;
            }
        }
    }
}
