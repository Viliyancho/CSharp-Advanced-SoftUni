using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> all = new Stack<int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] number = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

                int first = number[0];
                switch(first)
                {
                    case 1:
                        all.Push(number[1]);
                        break;
                    case 2:
                        all.Pop();
                        break;
                    case 3:
                        if(all.Any())
                        {
                        Console.WriteLine(all.Max());
                        }
                        break;

                    case 4:
                        if(all.Any())
                        {
                        Console.WriteLine(all.Min());
                        }
                        break;
                }
            }

            if(all.Count != 0)
            {
                Console.WriteLine(string.Join(", ", all));
            }
        }
    }
}
