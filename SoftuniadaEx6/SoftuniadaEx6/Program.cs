using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftuniadaEx6
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();
            List<char> checkList = new List<char>();
            foreach (char i in start)
            {
                checkList.Add(i);
            }
            bool isSame = true;
            foreach (char letter in end)
            {
                if (checkList.Contains(letter))
                {
                    checkList.Remove(letter);
                }
                else
                {
                    isSame = false;
                }
            }
            if (checkList.Count > 0)
            {
                isSame = false;
            }
            if (isSame)
            {
                int inOrder = 0;
                int index = end.Length - 1;
                for (int i = start.Length - 1; i >= 0; i--)
                {
                    if (start[i] == end[index])
                    {
                        inOrder++;
                        index--;
                    }
                }
                Console.WriteLine("The minimum operations required to convert \"{0}\" to \"{1}\" are {2}", start, end, end.Length - inOrder);
            }
            else
            {
                Console.WriteLine("The name cannot be transformed!");
            }
        }
    }
}
