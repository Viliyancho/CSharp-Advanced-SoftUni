using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToHashSet();

            Func<HashSet<int>, int> minNumber = numbers => numbers.Min();

            Console.WriteLine(minNumber(numbers));
        }
    }
}
