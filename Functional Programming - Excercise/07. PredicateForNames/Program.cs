using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Predicate<string> validator = name =>
            {
                return name.Length <= n;
            };

            List<string> newNames = new List<string>();

            foreach (var item in names)
            {
                if(validator(item))
                {
                    newNames.Add(item);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, newNames));
        }
    }
}
