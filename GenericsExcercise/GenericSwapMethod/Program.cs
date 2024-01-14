namespace GenericSwapMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Box<int>> boxes = new();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new();
                box.Text = input;
                boxes.Add(box);
            }
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int start = numbers[0];
            int end = numbers[1];
            (boxes[start], boxes[end]) = (boxes[end], boxes[start]);

            Box<int>.Method(boxes);
        }
    }
}