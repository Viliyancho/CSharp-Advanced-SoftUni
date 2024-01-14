using System;
using System.Linq;

namespace _4._MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            string[,] matrix = new string[n[0], n[1]];
            for (int row = 0; row < n[0]; row++)
            {
                string[] numbers = Console.ReadLine()
                 .Split();
                for (int col = 0; col < n[1]; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            string command = string.Empty;
            while((command = Console.ReadLine()) != "END")
            {
                string[] commandArgs = command.Split();
                string first = commandArgs[0];
                if(first == "swap")
                {
                    if(commandArgs.Length == 5)
                    {
                        int firstRow = int.Parse(commandArgs[1]);
                        int firstCol = int.Parse(commandArgs[2]);
                        int secondRow = int.Parse(commandArgs[3]);
                        int secondCol = int.Parse(commandArgs[4]);

                        if(firstRow >= 0 && firstRow < matrix.GetLength(0) &&
                            firstCol >= 0 && firstCol < matrix.GetLength(0) &&
                            secondRow >= 0 && secondRow < matrix.GetLength(0) &&
                            secondCol >= 0 && secondCol < matrix.GetLength(0))
                        {
                            string change = string.Empty;
                            change = matrix[firstRow, firstCol];

                            matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                            matrix[secondRow, secondCol] = change;

                            for (int i = 0; i < n[0]; i++)
                            {
                                for (int j = 0; j < n[1]; j++)
                                {
                                    Console.Write($"{matrix[i, j]} ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                            continue;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }
        }
    }
}
