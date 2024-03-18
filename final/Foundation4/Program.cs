using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool t = true;
        ConsoleKey input = ConsoleKey.Insert;
        int move = 0;
        String[] os = new String[10];

        while (!Console.KeyAvailable && input != ConsoleKey.Enter)
        {
            Console.Clear();
            if (input == ConsoleKey.D)
            {
                move = move + 1;

                while (move >= 10)
                {
                    move = 9;
                }
            }

            if (input == ConsoleKey.A)
            {
                move = move - 1;
                if (move <= 0)
                {
                    move = 0;
                }
            }

            for (int i = 0; i < 10 && i >= 0; i++)
            {

                if (i == move)
                {
                    os[move] = "O";
                }
                
                else
                {
                    os[i] = "~";
                }
                
                Console.Write(os[i]);
            }
            input = Console.ReadKey(true).Key;
            Console.WriteLine();
        }
    }
}