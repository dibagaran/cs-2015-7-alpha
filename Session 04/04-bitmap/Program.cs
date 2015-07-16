using System;

class Program
{
    static void Main ()
    {
        int[,] bitmap = {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 8, 8, 8, 8, 8, 0, 0, 0, 0 },
            { 0, 0, 0, 8, 8, 8, 8, 8, 8, 8, 0, 0, 0 },
            { 0, 0, 8, 2, 2, 8, 2, 2, 8, 8, 8, 0, 0 },
            { 0, 0, 2, 1, 0, 2, 1, 0, 2, 1, 1, 0, 0 },
            { 0, 0, 2, 0, 0, 2, 0, 0, 2, 1, 1, 0, 0 },
            { 0, 0, 8, 2, 2, 8, 2, 2, 8, 8, 8, 0, 0 },
            { 0, 0, 8, 8, 8, 8, 8, 8, 8, 8, 8, 0, 0 },
            { 0, 0, 8, 8, 8, 8, 8, 1, 8, 8, 8, 0, 0 },
            { 0, 0, 8, 8, 1, 1, 1, 8, 8, 8, 8, 0, 0 },
            { 0, 0, 5, 8, 8, 8, 8, 8, 8, 8, 5, 0, 0 },
            { 0, 0, 8, 5, 5, 5, 5, 5, 5, 5, 8, 0, 0 },
            { 0, 0, 8, 8, 5, 5, 5, 5, 5, 8, 8, 0, 0 },
            { 0, 0, 8, 8, 5, 5, 5, 5, 5, 8, 8, 0, 0 },
            { 0, 0, 8, 5, 5, 5, 5, 5, 5, 5, 8, 0, 0 },
            { 0, 1, 1, 5, 5, 5, 5, 5, 5, 5, 1, 1, 0 },
            { 0, 0, 1, 5, 5, 5, 5, 5, 5, 5, 1, 0, 0 },
            { 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        };

        for (int i = 0; i < bitmap.GetLength (0); i++) {
            for (int j = 0; j < bitmap.GetLength (1); j++) {

                switch (bitmap [i, j]) {
                case 0:
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case 1:
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case 7:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case 8:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                }

                Console.Write ("  ");
            }

            Console.WriteLine ();
        }
    }
}
