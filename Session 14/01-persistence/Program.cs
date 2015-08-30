using System;
using System.IO;

class Program
{
    public static void Main ()
    {
        //TODO: Create an application with UI and everything for this simple binary object storage.

        Product[] products = { 
            new Product{ Name = "Product 1", Price = 1000, Count = 10 },
            new Product{ Name = "Product 2", Price = 1500, Count = 20 },
            new Product{ Name = "Product 3", Price = 2000, Count = 30 },
            new Product{ Name = "Product 4", Price = 2500, Count = 40 }
        };

        var path = "Data.bin";

        Save (path, products);

        products = Load (path);

        for (int i = 0; i < products.Length; i++)
            Console.WriteLine (products [i]);
    }

    //Serialization
    static void Save (string path, Product[] products)
    {
        try {
            using (var stream = new FileStream (path, FileMode.Create, FileAccess.Write))
            using (var writer = new BinaryWriter (stream)) {
                writer.Write (products.Length);
                for (int i = 0; i < products.Length; i++) {
                    writer.Write (products [i].Name);
                    writer.Write (products [i].Price);
                    writer.Write (products [i].Count);
                }
            }
        } catch (IOException ex) {
            Console.WriteLine (ex.Message);
        }
    }

    //Deserialization
    static Product[] Load (string path)
    {
        Product[] products = null;
        try {
            using (var stream = new FileStream (path, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader (stream)) {
                products = new Product[reader.ReadInt32 ()];
                for (int i = 0; i < products.Length; i++) {
                    var name = reader.ReadString ();
                    var price = reader.ReadSingle ();
                    var count = reader.ReadInt32 ();
                    products [i] = new Product{ Name = name, Price = price, Count = count };
                }
            }
        } catch (IOException ex) {
            Console.WriteLine (ex.Message);
        }
        return products;
    }
}

class Product
{
    public string Name { get; set; }

    public float Price { get; set; }

    public int Count { get; set; }

    public override string ToString ()
    {
        return Name + " (x" + Count + "), " + Price + "$ each";
    }
}
