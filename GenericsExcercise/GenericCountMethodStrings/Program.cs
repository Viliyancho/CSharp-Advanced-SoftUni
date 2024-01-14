using GenericSwapMethod;

namespace GenericCountMethodStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new();
            for (int i = 0; i < n; i++)
            {
                Box<double> box = new();
                double input = double.Parse(Console.ReadLine());
                box.Text = input;

                boxes.Add(box);
            }
            double element = double.Parse(Console.ReadLine());
            Console.WriteLine(Box<double>.Method<double>(boxes, element));
        }
    }
}