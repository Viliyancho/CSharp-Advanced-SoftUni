using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._BasicQueueOperations
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

            int enqueue = tokens[0];
            int dequeue = tokens[1];
            int peek = tokens[2];

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < enqueue; i++)
            {
                numbers.Enqueue(randoms[i]);
            }

            for (int i = 0; i < dequeue; i++)
            {
                if(numbers.Any())
                {
                numbers.Dequeue();
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
