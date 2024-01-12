using System;
using System.Globalization;
using System.IO.Pipes;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please put your grade in percent: ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string message = "Your letter grade is: ";
        string letter = "";
        string sign = "";

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
        else if (grade < 60)
        {
            letter = "F";
        }

        int digit = grade % 10;

        if (digit > 7)
        {
            sign = "+";
        }
        else if (digit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (grade >= 93)
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }

        Console.Write(message);
        Console.Write(letter);
        Console.WriteLine(sign);

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
            Console.WriteLine("You did not pass, you will get it next time...");
    }
}