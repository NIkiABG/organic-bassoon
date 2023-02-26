using System;

class Program {
  static void Main(string[] args) {
    Random random = new Random();
    int secretNumber = random.Next(1, 101);
    int guess = 0;
    int numGuesses = 0;

    Console.WriteLine("Guess the secret number between 1 and 100!");

    while (guess != secretNumber) {
      Console.Write("Enter your guess: ");
      guess = Convert.ToInt32(Console.ReadLine());
      numGuesses++;

      if (guess < secretNumber) {
        Console.WriteLine("Too low! Guess again.");
      } else if (guess > secretNumber) {
        Console.WriteLine("Too high! Guess again.");
      } else {
        Console.WriteLine("Congratulations, you guessed the secret number!");
        Console.WriteLine("It took you " + numGuesses + " guesses.");
      }
    }
  }
}
