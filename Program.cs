using System;

Console.WriteLine("Can you guess the secret number?");

string usersGuessToConvert = Console.ReadLine();
int usersGuess = Convert.ToInt32(usersGuessToConvert);

Console.WriteLine($"You guessed: {usersGuess}");