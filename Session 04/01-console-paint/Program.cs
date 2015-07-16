using System;

class Program
{
    static void Main ()
    {

        /* Excercise: Add a splash screen and a simple toolbar. */

        int x = 0, y = 0;
        bool drawing = false;

        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear ();

        Console.WindowWidth = Console.BufferWidth = 80;
        Console.WindowHeight = Console.BufferHeight = 35;

        Console.Title = "Console Paint v0.1";

        Console.BackgroundColor = ConsoleColor.White;

        while (true) {

            switch (Console.ReadKey (true).Key) {

            case ConsoleKey.RightArrow:
                x++;
                Update (x, y, drawing);
                break;
            case ConsoleKey.LeftArrow:
                x--;
                Update (x, y, drawing);
                break;
            case ConsoleKey.DownArrow:
                y++;
                Update (x, y, drawing);
                break;
            case ConsoleKey.UpArrow:
                y--;
                Update (x, y, drawing);
                break;

            case ConsoleKey.R:
                Console.BackgroundColor = ConsoleColor.Red;
                break;
            case ConsoleKey.G:
                Console.BackgroundColor = ConsoleColor.Green;
                break;
            case ConsoleKey.B:
                Console.BackgroundColor = ConsoleColor.Blue;
                break;
            case ConsoleKey.C:
                Console.BackgroundColor = ConsoleColor.Cyan;
                break;
            case ConsoleKey.M:
                Console.BackgroundColor = ConsoleColor.Magenta;
                break;
            case ConsoleKey.Y:
                Console.BackgroundColor = ConsoleColor.Yellow;
                break;
            case ConsoleKey.W:
                Console.BackgroundColor = ConsoleColor.White;
                break;
            case ConsoleKey.X:
                Console.BackgroundColor = ConsoleColor.Black;
                break;

            case ConsoleKey.Enter:
                drawing = !drawing;
                break;

            case ConsoleKey.Escape:
                Environment.Exit (0);
                break;
            }
        }
    }

    static void Update (int x, int y, bool drawing)
    {
        if (drawing)
            Console.Write (" ");
        Console.SetCursorPosition (x, y);
    }
}
