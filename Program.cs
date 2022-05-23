using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}


// The program should be updated to...

// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
// No longer display the user's guess. They know what they guessed, right?
// Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.