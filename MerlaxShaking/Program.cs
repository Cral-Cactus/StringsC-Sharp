﻿using System;

namespace MerlaxShaking
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                int firstIndex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);

                if (firstIndex != lastIndex)
                {
                    input = input.Remove(lastIndex, pattern.Length);

                    input = input.Remove(firstIndex, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);

                    Console.WriteLine("Shaked it.");
                }

                else
                {
                    break;
                }

            }

            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}