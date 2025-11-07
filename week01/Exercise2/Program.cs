using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string additional;

        
        if (grade < 90 && grade > 60 && grade % 10 >= 7)
        {
            additional = "+";
        }
        else if (grade < 90 && grade > 60 && grade % 10 <= 3)
        {
            additional = "-";
        }
        else
        {
            additional = "";
        }


        Console.WriteLine($"Your grade is {letter}{additional}");

        if (grade >= 70)
        {
            Console.WriteLine($"Congratulation, you passed!");
        }
        else
        {
            Console.WriteLine($"Sorry, you did not pass, keep working for next chance");
        }
    }
}