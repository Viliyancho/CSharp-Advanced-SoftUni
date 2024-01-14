using System;
using System.Linq;

namespace _11._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] people = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Func<int, string, bool> validator = (n, person) =>
            {
                return person.Sum(ch => ch) >= n;
            };

            if(people.Any())
            {
                foreach (var item in people)
                {
                    if(validator(n, item))
                    {
                        Console.WriteLine(item);
                        break;
                    }
                }
            }
        }
    }
}
