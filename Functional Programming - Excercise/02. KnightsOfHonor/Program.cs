using System;

namespace _02._KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = names =>
            {
                foreach (var name in names)
                {
                    Console.WriteLine($"Sir {name}");
                }
            };

            print(names);
        }
    }
}
