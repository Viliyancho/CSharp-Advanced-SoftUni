using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < input[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                first.Add(number);
            }

            for (int i = 0; i < input[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                second.Add(number);
            }

            Console.WriteLine(string.Join(" ", first.Intersect(second)));
        }
    }
}
