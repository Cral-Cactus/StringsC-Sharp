using System;

namespace SendMeAnEmail
{
    internal class Program
    {
        static void Main()
        {
            string email = Console.ReadLine();

            int atIndex = email.IndexOf("@");
            string username = email.Substring(0, atIndex);
            string domain = email.Substring(atIndex + 1);

            int sum = 0;

            foreach (char c in username)
            {
                sum += (int)c;
            }

            foreach (char c in domain)
            {
                sum -= (int)c;
            }

            if (sum >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}