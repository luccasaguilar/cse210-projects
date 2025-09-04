using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int number = randomGenerator.Next(1, 100);
        int guess = 101;
        int count = 0;
        string keep_playing = "YES";

        while (keep_playing == "YES") {
            while (guess != number) {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                count ++;

                if (guess < number) {
                    Console.WriteLine("Higher");
                }
                else if (guess > number) {
                    Console.WriteLine("Lower");
                }
                else {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {count} guesses");

                    Console.Write("Would you like to play again (yes/no)? ");
                    keep_playing = Console.ReadLine().ToUpper();

                    if (keep_playing == "YES") {
                        count = 0;
                        guess = 101;
                    }
                    else {
                        Console.WriteLine("Thank you for playing. Goodbye.");
                    }
                }
            }
        }
             
    }
}