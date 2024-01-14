using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
           .Split(' ', StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToList();

            int n = int.Parse(Console.ReadLine());

            Func<List<int>, int, List<int>> removeDivisibles = (numbers, n) =>
            {
                numbers.RemoveAll(number => number % n == 0);
                return numbers;
            };

            Func<List<int>, List<int>> reverse = numbers =>
            {
                List<int> sequence = new List<int>();

                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    sequence.Add(numbers[i]);
                }
                return sequence;
            };

            numbers = removeDivisibles(numbers, n);
            if(numbers.Any())
            {
            numbers = reverse(numbers);
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
