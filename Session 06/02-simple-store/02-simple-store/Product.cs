using System;

namespace Project
{
    public class Product
    {
        public string name;
        public double price;
        public int count;

        // Later on, after learning inheritance we'll be overriding ToString method instead.
        public string AsString()
        {
            return name + " (Price: " + price + "$, Count: " + count + ")";
        }
    }
}
