using System;

namespace TheHidingPlace
{
    internal class Program
    {
        static void Main()
        {
            string map = Console.ReadLine();

            while (true)
            {
                string[] searchParams = Console.ReadLine().Split();

                char searchedChar = char.Parse(searchParams[0]);
                int minCount = int.Parse(searchParams[1]);

                int startIndex = map.IndexOf(new string(searchedChar, minCount));

                if (startIndex != -1)
                {
                    int endIndex = startIndex + minCount;

                    while (endIndex < map.Length && map[endIndex] == searchedChar)
                    {
                        endIndex++;
                    }

                    int size = endIndex - startIndex;

                    Console.WriteLine($"Hideout found at index {startIndex} and it is with size {size}!");
                    break;
                }
            }
        }
    }
}