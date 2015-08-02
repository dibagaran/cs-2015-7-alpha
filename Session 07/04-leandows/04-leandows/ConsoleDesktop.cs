using System;

namespace Project
{
    public class ConsoleDesktop
    {
        //TODO: Upgrade the desktop to support more than one leandow at a time.
        //TODO: Upgrade the desktop to support themes.

        public ConsoleDesktop ()
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear ();
            Console.BackgroundColor = ConsoleColor.White;
        }

        public void Add (Leandow leandow)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition (leandow.Offset.Left, leandow.Offset
                .Top);
            Console.Write (leandow.Title);
            for (int j = 0; j < leandow.Size.Width - leandow.Title.Length; j++)
                Console.Write (" ");
            Console.WriteLine ();
            Console.BackgroundColor = ConsoleColor.White;

            for (int i = 0; i < leandow.Size.Height - 1; i++) {
                 Console.SetCursorPosition (leandow.Offset.Left, leandow.Offset.Top + i + 1);
                for (int j = 0; j < leandow.Size.Width; j++)
                    Console.Write (" ");
                Console.WriteLine ();
            }

            Console.ReadKey (true);
        }
    }
}

