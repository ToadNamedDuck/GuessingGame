using System;
using System.Collections.Generic;

void GuessingGame(){
    //int guessTracker = 1;
    int secretNumber = 42;
    Console.WriteLine("Welcome to the Guessing Game!");
    Console.WriteLine("You will be guessing my SECRET! number. The range is 1-100, inclusive.");
    Console.WriteLine("PLEASE: Only enter in a number!");
    Console.WriteLine("Enter your guess: ");
    var userGuess = int.Parse(Console.ReadLine());
    if(userGuess == secretNumber){
        Console.WriteLine($"How did you guess my secret number! It was {secretNumber} all along!");
    }
    else{
        Console.WriteLine("Alas, not this time! Sorry!");
    }
}

GuessingGame();