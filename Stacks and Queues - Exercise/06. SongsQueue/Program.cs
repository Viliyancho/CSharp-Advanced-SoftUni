using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                );

            while(songs.Count != 0)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                switch(command[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string song = string.Join(" ", command.Skip(1));
                        if(songs.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(song);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
