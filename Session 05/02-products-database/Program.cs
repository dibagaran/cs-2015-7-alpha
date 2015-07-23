using System;

class Program
{
    static void Main ()
    {
        /* Excercise: Reorganize this program using methods and apply as much optimizations as you can. */

        var menu = new string[] {
            "Add Product",
            "List Products",
            "Exit"
        };
        var selectedMenuItem = 0;

        var maximumProductsCount = 1000000;
        var productNames = new string[maximumProductsCount];
        var productPrices = new double[maximumProductsCount];
        var currentProduct = 0;

        Console.CursorVisible = false;

        for (;;) {
            Console.Clear ();
            for (int index = 0; index < menu.Length; index++) {
                if (index == selectedMenuItem) {
                    var originalBackgroundColor = Console.BackgroundColor;
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = originalBackgroundColor;
                    Console.WriteLine (menu [index]);
                    Console.ForegroundColor = Console.BackgroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                } else
                    Console.WriteLine (menu [index]);
            }

            switch (Console.ReadKey (true).Key) {
            case ConsoleKey.DownArrow:
                selectedMenuItem = selectedMenuItem == menu.Length - 1 ? 0 : selectedMenuItem + 1;
                break;
            case ConsoleKey.UpArrow:
                selectedMenuItem = selectedMenuItem == 0 ? menu.Length - 1 : selectedMenuItem - 1;
                break;
            case ConsoleKey.Enter:
                Console.Clear ();
                switch (selectedMenuItem) {
                case 0:
                    if (currentProduct < productNames.Length) {
                        Console.CursorVisible = true;
                        Console.Write ("Product Name: ");
                        productNames [currentProduct] = Console.ReadLine ();
                        Console.Write ("Product Price: ");
                        productPrices [currentProduct++] = Convert.ToDouble (Console.ReadLine ());
                        Console.CursorVisible = false;
                        var originalForegroundColor = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine ("New product added successfully.");
                        Console.ForegroundColor = originalForegroundColor;
                    } else
                        Console.WriteLine ("Program memory is full.");
                    break;
                case 1:
                    if (currentProduct > 0)
                        for (int i = 0; i < currentProduct; i++)
                            Console.WriteLine ((i + 1) + ". " + productNames [i] + " (" + productPrices [i] + "$)");
                    else
                        Console.WriteLine ("Program memory is empty.");
                    break;
                case 2:
                    return;
                }
                Console.ReadKey (true);
                break;
            }
        }
    }
}
