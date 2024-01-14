using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            Queue<int> orders = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Console.WriteLine(orders.Max());
            while(true)
            {
                if(orders.Any())
                {
                    if (orders.Peek() <= quantity)
                    {
                        quantity -= orders.Dequeue();
                    }
                    else
                    {
                        int left = 0;
                        foreach (var item in orders)
                        {
                            left += item;
                        }
                        Console.WriteLine($"Orders left: {left}");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Orders complete");
                    return;
                }
               
            }
        }
    }
}
