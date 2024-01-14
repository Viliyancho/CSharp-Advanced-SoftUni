using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothesByColor =
                new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                if(!clothesByColor.ContainsKey(color))
                {
                    clothesByColor.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1; j < input.Length; j++)
                {
                    if(!clothesByColor[color].ContainsKey(input[j]))
                    {
                        clothesByColor[color].Add(input[j], default);
                    }
                    clothesByColor[color][input[j]]++;
                }
            }

            string[] found = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string colour = found[0];
            string cloth = found[1];

            foreach (var item in clothesByColor)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var item1 in item.Value)
                {
                    string it = $"* {item1.Key} - {item1.Value}";
                    if(item.Key == colour && item1.Key == cloth)
                    {
                        it += " (found!)";
                    }
                    Console.WriteLine(it);
                }
            }
        }
    }
}
