using System;
using System.Text;

namespace CensorStringBuilder
{
    internal class Program
    {
        static void Main()
        {
            string censor = Console.ReadLine();
            string sentance = Console.ReadLine();

            StringBuilder sb = new StringBuilder(sentance);
            int index = sb.ToString().IndexOf(censor);

            sb.Clear();
            sb.Append(sentance);

            while (index != -1)
            {
                sb.Remove(index, censor.Length);
                sb.Insert(index, new string('*', censor.Length));

                index = sb.ToString().IndexOf(censor);
            }

            Console.WriteLine(sb.ToString());

        }
    }
}