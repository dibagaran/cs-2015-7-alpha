using System;

namespace Project
{
    class Person : Contact
    {
        public string FirstName{ get; set; }

        public string LastName{ get; set; }

        public Person (string firstName, string lastName, string phone, string address) : base (phone, address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString ()
        {
            return "Person:  [First Name: " + this.FirstName + ", Last Name: " + this.LastName + ", Phone: " + this.Phone + ", Address: " + this.Address + "]";
        }
    }
}

