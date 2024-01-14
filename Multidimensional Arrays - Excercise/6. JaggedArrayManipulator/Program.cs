using System;
using System.Linq;

namespace _6._JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                jaggedArray[row] = numbers;
            }

            for (int row = 0; row < n - 1; row++)
            {
                if(jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int i = 0; i < jaggedArray[row].Length; i++)
                    {
                        jaggedArray[row][i] *= 2;
                        jaggedArray[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jaggedArray[row].Length; i++)
                    {
                        jaggedArray[row][i] /= 2;
                    }

                    for (int i = 0; i < jaggedArray[row + 1].Length; i++)
                    {
                        jaggedArray[row + 1][i] /= 2;
                    }
                }
            }

            string input = string.Empty;
            while((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];
                int row = int.Parse(commandArgs[1]);
                int col = int.Parse(commandArgs[2]);
                int value = int.Parse(commandArgs[3]);

                switch(command)
                {
                    case "Add":
                        if(row >= 0 && row < jaggedArray.Length && col>= 0 && col < jaggedArray[row].Length)
                        {
                            jaggedArray[row][col] += value;
                        }
                        break;

                    case "Subtract":
                        if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                        {
                            jaggedArray[row][col] -= value;
                        }
                        break;
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }
        }
    }
}
