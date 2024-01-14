using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int n = int.Parse(Console.ReadLine());
            int rack = n;
            int count = 1;

            while(clothes.Count != 0)
            {
                if(clothes.Peek() <= rack)
                {
                    rack -= clothes.Pop();
                }
                else
                {
                    count++;
                    rack = n;
                }
            }
            Console.WriteLine(count);
        }
    }
}
