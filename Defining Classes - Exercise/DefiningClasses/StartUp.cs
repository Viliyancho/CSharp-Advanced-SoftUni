namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person = new Person();


            person.Name = "Kircho";
            person.Age= 30;


            Console.WriteLine($"{person.Name} is {person.Age} years old.");
        }
    }
}