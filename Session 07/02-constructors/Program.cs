using System;

class Program
{
    public static void Main (string[] args)
    {
        var firstPerson = new Person ("Edward Witten", 63);
        var secondPerson = new Person ("Richard Feynman");
    }
}

class Person
{
    private string name;
    private int age;

    // The constructor can be overloaded just like a normal method.
    public Person (string name)
    {
        //The 'this' keyword referes to the current instance.
        this.name = name;
    }

    public Person (string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
