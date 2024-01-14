namespace TupleEx
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] secondLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] thirdLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);


            CustomTuple<string, string> tuple1 = new()
            {
                Item1 = $"{firstLine[0]} {firstLine[1]}",
                Item2 = firstLine[2]
            };

            CustomTuple<string, int> tuple2 = new()
            {
                Item1 = secondLine[0],
                Item2 = int.Parse(secondLine[1])
            };

            CustomTuple<int, double> tuple3 = new()
            {
                Item1 = int.Parse(thirdLine[0]),
                Item2 = double.Parse(thirdLine[1])
            };

            Console.WriteLine(tuple1.ToString());
            Console.WriteLine(tuple2.ToString());
            Console.WriteLine(tuple3.ToString());
        }
    }
}