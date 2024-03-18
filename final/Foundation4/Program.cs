using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool isHorizontal = true;
        ConsoleKey input = ConsoleKey.Insert;
        int moveX = 0;
        int moveY = 0;
        String[,] os = new String[10,10];

        Console.WriteLine("How many slots does the ship take? ");
        int hp = int.Parse(Console.ReadLine());
        hp = hp - 1;

        while (!Console.KeyAvailable && input != ConsoleKey.Enter)
        {
            Console.Clear();

            if (input == ConsoleKey.W)
            {
                moveX = moveX - 1;
                if (moveX <= 0)
                {
                    moveX = 0;
                }
            }

            if (input == ConsoleKey.A)
            {
                moveY = moveY - 1;
                if (moveY <= 0)
                {
                    moveY = 0;
                }
            }

            if (input == ConsoleKey.H)
            {
                isHorizontal = true;

                if (moveY >= 10 - hp)
                {
                    moveY = 9 - hp;
                }
            }

            if (input == ConsoleKey.V)
            {
                isHorizontal = false;
                
                if (moveX >= 10 - hp)
                {
                    moveX = 9 - hp;
                }
            }

            if (input == ConsoleKey.S)
            {
                moveX = moveX + 1;

                if (isHorizontal == false)
                {
                    while (moveX >= 10 - hp)
                    {
                        moveX = 9 - hp;
                    }
                }

                else
                {
                    while (moveX >= 10)
                    {
                        moveX = 9;
                    }
                }
            }

            if (input == ConsoleKey.D)
            {
                if (isHorizontal == true)
                {
                    moveY = moveY + 1;

                    while (moveY >= 10 - hp)
                    {
                        moveY = 9 - hp;
                    }
                }

                else
                {
                    moveY = moveY + 1;

                    while (moveY >= 10)
                    {
                        moveY = 9;
                    }
                }
            }


            for (int i = 0; i < 10 && i >= 0; i++)
            {
                for (int j = 0; j < 10 && j >= 0; j++)
                {
                    if (i == moveX)
                    {
                        if (j == moveY)
                        {
                            os[moveX, moveY] = "O";
                        }

                        else
                        {
                            os[i, j] = "~";
                        }
                    }

                    else
                    {
                        os[i, j] = "~";
                    }
                
                    Console.Write(os[i, j]);
                }
                Console.WriteLine();
            }
            input = Console.ReadKey(true).Key;
            Console.WriteLine();
        }
    }
}