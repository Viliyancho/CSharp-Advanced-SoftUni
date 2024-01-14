using System;
using System.Collections.Generic;

namespace _08._BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> symbols = new Stack<char>();

            string tokens = Console.ReadLine();
            for (int i = 0; i < tokens.Length; i++)
            {
                char one = tokens[i];
                switch (one)
                {
                    case '{':
                        symbols.Push('{');
                        break;
                    case '(':
                        symbols.Push('(');
                        break;
                    case '[':
                        symbols.Push('[');
                        break;

                    case '}':
                        if (symbols.Count == 0 || symbols.Pop() != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ')':
                        if (symbols.Count == 0 || symbols.Pop() != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ']':
                        if (symbols.Count == 0 || symbols.Pop() != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }

            }
            if(symbols.Count != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
            Console.WriteLine("YES");
            }
        }
    }
}
