using System;

namespace Project
{
    public class Application
    {
        //TODO: Upgrade the UI and enable simple theming capabilities in your application.
        //TODO: Implement a multilingual user interface.

        private Store store = new Store ();

        private string[] menuItems = { "Add Product", "Buy", "Sell", "Report", "Exit" };

        public void Run ()
        {
            while (true)
                Process (Menu ());
        }

        private ConsoleKey Menu ()
        {
            Console.Clear ();
            for (int i = 0; i < menuItems.Length; i++)
                Console.WriteLine ((i + 1) + ". " + menuItems [i]);

            return Console.ReadKey (true).Key;
        }

        private void Process (ConsoleKey key)
        {
            Console.Clear ();

            switch (key) {
            case ConsoleKey.NumPad1:
            case ConsoleKey.D1:

                if (store.AddProduct (GetString ("Product Name"), GetDouble ("Product Price"), GetInt32 ("Product Count")))
                    Console.WriteLine ("Product added.");
                else
                    Console.WriteLine ("Store is full!");

                break;

            case ConsoleKey.NumPad2:
            case ConsoleKey.D2:
            case ConsoleKey.NumPad3:
            case ConsoleKey.D3:

                bool buy = key == ConsoleKey.NumPad2 || key == ConsoleKey.D2;
                
                if (store.Trade (GetString ("Product Name"), (buy ? 1 : -1) * GetInt32 ("Count")))
                    Console.WriteLine ("Transaction completed."); //TODO: Display the total price too.
                else
                    Console.WriteLine ("Product not found.");
                
                break;

            case ConsoleKey.NumPad4:
            case ConsoleKey.D4:

                string report = store.Report ();
                Console.WriteLine (report == "" ? "No products found." : report);

                break;

            case ConsoleKey.NumPad5:
            case ConsoleKey.D5:

                //TODO: Add a confirmation dialog.

                Environment.Exit (0);

                break;

            default:
                
                Console.WriteLine ("Invalid Choice!");

                break;
            }

            Console.ReadKey (true);
        }

        private string GetString (string param)
        {
            Console.Write ("Please enter '" + param + "': ");
            return Console.ReadLine ();
        }

        private int GetInt32 (string param)
        {
            return Convert.ToInt32 (GetString (param));
        }

        private double GetDouble (string param)
        {
            return Convert.ToDouble (GetString (param));
        }
    }
}

