using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        string keep = "yes";
        while (keep == "yes")
        {
            int number = randomGenerator.Next(1, 11);
            int guess = -1;
            int countg = 0;
            while (guess != number)
            {
                Console.Write("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
                countg++;

                if (guess < number)
                    Console.WriteLine("Higher");
                else if (guess > number)
                    Console.WriteLine("Lower");
                else
                    Console.WriteLine("You guessed it!");

            }
            Console.WriteLine($"It took you {countg} guesses");
            Console.WriteLine();
            Console.WriteLine("Would you like to play again (yes/no) ");
            keep = Console.ReadLine();
        }
        Console.WriteLine("Thank you for playing. Goodbye.");
    }
}