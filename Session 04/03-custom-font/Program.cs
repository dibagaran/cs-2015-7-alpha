using System;

class Program
{
    static void Main ()
    {

        /* Excercise:
            1. Create all character maps.
            2. Get a string input from the user and display it with your custom font.  */

        Console.CursorVisible = false;

        bool o = true, _ = false;

        bool[,]
        characterMapA = {
            { _, o, o, o, o, _ },
            { o, _, _, _, _, o },
            { o, _, _, _, _, o },
            { o, o, o, o, o, o },
            { o, _, _, _, _, o },
            { o, _, _, _, _, o },
            { o, _, _, _, _, o }
        },
        characterMapB = {
            { o, o, o, o, o, _ },
            { o, _, _, _, _, o },
            { o, _, _, _, _, o },
            { o, o, o, o, o, _ },
            { o, _, _, _, _, o },
            { o, _, _, _, _, o },
            { o, o, o, o, o, _ }
        },
        characterMapC = {
            { _, o, o, o, o, _ },
            { o, _, _, _, _, o },
            { o, _, _, _, _, _ },
            { o, _, _, _, _, _ },
            { o, _, _, _, _, _ },
            { o, _, _, _, _, o },
            { _, o, o, o, o, _ }
        },
        characterMapD = {
            { o, o, o, o, o, _ },
            { o, _, _, _, _, o },
            { o, _, _, _, _, o },
            { o, _, _, _, _, o },
            { o, _, _, _, _, o },
            { o, _, _, _, _, o },
            { o, o, o, o, o, _ }
        };

        while (true) {
            switch (Console.ReadKey (true).Key) {

            case ConsoleKey.A:
                DrawCharacter (characterMapA);
                break;
            case ConsoleKey.B:
                DrawCharacter (characterMapB);
                break;
            case ConsoleKey.C:
                DrawCharacter (characterMapC);
                break;
            case ConsoleKey.D:
                DrawCharacter (characterMapD);
                break;

            case ConsoleKey.Escape:
                return; //Application Exit
            }
        }
    }

    static void DrawCharacter (bool[,] characterMap)
    {
        Console.Clear ();

        for (int i = 0; i < characterMap.GetLength (0); i++) {
            for (int j = 0; j < characterMap.GetLength (1); j++)
                Console.Write (characterMap [i, j] ? "█" : " ");
            Console.WriteLine ();
        }
    }
}
