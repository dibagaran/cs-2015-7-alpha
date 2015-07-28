using System;

namespace Project
{
    public class Store
    {
        private Product[] products = new Product[1000];
        private int currentProduct = 0;

        public bool AddProduct (string name, double price, int count)
        {
            //TODO: Check for any invalid input like empty product names, out of bound prices and so on.

            if (currentProduct < products.Length) {
                var product = new Product ();
                product.name = name;
                product.price = price;
                product.count = count;

                products [currentProduct++] = product;

                return true;
            } else
                return false;
        }

        private int IndexOf (string name)
        {
            for (int i = 0; i < currentProduct; i++)
                if (products [i].name == name)
                    return i;
            return -1;
        }

        public bool Trade (string name, int count)
        {
            //TODO: Look out for all the possible error conditions like selling a product which you don't have enough in the store.

            int index = IndexOf (name);

            if (index < 0)
                return false;

            products [index].count += count;
            return true;
        }

        public string Report ()
        {
            //TODO: Upgrade the report in a more fashionable and aesthetically appealing manner.

            string report = "";

            for (int i = 0; i < currentProduct; i++)
                report += (products[i].asString() + Environment.NewLine);

            return report;
        }
    }
}

