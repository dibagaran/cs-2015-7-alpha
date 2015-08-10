using System;

namespace Project
{
    class Company : Contact
    {
        public string Title{ get; set; }

        public Company (string title, string phone, string address) : base (phone, address)
        {
            this.Title = title;
        }

        public override string ToString ()
        {
            return "Company: [Title: " + this.Title + ", Phone: " + this.Phone + ", Address: " + this.Address + "]";
        }
    }
}

