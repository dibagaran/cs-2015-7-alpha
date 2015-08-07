using System;

class Program
{
    public static void Main (string[] args)
    {
        var rectangle = new Rectangle (10, 20);
        var square = new Square (10);
        var unitSquare = new UnitSquare ();

        Console.WriteLine (rectangle.Area);
        Console.WriteLine (square.Area);
        Console.WriteLine (unitSquare.Area);
    }
}

class Rectangle{
    
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }
        
    public double Area{
        get{
            return this.Width * this.Height;
        }
    }
}

class Square : Rectangle{

    public Square(int dimension) : base(dimension, dimension)
    {
    }
}

class UnitSquare : Square{

    public UnitSquare() : base(1)
    {
    }
}