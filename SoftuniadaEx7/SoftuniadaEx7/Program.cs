using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftuniadaEx7
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int[] r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int v = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());


            List<int> allVs = new List<int>();
            allVs.Add(v);

            int bestV = -1;

            for (int i = 0; i < p; i++)
            {
                int lastCount = allVs.Count;

                for (int j = 0; j < lastCount; j++)
                {
                    if (allVs[0] + r[i] >= 0 && allVs[0] + r[i] <= m)
                    {
                        allVs.Add(allVs[0] + r[i]);
                    }

                    else if (allVs[0] - r[i] >= 0 && allVs[0] - r[i] <= m)
                    {
                        allVs.Add(allVs[0] - r[i]);
                    }

                    allVs.Remove(allVs[0]);
                }
            }

            if (allVs.Count > 0)
            {
                bestV = allVs.Max();
            }

            Console.WriteLine(bestV);
        }
    }
}

