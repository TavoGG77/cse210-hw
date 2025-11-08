using System;

class Program
{
    static void Main(string[] args)
    {

        string play = "";
        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);

            int guess;
            int counter = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                counter++;


            } while (guess != number);

            Console.WriteLine("You guess it!");
            Console.WriteLine($"Attempts: {counter}");
            Console.WriteLine("Do you want to play again?");
            play = Console.ReadLine();
        } while (play == "yes");

        
    }
}