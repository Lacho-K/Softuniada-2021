using System;
using System.Linq;

namespace SoftuniadaEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[Sizes[0], Sizes[1]];
            for (int i = 0; i < Sizes[0]; i++)
            {
                char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            char switchChar = char.Parse(Console.ReadLine());
            int[] startCoordinate = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char startSymbol = matrix[startCoordinate[0], startCoordinate[1]];
            matrix[startCoordinate[0], startCoordinate[1]] = switchChar;
            ChangeChars(matrix, startSymbol, switchChar, startCoordinate);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void ChangeChars(char[,] matrix, char startChar, char swapChar, int[] startCoordinate)
        {
            if (startCoordinate[0] > 0)
            {
                if (matrix[startCoordinate[0] - 1, startCoordinate[1]] == startChar)
                {
                    matrix[startCoordinate[0] - 1, startCoordinate[1]] = swapChar;
                    int[] newStart = new int[2];
                    newStart[0] = startCoordinate[0] - 1;
                    newStart[1] = startCoordinate[1];
                    ChangeChars(matrix, startChar, swapChar, newStart);
                }
            }
            if (startCoordinate[0] < matrix.GetLength(0) - 1)
            {
                if (matrix[startCoordinate[0] + 1, startCoordinate[1]] == startChar)
                {
                    matrix[startCoordinate[0] + 1, startCoordinate[1]] = swapChar;
                    int[] newStart = new int[2];
                    newStart[0] = startCoordinate[0] + 1;
                    newStart[1] = startCoordinate[1];
                    ChangeChars(matrix, startChar, swapChar, newStart);
                }
            }
            if (startCoordinate[1] > 0)
            {
                if (matrix[startCoordinate[0], startCoordinate[1] - 1] == startChar)
                {
                    matrix[startCoordinate[0], startCoordinate[1] - 1] = swapChar;
                    int[] newStart = new int[2];
                    newStart[0] = startCoordinate[0];
                    newStart[1] = startCoordinate[1] - 1;
                    ChangeChars(matrix, startChar, swapChar, newStart);
                }
            }
            if (startCoordinate[1] < matrix.GetLength(1) - 1)
            {
                if (matrix[startCoordinate[0], startCoordinate[1] + 1] == startChar)
                {
                    matrix[startCoordinate[0], startCoordinate[1] + 1] = swapChar;
                    int[] newStart = new int[2];
                    newStart[0] = startCoordinate[0];
                    newStart[1] = startCoordinate[1] + 1;
                    ChangeChars(matrix, startChar, swapChar, newStart);
                }
            }
        }
    }
}
