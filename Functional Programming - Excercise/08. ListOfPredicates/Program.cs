using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int n = int.Parse(Console.ReadLine());

            HashSet<int> dividers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            List<Predicate<int>> validator = new List<Predicate<int>>();
            foreach (var item in dividers)
            {
                validator.Add(n => n % item != 0);
            }

            for (int i = 1; i <= n; i++)
            {
                bool isValid = true;

                foreach (var item in validator)
                {
                    if(item(i))
                    {
                        isValid = false;
                    }
                }

                if(isValid)
                {
                    numbers.Add(i);
                }
            }

            if(numbers.Any())
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
    }
}
