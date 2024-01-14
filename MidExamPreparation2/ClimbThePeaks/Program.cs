namespace ClimbThePeaks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> mountains = new Dictionary<string, int>()
            {
                { "Vihren", 80 },
                {"Kutelo", 90},
                {"Banski Suhodol", 100},
                {"Polezhan", 60},
                {"Kamenitza", 70}
            };

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Vihren");
            queue.Enqueue("Kutelo");
            queue.Enqueue("Banski Suhodol");
            queue.Enqueue("Polezhan");
            queue.Enqueue("Kamenitza");

            List<string> conqueredPeaks = new List<string>();


            Stack<int> food = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            
            Queue<int> stamina = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            while(conqueredPeaks.Count != 5 && food.Count != 0 && stamina.Count != 0)
            {
                int result = food.Pop() + stamina.Dequeue();

                if(result >= mountains[queue.Peek()])
                {
                    conqueredPeaks.Add(queue.Dequeue());
                }
            }

            if(conqueredPeaks.Count != 5)
            {
                Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
            }
            else
            {
                Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
            }

            if(conqueredPeaks.Any())
            {
                Console.WriteLine("Conquered peaks:");
                foreach (var item in conqueredPeaks)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}