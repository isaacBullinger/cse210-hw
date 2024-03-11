using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool t = true;
        string input = "";
        int move = 0;
        String[] os = new String[10];
        for (int i = 0; i < 10; i++)
        {
            os[i] = "~";
        }
        while (t == true)
        {

            for (int i = 0; i < 10 && i >= 0; i++)
            {
                if (input == "d")
                {
                    move = move + 1;
                }

                if (input == "a")
                {
                    move = move - 1;
                }

                if (i == move)
                {
                    os[move] = "_";
                    Console.Write(os[move]);
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                    Thread.Sleep(500);
                }

                else
                {
                    Console.Write("~");
                    Console.Write("\b \b");
                }
            }
        }
    }
}