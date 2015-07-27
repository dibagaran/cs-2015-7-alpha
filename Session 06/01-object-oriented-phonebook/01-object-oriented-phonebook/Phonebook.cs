using System;

namespace Project
{
    public class Phonebook
    {
        private Contact[] contacts = new Contact[1000];
        private int currentContact = 0;

        public int AddContact (string name, int phone)
        {
            if (name == "")
                return -1;

            if (phone <= 0)
                return -2;
            
            if (IndexOf (name) < 0) {
                if (currentContact < contacts.Length) {
                    var contact = new Contact ();
                    contact.name = name;
                    contact.phone = phone;
                    contacts [currentContact++] = contact;
                    return 0;
                } else
                    return -4;
            }

            return -3;
        }

        private int IndexOf (string name)
        {
            for (int i = 0; i < currentContact; i++)
                if (contacts [i].name == name)
                    return i;
            
            return -1;
        }

        public bool removeContact (string name)
        {
            int index = IndexOf (name);

            if (index < 0)
                return false;

            for (int i = index; i < currentContact; i++)
                contacts [i] = contacts [i + 1];
            currentContact--;

            return true;
        }

        public int Search (string name)
        {
            int index = IndexOf (name);
            return index < 0 ? -1 : contacts [index].phone;
        }

        public string List ()
        {
            string report = "";
            for (int i = 0; i < currentContact; i++)
                report += (contacts [i].name + ", " + contacts [i].phone + Environment.NewLine);
            return report;
        }
    }
}

