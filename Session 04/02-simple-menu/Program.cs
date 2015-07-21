using System;

class Program
{
    static void Main ()
    {

        /* Excercise:
            1. Try to add submenus and enable up and down arrow keys for navigation.
            2. Implement a confirm dialog for exit.  */

        string[] menuItems = { "File", "Edit", "View", "Tools", "Window", "Help" };
        int selectedIndex = -1;

        Console.CursorVisible = false;

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;

        for (; ;) {
            DrawMenu (menuItems, selectedIndex);

            Console.WriteLine ();

            switch (Console.ReadKey (true).Key) {
            case ConsoleKey.LeftArrow:
                selectedIndex = selectedIndex == 0 ? menuItems.Length - 1 : selectedIndex - 1;
                break;
            case ConsoleKey.RightArrow:
                selectedIndex = selectedIndex == menuItems.Length - 1 ? 0 : selectedIndex + 1;
                break;

            case ConsoleKey.Escape:
                Environment.Exit (0);
                break;
            }
        }
    }

    static void DrawMenu (string[] menuItems, int selectedItem)
    {
        Console.Clear ();

        for (int itemIndex = 0; itemIndex < menuItems.Length; itemIndex++) {
            if (itemIndex == selectedItem) {
                SwapColors ();
                Console.Write (" " + menuItems [itemIndex] + " ");
                SwapColors ();
            } else
                Console.Write (" " + menuItems [itemIndex] + " ");
        }
    }

    static void SwapColors ()
    {
        ConsoleColor originalBackgroundColor = Console.BackgroundColor;
        Console.BackgroundColor = Console.ForegroundColor;
        Console.ForegroundColor = originalBackgroundColor;
    }
}
