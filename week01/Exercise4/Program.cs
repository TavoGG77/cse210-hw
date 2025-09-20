using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;

        Console.WriteLine("Enter a list of numbers, type 0 when you finished: ");
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number != 0)
                numbers.Add(number);
        }

        int sum_tot = 0;

        foreach (int only in numbers)
        {
            sum_tot += only;
        }
        Console.WriteLine($"The sum is: {sum_tot}");

        int avg = sum_tot / numbers.Count;
        Console.WriteLine($"The average is: {avg:F2}");

        int mayor = numbers[0];

        foreach (int numb in numbers)
        {
            if (numb > mayor)
                mayor = numb;
        }
        Console.WriteLine($"The largest number is: {mayor}");

        int minor = 999;

        foreach (int numbs in numbers)
        {
            if (numbs < minor && minor > -1)
                minor = numbs;
        }
        Console.WriteLine($"The smallest positive number is: {minor}");

        Console.WriteLine("The sorted list is");
        numbers.Sort();
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

    }
}