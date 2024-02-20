using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett","Multiplication");
        Math math = new Math("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Writing writing = new Writing("Mary Waters", "European History", "The Causes of World War II");

        Console.Clear();
        Console.WriteLine($"{assignment.GetSummary()}\r\n");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine($"{math.GetHomeworkList()}r\n");

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInfo());
    }
}