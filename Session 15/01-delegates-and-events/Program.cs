using System;

class Program
{
    public static void Main ()
    {
        var store = new Store ();

        //Handling the event
        store.ProductAdded += OnProductAdded;

        store.Add (new Product ());
    }

    static void OnProductAdded ()
    {
        Console.WriteLine ("A new product has been added.");
    }
}

class Store
{
    public delegate void ProductHandler ();
    public event ProductHandler ProductAdded;

    private Product[] products = new Product[1000];
    private int current = 0;

    public void Add (Product product)
    {
        products [current++] = product;

        //Raising or firing the event
        if (ProductAdded != null)
            ProductAdded ();
    }
}

class Product
{
}
