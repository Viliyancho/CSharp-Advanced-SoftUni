using System;
using System.Linq;

namespace _05._AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Action<int[]> print = numbers => Console.WriteLine(string.Join(' ', numbers));
            Func<int[], int[]> operation;

            string command = string.Empty;

            while((command = Console.ReadLine()) != "end")
            {
                switch(command)
                {
                    case "add":
                        operation = numbers =>
                        {
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                numbers[i]++;
                            }
                            return numbers;
                        };
                        numbers = operation(numbers);
                        break;
                    case "multiply":
                        operation = numbers =>
                        {
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                numbers[i] *= 2;
                            }
                            return numbers;
                        };
                        numbers = operation(numbers);
                        break;
                    case "subtract":
                        operation = numbers =>
                        {
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                numbers[i]--;
                            }
                            return numbers;
                        };
                        numbers = operation(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
