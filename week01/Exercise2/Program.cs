using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the grade percent? ");
        string enter = Console.ReadLine();

        int grade = int.Parse(enter);
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

        string sign = "";
        int additional = grade % 10;

        if (additional >= 7)
        {
            sign = "+";
        }
        else if (additional < 3)
        {
            sign = "-";
        }
        if (letter == "F")
        {
            sign = "";
        }
        if (grade >= 93)
        {
            sign = "";
        }


        if (grade >= 70)
            {
                Console.WriteLine($"Your grade is: {letter}{sign}, you passed!");
            }
            else
            {
                Console.WriteLine($"Your grade is: {letter}{sign}, you did not passed!");
            }
    }
}