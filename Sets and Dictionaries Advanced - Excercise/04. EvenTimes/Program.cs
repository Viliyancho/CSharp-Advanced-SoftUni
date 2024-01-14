using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbersCount = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(!numbersCount.ContainsKey(number))
                {
                    numbersCount.Add(number, default);
                }
                numbersCount[number]++;
            }

            Console.WriteLine(numbersCount.Single(x => x.Value % 2 == 0).Key);
        }
    }
}
