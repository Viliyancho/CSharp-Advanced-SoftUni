namespace Froggy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] stones = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake all = new Lake(stones);

            Console.WriteLine(string.Join(", ", all));
        }
    }
}