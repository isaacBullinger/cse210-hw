using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string num = "1";
        int sum = 0;
        int max = 0;
        int plusMin = 999999999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (num != "0")
        {
            Console.Write("Enter number: ");
            num = Console.ReadLine();
            int number = int.Parse(num);
            if (num != "0")
            {
            numbers.Add(number);
            }
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            sum = numbers[i] + sum;

            if (max < numbers[i]) 
            {
                max = numbers[i];
            }

            if (numbers[i] > 0)
            {
                if (numbers[i] < plusMin)
                {
                    plusMin = numbers[i];
                }
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        float total = sum;
        float avg = total / (numbers.Count);
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {plusMin}");
        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}