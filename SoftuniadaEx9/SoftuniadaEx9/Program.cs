using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoftuniadaEx9
{
    class Program
    {
       public static List<string> allCombs = new List<string>();
        static void Main(string[] args)
        {
            int zeroes = int.Parse(Console.ReadLine());
            int ones = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string str = "";

            //List<string> allCombinations = GetNthEnumeration(new[] { "0", "1"}, n).ToList();

            //List<string> result = new List<string>();

            //foreach (string bits in allCombinations)
            //{
            //    int zeroesInComb = 0;
            //    int onesInComb = 0;
            //    for (int i = 0; i < bits.Length; i++)
            //    {
            //        if(bits[i] == '0')
            //        {
            //            zeroesInComb++;
            //        }
            //        else if(bits[i] == '1')
            //        {
            //            onesInComb++;
            //        }
            //    }
            //    if(zeroesInComb == zeroes && onesInComb == ones)
            //    {
            //        result.Add(bits);
            //    }
            //}

            //Console.WriteLine(string.Join(' ', result));

            generate(ones, zeroes, str, zeroes + ones);

            List<string> filteredCombos = new List<string>();

            foreach (string bits in allCombs)
            {
                int zeroesInComb = 0;
                int onesInComb = 0;
                for (int i = 0; i < bits.Length; i++)
                {
                    if (bits[i] == '0')
                    {
                        zeroesInComb++;
                    }
                    else if (bits[i] == '1')
                    {
                        onesInComb++;
                    }
                }
                if (zeroesInComb == zeroes && onesInComb == ones)
                {
                    filteredCombos.Add(bits);
                }
            }
        }
        static void generate(int ones, int zeroes, string str, int len)
        {
            if (len == str.Length)
            {
                allCombs.Add(str);
                return;
            }

            generate(ones + 1, zeroes, str + "1", len);
            generate(ones, zeroes + 1, str + "0", len);

            if (ones > zeroes)
            {
                generate(ones, zeroes + 1, str + "0", len);
            }
            else if(zeroes > ones)
            {
                generate(ones + 1, zeroes, str + "1", len);
            }
        }
    }
}
