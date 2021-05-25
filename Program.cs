using System;

int secretNumber = new Random().Next(1, 100);

Console.WriteLine("Can you guess the secret number in 4 tries?");
// string usersGuessToConvert = Console.ReadLine();
// int usersGuess = Convert.ToInt32(usersGuessToConvert);


checkUserGuess();

void checkUserGuess()
{
    int j = 1;
    for (int i = 3; i >= 0; i--, j++)
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
            Console.WriteLine($"Your guess {j}");
            Console.WriteLine($"You have {i} chances left.");
        }
    }
}