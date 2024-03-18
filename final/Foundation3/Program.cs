using System;
using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        bool t = true;
        ConsoleKey input = ConsoleKey.Insert;
        int move = 0;
        String[] os = new String[10];

        Console.WriteLine("How many slots does the ship take? ");
        int hp = int.Parse(Console.ReadLine());
        hp = hp - 1;

        while (!Console.KeyAvailable && input != ConsoleKey.Enter)
        {
            Console.Clear();
            if (input == ConsoleKey.D)
            {
                move = move + 1;

                while (move >= 10 - hp)
                {
                    move = 9 - hp;
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
                if (os[i] != "O" || i < move || i > (move + hp))
                {
                    os[i] = "~";
                }
                
                for (int j = move; j <= (move + hp); j++)
                {
                    if (i == move)
                    {
                        os[j] = "O";
                    }
                }
                
                Console.Write(os[i]);
            }
            input = Console.ReadKey(true).Key;
            Console.WriteLine();
        }
    }
}