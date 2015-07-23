using System;

class Program
{
    static void Main()
    {
        var i = new Person (); // or Person i = new Person();
        var j = i; // Like arrays, all objects are reference types so i and j are references to the same object.

        var k = new Person (); // k is another instance of Person class.
    }
}

class Person{
    string name;
    int age;

    void DoRight()
    {
    }

    void DoWrong()
    {
    }
}
