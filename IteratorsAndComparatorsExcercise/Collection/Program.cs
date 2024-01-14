using CollectionEx;

namespace CollectionEx
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();
            
 
            ListyIterator<string> generic = new ListyIterator<string>(numbers);

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {

                switch (input)
                {
                    case "Print":
                        generic.Print();
                        break;

                    case "HasNext":
                        Console.WriteLine(generic.HasNext()); 
                        break;

                    case "Move":
                        Console.WriteLine(generic.Move());
                        break;
                    case "PrintAll":
                        Console.WriteLine(string.Join(" ", generic));
                        break;
                }
            }
        }
    }
}