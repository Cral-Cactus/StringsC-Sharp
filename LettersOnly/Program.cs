using System;
using System.Text.RegularExpressions;

namespace LettersOnly
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string result = ReplaceNumbers(input);

            Console.WriteLine(result);

            //string pattern = @"(\d+)([A-Za-z])";
            //string input = Console.ReadLine();

            //foreach (Match match in Regex.Matches(input, pattern))
            //{
            //    input = Regex.Replace(input, match.Groups[1].Value, match.Groups[2].Value);
            //}
            //Console.WriteLine(input);
        }

        static string ReplaceNumbers(string message)
        {
            string output = "";
            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                if (char.IsDigit(c))
                {
                    int j = i + 1;
                    while (j < message.Length && char.IsDigit(message[j]))
                    {
                        j++;
                    }
                    if (j < message.Length)
                    {
                        char nextChar = message[j];
                        output += nextChar;
                    }
                    i = j - 1;
                }
                else
                {
                    output += c;
                }
            }
            return output;
        }
    }
}