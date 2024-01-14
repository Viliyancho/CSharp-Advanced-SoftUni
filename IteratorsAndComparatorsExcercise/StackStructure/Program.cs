namespace StackStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            CustomStack<string> numbers = new CustomStack<string>();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "Push":
                        string[] nums = input.Skip(1).ToArray();

                        numbers.Push(nums);
                        break;
                    case "Pop":
                        numbers.Pop();
                        break;
                }

                input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}