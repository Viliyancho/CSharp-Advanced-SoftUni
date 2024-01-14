using System;
using System.Collections.Generic;

namespace _05._CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> chars = new SortedDictionary<char, int>();

            string input = Console.ReadLine();
            foreach (var item in input)
            {
                if(!chars.ContainsKey(item))
                {
                    chars.Add(item, default);
                }
                chars[item]++;
            }

            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
