using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Print")
            {
                string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);

                string action = tokens[0];
                string filter = tokens[1];
                string sub = tokens[2];

                if (action == "Add filter")
                {
                    filters.Add(filter + sub, GetPredicated(filter, sub));
                }
                else
                {
                    filters.Remove(filter + sub);
                }
            }

            foreach (var filter in filters)
            {
                people.RemoveAll(filter.Value);
            }

            Console.WriteLine(string.Join(" ", people));

            static Predicate<string> GetPredicated(string filter, string value)
            {
                switch (filter)
                {
                    case "Starts with":
                        return p => p.StartsWith(value);
                    case "Ends with":
                        return p => p.EndsWith(value);
                    case "Contains":
                        return p => p.Contains(value);
                    case "Length":
                        return p => p.Length == int.Parse(value);
                    default:
                        return default;
                }
            }
        }

    }
}
