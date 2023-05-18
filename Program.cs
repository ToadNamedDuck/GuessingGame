using System;
using System.Collections.Generic;

void GuessingGame()
{
    Random random = new Random();
    int guessTracker = 0;
    int secretNumber = random.Next(1,100);
    int trackedGuess;
    int maxAttempts = 5; // one fewer than the real number, because the guessTracker starts at 0
    Console.WriteLine("Welcome to the Guessing Game!");
    Console.WriteLine("_____________________________");
    Console.WriteLine("You will be guessing my SECRET! number. The range is 1-100, inclusive.");
    Console.WriteLine("First, select a difficulty. The choices are: Easy, Medium, Hard");
    var difficulty = Console.ReadLine();
    if(difficulty.ToLower() == "easy"){
        maxAttempts = 7;//One fewer than the actual number. 7 becomes 8 attempts.
    }
    if(difficulty.ToLower() == "medium"){
        maxAttempts = 5;
    }
    if(difficulty.ToLower() == "hard"){
        maxAttempts = 3;
    }
    Console.WriteLine($"You only have {maxAttempts + 1} attempts to win!");
    Console.WriteLine("___________________________________");
    Console.WriteLine("PLEASE: Only enter in a number!");
    Console.WriteLine($"Enter your guess (Guess {guessTracker + 1} - {maxAttempts - guessTracker} Left!): ");

    do//do...while to keep track of the userGuess and compare it to an outside-scope variable, if the input can change.
    {
        int userGuess = int.Parse(Console.ReadLine());
        trackedGuess = userGuess;

        if (userGuess != secretNumber && guessTracker != maxAttempts)
        {
            Console.WriteLine("Alas, not this time, but maybe next time!");
            if (guessTracker < maxAttempts)//prevents these lines from going through after the final input session.
            {
                guessTracker++;
                if(userGuess > secretNumber){
                    Console.WriteLine("Your guess is HIGHER than the secret number!");
                    Console.WriteLine($"Enter your guess (Guess {guessTracker + 1} - {maxAttempts - guessTracker} Left!): ");
                }
                else{
                    Console.WriteLine("Your guess is LOWER than the secret number!");
                    Console.WriteLine($"Enter your guess (Guess {guessTracker + 1} - {maxAttempts - guessTracker} Left!): ");
                }
            }
        }
        else
        {
            if(userGuess == secretNumber){//success, good guess.
                Console.WriteLine($"Good guess! It was {secretNumber} all along!");
            }
            else{//too many attempts.
                Console.WriteLine($"Unlucky! Play another game! The number was {secretNumber}!");
            }
            break;//break and end regardless of outcome.
        }
    } while (trackedGuess != secretNumber && guessTracker <= maxAttempts);
}

GuessingGame();