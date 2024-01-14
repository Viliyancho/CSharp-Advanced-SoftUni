using System;
using System.Linq;

namespace _04._FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            Predicate<int> isEvenOrOdd;

            if(command == "even")
            {
                isEvenOrOdd = number =>
                {
                    return number % 2 == 0;
                };
            }
            else 
            {
                isEvenOrOdd = number =>
                {
                    return number % 2 != 0;
                };
            }
            

            for (int i = range[0]; i <= range[1]; i++)
            {
                if(isEvenOrOdd(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
