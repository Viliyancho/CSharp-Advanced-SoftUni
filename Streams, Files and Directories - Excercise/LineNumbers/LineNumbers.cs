namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines(inputFilePath);
            int count = 0;

            foreach (var line in lines)
            {
                int letters = line.Count(l => char.IsLetter(l));
                int punctuations = line.Count(p => char.IsPunctuation(p));
                sb.AppendLine($"Line {count+1}: {line} ({letters})({punctuations})");
                count++;
            }

            File.WriteAllText(outputFilePath, sb.ToString());
        }
    }
}
