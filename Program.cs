using System;
using System.Collections.Generic;

void GuessingGame()
{
    int guessTracker = 0;
    int secretNumber = 42;
    int trackedGuess;
    Console.WriteLine("Welcome to the Guessing Game!");
    Console.WriteLine("You will be guessing my SECRET! number. The range is 1-100, inclusive.");
    Console.WriteLine("PLEASE: Only enter in a number!");
    Console.WriteLine($"Enter your guess ({guessTracker + 1}): ");
    
    do//do...while to keep track of the userGuess and compare it to an outside-scope variable, if the input can change.
    {
        int userGuess = int.Parse(Console.ReadLine());
        trackedGuess = userGuess;

        if (userGuess != secretNumber && guessTracker != 3)
        {
            Console.WriteLine("Alas, not this time, but maybe next time!");
            if (guessTracker < 3)//prevents these lines from going through after the final input session.
            {
                guessTracker++;
                Console.WriteLine($"Enter your guess ({guessTracker + 1}): ");
            }
        }
        else
        {
            if(userGuess == secretNumber){//success, good guess.
                Console.WriteLine($"Good guess! It was {secretNumber} all along!");
            }
            else{//too many attempts.
                Console.WriteLine("Unlucky! Play another game!");
            }
            break;//break and end regardless of outcome.
        }
    } while (trackedGuess != secretNumber && guessTracker <= 3);
}

GuessingGame();