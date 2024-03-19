public class Fleet
{
    private Ship _aircraftCarrier = new Ship(5);
    private Ship _battleship = new Ship(4);
    private Ship _submarine = new Ship(3);
    private Ship _destroyer = new Ship(3);
    private Ship _cruiser = new Ship(2);

    public String[,] PlaceShip()
    {
        bool isHorizontal = true;
        ConsoleKey input = ConsoleKey.Insert;
        int moveX = 0;
        int moveY = 0;
        int hitPoints = 0;
        String[,] os = new String[10,10];

        Console.WriteLine("How many slots does the ship take? ");
        hitPoints = int.Parse(Console.ReadLine());
        hitPoints--;

        while (!Console.KeyAvailable && input != ConsoleKey.Enter)
        {
            Console.Clear();

            if (input == ConsoleKey.W && moveX > 0)
            {
                moveX--;
            }

            if (input == ConsoleKey.A && moveY > 0)
            {
                moveY--;
            }

            if (input == ConsoleKey.S)
            {
                if (isHorizontal == true && moveX < 9)
                {
                    moveX++;
                }

                else if (isHorizontal == false && moveX < 9)
                {
                    moveX++;
                }
            }

            if (input == ConsoleKey.D)
            {
                if (isHorizontal == true && moveY < 9 - hitPoints)
                {
                    moveY++;
                }

                else if (isHorizontal == false && moveY < 9)
                {
                    moveY++;
                }
            }

            if (input == ConsoleKey.R)
            {
                if (isHorizontal == true && moveX <= 9 - hitPoints)
                {
                    isHorizontal = false;
                }

                else if (isHorizontal == false && moveY <= 9 - hitPoints)
                {
                    isHorizontal = true;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    os[i, j] = "~";
                }
            }

            if (isHorizontal == true)
            {
                for (int i = moveY; i <= moveY + hitPoints; i++)
                {
                    os[moveX, i] = "O";
                }
            }

            else
            {
                for (int i = moveX; i <= moveX + hitPoints; i++)
                {
                    os[i, moveY] = "O";
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(os[i, j]);
                }
                Console.WriteLine();
            }

            input = Console.ReadKey(true).Key;
            Console.WriteLine();

        }
        return os;
    }
}