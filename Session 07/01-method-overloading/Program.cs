using System;

class Program
{
    public static void Main (string[] args)
    {
        var rectangle = new Rectangle ();

        rectangle.SetSize (10, 15);

        Console.WriteLine (rectangle.AsString ());

        rectangle.SetSize (20);

        Console.WriteLine (rectangle.AsString ());
    }
}

class Rectangle
{
    private int width;
    private int height;

    // This method is overloaded by the next method.
    public void SetSize (int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void SetSize (int size)
    {
        this.width = this.height = size;
    }

    // Later on, after learning inheritance we'll be overriding ToString method instead.
    public string AsString ()
    {
        return "{ width: " + this.width + ", height: " + this.height + " }";
    }
}
