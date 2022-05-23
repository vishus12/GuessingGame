using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int SecretNum = r.Next(1, 100);
            int index = 0;
            while (index < 4)
            {
                Console.WriteLine("Hey, guess a number!");
                string response = Console.ReadLine();
                int ParseResponse = int.Parse(response);

                if (ParseResponse == SecretNum)
                {
                    Console.WriteLine("Success!");
                }
                else
                {
                    Console.WriteLine($"Your guess is {ParseResponse}");
                }
                Console.WriteLine($"You have {3 - index} more chances");
                index++;
            }
        }
    }
}