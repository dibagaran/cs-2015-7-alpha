using System;

namespace Project
{
    abstract class Contact
    {
        public string Phone{ get; set; }

        public string Address{ get; set; }

        public Contact (string phone, string address)
        {
            this.Phone = phone;
            this.Address = address;
        }
    }
}

