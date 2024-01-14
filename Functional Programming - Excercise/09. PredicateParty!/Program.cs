using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] commandArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = commandArgs[0];
                string condition = commandArgs[1];
                string sub = commandArgs[2];

                if (command == "Remove")
                {
                    people.RemoveAll(GetPredicated(condition, sub));
                }
                else
                {
                    List<string> peopleToDouble = people.FindAll(GetPredicated(condition, sub));

                    foreach (var person in peopleToDouble)
                    {
                        int index = people.FindIndex(p => p == person);

                        people.Insert(index, person);
                    }
                }
            }

            if(people.Any())
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Predicate<string> GetPredicated(string condition, string sub)
        {
            switch (condition)
            {
                case "StartsWith":
                    return p => p.StartsWith(sub);
                case "EndsWith":
                    return p => p.EndsWith(sub);
                case "Length":
                    return p => p.Length == int.Parse(sub);
                default:
                    return null;
            }

        }
    }
}
