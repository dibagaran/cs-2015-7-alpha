using System;

class Program
{
    public static void Main (string[] args)
    {
        var person = new Person ();

        person.Name = "Edward Witten";
        person.Age = 63;
        person.Nationality = "American";

        Console.WriteLine (person.Name);
        Console.WriteLine (person.Age);
        Console.WriteLine (person.Nationality);
    }
}

class Person
{
    private string name; // Backing Field
    public string Name { // Property
        get {
            return this.name;
        }
        set {
            if (value.Length < 100)
                this.name = value;
        }
    }

    private int age;
    public int Age {
        get {
            return this.age;
        }
        set {
            if (value > 0 && value < 120)
                this.age = value;
        }
    }

    // Auto-Implemented Property
    public string Nationality{ get; set; }
}
