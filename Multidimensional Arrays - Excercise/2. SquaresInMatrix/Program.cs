using System;
using System.Linq;

namespace _2._SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int[,] matrix = new int[n[0], n[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int count = 0;

            for (int row = 0; row < n[0] - 1; row++)
            {
                for (int col = 0; col < n[1] - 1; col++)
                {
                    if(matrix[row,col] == matrix[row, col+1] &&
                       matrix[row,col] ==matrix[row+1,col] &&
                       matrix[row,col] == matrix[row+1,col+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
