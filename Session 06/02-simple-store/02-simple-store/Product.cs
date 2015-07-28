using System;

namespace Project
{
    public class Product
    {
        public string name;
        public double price;
        public int count;

        public string asString() // Later on, after learning inheritance we'll be overriding toString method instead.
        {
            return name + " (Price: " + price + "$, Count: " + count + ")";
        }
    }
}
