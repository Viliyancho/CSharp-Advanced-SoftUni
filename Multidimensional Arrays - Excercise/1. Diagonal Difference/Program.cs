using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int first = 0;
            int second = 0;

            for (int i = 0; i < n; i++)
            {
                first += matrix[i, i];
            }

            for (int i = 0; i < n; i++)
            {
                second += matrix[i, n - 1 - i];
            }

            Console.WriteLine(Math.Abs(second - first));
        }
    }
}