using System;

namespace Project
{
    static class UI
    {
        private static string[] menuItems = { "Add New Contact", "List All Contacts", "Exit" };

        public static void Run ()
        {
            for (;;) {
                Console.Clear ();
                DisplayMenu ();
                ConsoleKey key = Console.ReadKey (true).Key;
                Console.Clear ();
                Process (key);
                Console.ReadKey (true);
            }
        }

        private static void DisplayMenu ()
        {
            for (int i = 0; i < menuItems.Length; i++)
                Console.WriteLine ((i + 1) + ": " + menuItems [i]);
        }

        private static void Process (ConsoleKey key)
        {
            switch (key) {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                
                Console.WriteLine ("Person or Company (p/c)? ");

                /*

                bool isPerson = Console.ReadKey (true).Key != ConsoleKey.C;

                Contact contact = null;

                string phone = Get ("Phone Number");
                string address = Get ("Address");

                if (isPerson) {
                    string firstName = Get ("First Name");
                    string lastName = Get ("Last Name");
                    contact = new Person (firstName, lastName, phone, address);
                } else {
                    string title = Get ("Title");
                    contact = new Company (title, phone, address);
                }

                Phonebook.Add (contact);
                
                */


                //TODO: This single long line of code is equivalent to all the commented codes above. Analyze and try to understand it carefully.
                Phonebook.Add (Console.ReadKey (true).Key != ConsoleKey.C ? (Contact) new Person (Get ("First Name"), Get ("Last Name"), Get ("Phone Number"), Get ("Address")) : new Company (Get ("Title"), Get ("Phone Number"), Get ("Address")));

                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:

                Console.WriteLine (Phonebook.List);

                break;
            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                
                Environment.Exit (0);

                break;
            }   
        }

        private static string Get (string param)
        {
            Console.Write (param + "? ");
            return Console.ReadLine ();
        }
    }
}

