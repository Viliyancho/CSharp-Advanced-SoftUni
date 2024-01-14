namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            StringBuilder text = new StringBuilder();
            using (reader)
            {
                int count = 0;
                string line = string.Empty;
                while(line != null)
                {
                    line = reader.ReadLine();
                    
                    if(count % 2 == 0)
                    {
                        string replacedLine = Replaced(line);
                        string reversedLine = ReversedLine(replacedLine);
                        text.AppendLine(reversedLine);
                    }
                    count++;
                }
            }
            return text.ToString();
            
        }

        private static string ReversedLine(string newLine)
        {
            string[] newOne = newLine
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Reverse()
               .ToArray();

            return string.Join(" ", newOne);

        }

        private static string Replaced(string line)
        {
            char[] symbols = new char[] { '-', ',', '.', '!', '?' };
            foreach (var symbol in symbols)
            {
                line = line.Replace(symbol, '@');
            }
            return line;
        }
    }
}
