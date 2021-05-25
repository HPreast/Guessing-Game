using System;

int secretNumber = 42;

Console.WriteLine("Can you guess the secret number in 4 tries?");
// string usersGuessToConvert = Console.ReadLine();
// int usersGuess = Convert.ToInt32(usersGuessToConvert);


checkUserGuess();

void checkUserGuess()
{
    for (int i = 3; i >= 0; i--)
    {
        string usersGuessToConvert = Console.ReadLine();
        int usersGuess = Convert.ToInt32(usersGuessToConvert);

        if (usersGuess == secretNumber)
        {
            Console.WriteLine("Congrats! You guessed correctly.");
            break;
        }
        else
        {
            Console.WriteLine("Sorry, that is not the right number.");
            Console.WriteLine($"You have {i} chances left.");
        }
    }
}