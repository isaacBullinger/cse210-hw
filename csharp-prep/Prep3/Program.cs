using System;

class Program
{
    static void Main(string[] args)
    {
        bool again = true;
        int count = 0;
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        // Console.Write("What is the magic number? ");
        // string number = Console.ReadLine();
        // int magic = int.Parse(number);

        while (again == true)
        {
            count = count + 1;
            Console.Write("What is your guess? ");
            string number1 = Console.ReadLine();
            int guess = int.Parse(number1);
            if (magic < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magic > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic == guess)
            {
                Console.WriteLine($"You guessed it in {count} tries!");
                Console.Write("Do you want to play again? ");
                string confirm = Console.ReadLine();
                
                if (confirm == "yes")
                    {
                        again = true;
                        count = 0;
                        Random newGenerator = new Random();
                        magic = newGenerator.Next(1, 101);
                    }
                else if (confirm == "no")
                    {
                        again = false;
                    }
                else
                    {
                        Console.Write("Invalid input...");
                        again = false;
                    }
            }
        }
    }
}