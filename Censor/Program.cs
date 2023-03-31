using System;

namespace Censor
{
    internal class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();

            sentence = sentence.Replace(word, new string('*', word.Length));

            Console.WriteLine(sentence);
        }
    }
}