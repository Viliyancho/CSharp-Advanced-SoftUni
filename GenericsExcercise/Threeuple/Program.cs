namespace Threeuple
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


            CustomTuple<string, string, string> tuple1 = new()
            {
                Item1 = $"{firstLine[0]} {firstLine[1]}",
                Item2 = firstLine[2],
                Item3 = string.Join(' ', firstLine.Skip(3))
            };

            CustomTuple<string, int, bool> tuple2 = new()
            {
                Item1 = secondLine[0],
                Item2 = int.Parse(secondLine[1]),
                Item3 = secondLine[2] == "drunk"
            };

            CustomTuple<string, double, string> tuple3 = new()
            {
                Item1 = thirdLine[0],
                Item2 = double.Parse(thirdLine[1]),
                Item3 = thirdLine[2]
            };

            Console.WriteLine(tuple1.ToString());
            Console.WriteLine(tuple2.ToString());
            Console.WriteLine(tuple3.ToString());
        }
    }
}