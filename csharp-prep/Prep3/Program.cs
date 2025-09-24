using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        int guessCount = 0;
        int lastGuess = 0;
        bool hasGuessed = false;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I have selected a number between 1 and 100. Can you guess it?");
        Console.WriteLine("You have unlimeted attempts. Good luck!\n");

        while(true)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("Please enter a number between 1 and 100.");
                continue;
            }

            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Your guess is out of range. Please guess a number between 1 and 100.");
                continue;
            }

            guessCount++;

            if (guess == targetNumber)
            {
                Console.WriteLine($"\nCongratulations! You guessed it!");
                Console.WriteLine($"The number was {targetNumber}");
                Console.WriteLine($"It took you {guessCount} guess{(guessCount == 1 ? "" : "es")}!");
                break;
            }
            else
            {
                if(hasGuessed)
                {
                    int previousDistance = Math.Abs(lastGuess - targetNumber);
                    int currentDistance = Math.Abs(guess - targetNumber);

                    if(currentDistance < previousDistance)
                    {
                        Console.WriteLine("Warmer!");
                    }
                    else if(currentDistance > previousDistance)
                    {
                        Console.WriteLine("Colder!");
                    }
                    else
                    {
                        Console.WriteLine("Neither warmer nor colder. Try again!");
                    }
                }

                if(guess < targetNumber)
                {
                    Console.WriteLine("too low!");
                }
                else
                {
                    Console.WriteLine("too high!");
                }

                Console.WriteLine($"Guesses so far: {guessCount}\n");

                lastGuess = guess;
                hasGuessed = true;
                
            }
        }

        Console.WriteLine("\nThanks for playing my game!");
    }
}