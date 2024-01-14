using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] randoms = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int push = tokens[0];
            int pop = tokens[1];
            int peek = tokens[2];

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < push; i++)
            {
                numbers.Push(randoms[i]);
            }

            for (int i = 0; i < pop; i++)
            {
                if(numbers.Any())
                {
                numbers.Pop();
                }
                else
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            if(numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if(numbers.Contains(peek))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}
