using System;

int secretNumber = 42;

Console.WriteLine("Can you guess the secret number?");

string usersGuessToConvert = Console.ReadLine();
int usersGuess = Convert.ToInt32(usersGuessToConvert);

checkUserGuess();

void checkUserGuess()
{
    if (usersGuess == secretNumber)
    {
        Console.WriteLine("Congrats! You guessed correctly.");
    }
    else
    {
        Console.WriteLine("Sorry, that is not the right number.");
    }
}