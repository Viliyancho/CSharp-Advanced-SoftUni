using System.Data;
using System.Net.WebSockets;
using System.Numerics;
using System.Text.RegularExpressions;

namespace RallyRacing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());


            int km = 0;

            char[,] rally = new char[n, n];

            int carRow = 0;
            int carCol = 0;

            int tunnelRow1 = -1;
            int tunnelCol1 = -1;

            int tunnelRow2 = -1;
            int tunnelCol2 = -1;

            int finishRow = -1;
            int finishCol = -1;

            for (int row = 0; row < n; row++)
            {
                char[] something = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    rally[row, col] = something[col];
                    if (something[col] == 'T')
                    {
                        if (tunnelRow1 == -1 && tunnelCol1 == -1)
                        {
                            tunnelRow1 = row;
                            tunnelCol1 = col;
                        }
                        else
                        {
                            tunnelRow2 = row;
                            tunnelCol2 = col;
                        }
                    }

                    if (something[col] == 'F')
                    {
                        finishRow = row;
                        finishCol = col;
                    }
                }
            }

            string input = string.Empty;
            bool isTrue = true;
            while((input = Console.ReadLine()) != "End")
            {
                switch (input)
                {
                    case "up":
                        carRow--;
                        break;
                    case "down":
                        carRow++;
                        break;
                    case "right":
                        carCol++;
                        break;
                    case "left":
                        carCol--;
                        break;
                }

                km += 10;

                if(carRow == tunnelRow1 && carCol == tunnelCol1 && isTrue)
                {
                    carRow = tunnelRow2;
                    carCol = tunnelCol2;
                    rally[tunnelRow1, tunnelCol1] = '.';
                    rally[tunnelRow2, tunnelCol2] = '.';

                    km += 20;
                    isTrue = false;
                }

                if (carRow == tunnelRow2 && carCol == tunnelCol2 && isTrue)
                {
                    carRow = tunnelRow1;
                    carCol = tunnelCol1;
                    rally[tunnelRow1, tunnelCol1] = '.';
                    rally[tunnelRow2, tunnelCol2] = '.';
                    km += 20;
                    isTrue = false;
                }

                if(carRow == finishRow && carCol == finishCol)
                {
                    rally[finishRow, finishCol] = 'C';
                    Console.WriteLine($"Racing car {number:d2} finished the stage!");
                    Console.WriteLine($"Distance covered {km} km.");

                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            Console.Write(rally[row, col]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }
            }

            rally[carRow, carCol] = 'C';
            Console.WriteLine($"Racing car {number:d2} DNF.");
            Console.WriteLine($"Distance covered {km} km.");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(rally[row, col]);
                }
                Console.WriteLine();
            }
        }   
    }
}