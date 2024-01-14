namespace ComparingObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people= new List<Person>();

            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                people.Add(new Person(input[0], int.Parse(input[1]), input[2]));


                input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            int number = int.Parse(Console.ReadLine());

            Person personToCompare = people[number - 1];
            int matches = 0;
            int difference = 0;
            foreach (var person in people)
            {
                if(personToCompare.CompareTo(person) == 0)
                {
                    matches++;
                }
                else
                {
                    difference++;
                }
            }

            if(matches < 2)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {difference} {people.Count}");
            }
        }
    }
}