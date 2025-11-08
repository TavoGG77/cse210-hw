using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int option = -1;
        int counter = 0;
        int sum = 0;

        do
        {
            Console.Write("Enter number: ");
            option = int.Parse(Console.ReadLine());

            if (option != 0)
            {
                numbers.Add(option);
            }

            sum += option;
            counter++;
            
        } while (option != 0);

        float average = (float)sum / (counter - 1);
        int maxNumber = numbers.Max();

        int minNumber = maxNumber;

        foreach (int num in numbers)
        {
            if (num > 0 && num < minNumber)
            {
                minNumber = num;
            }
        }

        numbers.Sort();

        Console.WriteLine();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine($"The smallest number is: {minNumber}");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }

    }
}