using System;

int secretNumber = new Random().Next(1, 100);


Console.WriteLine("Choose your difficulty; Easy: 8 tries, Medium: 6 tries, Hard: 4 tries");
var userDifficulty = Console.ReadLine();

int numberOfGuesses = 0;

if (userDifficulty == "easy")
{
    numberOfGuesses = 8;
}
else if (userDifficulty == "medium")
{
    numberOfGuesses = 6;
}
else if (userDifficulty == "hard")
{
    numberOfGuesses = 4;
}

Console.WriteLine($"Can you guess the secret number in {numberOfGuesses} tries?");


checkUserGuess();

void checkUserGuess()
{
    int j = 1;
    for (int i = numberOfGuesses - 1; i >= 0; i--, j++)
    {
        string usersGuessToConvert = Console.ReadLine();
        int usersGuess = Convert.ToInt32(usersGuessToConvert);

        if (usersGuess == secretNumber)
        {
            Console.WriteLine("Congrats! You guessed correctly.");
            break;
        }
        else if (usersGuess < secretNumber)
        {
            Console.WriteLine("Too low, try again!");
            Console.WriteLine($"Your guess {j}");
            Console.WriteLine($"You have {i} chances left.");
        }
        else if (usersGuess > secretNumber)
        {
            Console.WriteLine("Too high, try again!");
            Console.WriteLine($"Your guess {j}");
            Console.WriteLine($"You have {i} chances left.");
        }
    }
}