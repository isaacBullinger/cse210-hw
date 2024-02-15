using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        string confirm;

        while (quit == false)
            {
                Scripture scripture = new Scripture();
                Console.WriteLine($"{scripture.GetText()}\r\n");
                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                confirm = Console.ReadLine();

                if (confirm == "quit")
                    {
                        quit = true;
                    }
                Console.Clear();
            }
    }
}