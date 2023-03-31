using System;
using System.Text;

namespace StringBuilderr
{
    internal class Program
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            StringBuilder sb = new StringBuilder(inputString);

            string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "Append":
                        sb.Append(command[1]);
                        break;
                    case "Remove":
                        int removeStartIndex = int.Parse(command[1]);
                        int removeLength = int.Parse(command[2]);
                        sb.Remove(removeStartIndex, removeLength);
                        break;
                    case "Insert":
                        int insertIndex = int.Parse(command[1]);
                        sb.Insert(insertIndex, command[2]);
                        break;
                    case "Replace":
                        sb.Replace(command[1], command[2]);
                        break;
                    default:
                        break;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}