using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, guess a number!");
            int index = 0;
            while (index < 4)
            {

                string response = Console.ReadLine();
                int ParseResponse = int.Parse(response);
                int SecretNum = 69;
                if (ParseResponse == SecretNum)
                {
                    Console.WriteLine("Success Message!");
                }
                else
                {
                    Console.WriteLine($"Your guess is: {ParseResponse}");
                    Console.WriteLine($"You have {3 - index} more chances to guess");
                }
                index++;
            }
        }

    }


}


