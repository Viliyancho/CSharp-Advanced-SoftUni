namespace GenericBox
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

            foreach (var item in boxes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}