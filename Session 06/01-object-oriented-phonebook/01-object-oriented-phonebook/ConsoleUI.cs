using System;

namespace Project
{
    public class ConsoleUI
    {
        private Phonebook phonebook = new Phonebook ();
        private string[] menuItems = { "Add Contact", "Remove Contact", "Search", "List All Contacts", "Exit" };

        public void Run ()
        {
            while (true) {
                Process (Menu ());
                Console.ReadKey (true);
            }
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
                int result = phonebook.AddContact (GetString ("Name"), GetInt32 ("Phone"));

                switch (result) {
                case 0:
                    Console.WriteLine ("New contact added.");
                    break;
                case -1:
                    Console.WriteLine ("Name is required.");
                    break;
                case -2:
                    Console.WriteLine ("Phone number is not valid.");
                    break;
                case -3:
                    Console.WriteLine ("Contact already exists.");
                    break;
                case -4:
                    Console.WriteLine ("Phonebook is full.");
                    break;
                default:
                    Console.WriteLine ("Unknown error.");
                    break;
                }

                break;
            case ConsoleKey.NumPad2:
            case ConsoleKey.D2:
                if (phonebook.removeContact (GetString ("Name")))
                    Console.WriteLine ("Contact removed.");
                else
                    Console.WriteLine ("Contact not found!");
                break;
            case ConsoleKey.NumPad3:
            case ConsoleKey.D3:
                int searchResult = phonebook.Search (GetString ("Name"));
                if (searchResult == -1)
                    Console.WriteLine ("Contact not found.");
                else
                    Console.WriteLine (searchResult);
                break;
            case ConsoleKey.NumPad4:
            case ConsoleKey.D4:
                string list = phonebook.List ();
                if (list != "")
                    Console.Write (phonebook.List ());
                else
                    Console.WriteLine ("Phonebook is empty!");
                break;
            case ConsoleKey.NumPad5:
            case ConsoleKey.D5:
                Environment.Exit (0);
                break;
            default:
                Console.WriteLine ("Invalid choice!");
                break;
            }
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
    }
}

