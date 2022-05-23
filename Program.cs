using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int index = 0;
            while (index < 4)
            {
                Console.WriteLine("Hey, guess a number!");
                string response = Console.ReadLine();
                int ParseResponse = int.Parse(response);
                int SecretNum = 69;
                if (ParseResponse == SecretNum)
                {
                    Console.WriteLine("Success Message!");
                }
                else { Console.WriteLine("Failure Message!"); }
                index++;
            }
        }

    }


}


