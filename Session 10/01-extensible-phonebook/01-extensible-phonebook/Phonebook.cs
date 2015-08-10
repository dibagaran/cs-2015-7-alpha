using System;

namespace Project
{
    static class Phonebook
    {
        private static Contact[] contacts = new Contact[1000];
        private static int current = 0;

        public static void Add (Contact contact)
        {
            contacts [current++] = contact;
        }

        public static string List {
            get {
                string list = "";
                for (int i = 0; i < current; i++)
                    list += contacts [i] + Environment.NewLine;
                return list;
            }
        }
    }
}

