using System;
using System.Collections.Generic;

namespace _03._PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> compounds = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in input)
                {
                    compounds.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", compounds));
        }
    }
}
