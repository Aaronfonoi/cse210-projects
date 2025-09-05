using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers;
        numbers = new List<int>();

        int addedNumber = -1;
        while (addedNumber != 0)
        {
            string response = Console.ReadLine();
            addedNumber = int.Parse(response);

            if (addedNumber != 0)
            {
                numbers.Add(addedNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"the total of all numbers is: {sum}");

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"the average value is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"the largest number is: {max}");

        Console.WriteLine($"quantity of numbers in list: {numbers.Count}");





    }
}
        
            


        



        