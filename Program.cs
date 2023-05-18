using System;
using System.Collections.Generic;

void GuessingGame(){
    //int guessNum = 1;
    Console.WriteLine("Welcome to the Guessing Game!");
    Console.WriteLine("You will be guessing my SECRET! number. The range is 1-100, inclusive.");
    Console.WriteLine("Enter your guess: ");
    var userGuess = Console.ReadLine();
    Console.WriteLine($"Your guess was: {userGuess}");
}

GuessingGame();