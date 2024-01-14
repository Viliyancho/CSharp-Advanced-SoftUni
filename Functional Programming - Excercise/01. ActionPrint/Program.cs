using System;

namespace _01._ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = name => Console.WriteLine(string.Join(Environment.NewLine, name));

            print(names);
        }
    }
}
