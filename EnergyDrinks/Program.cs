using System.Collections.Generic;

namespace EnergyDrinks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> caffeine = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Queue<int> drinks = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int miligrams = 0;

            while (caffeine.Count != 0 && drinks.Count != 0)
            {
                int removedCaffeine = caffeine.Pop();
                int removedDrink = drinks.Dequeue();
                int result = removedCaffeine * removedDrink;

                if (result <= 300 - miligrams)
                {
                    miligrams += result;
                }
                else
                {
                    drinks.Enqueue(removedDrink);
                    miligrams -= 30;
                }

                if (miligrams < 0)
                {
                    miligrams = 0;
                }
            }

            if (drinks.Count != 0)
            {
                Console.WriteLine($"Drinks left: {string.Join(", ", drinks)}");
            }
            else if (drinks.Count == 0)
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }
            Console.WriteLine($"Stamat is going to sleep with {miligrams} mg caffeine.");
        }
    }
}