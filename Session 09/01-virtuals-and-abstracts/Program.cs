using System;

namespace Project
{
    class Program
    {
        public static void Main (string[] args)
        {
            //TODO: Analyze the code repeatedly to fully understand all the OOP concepts used in it.

            var shapes = new Shape[] {
                new Rectangle (5, 2.5),
                new Square (10),
                new UnitSquare (),
                new Ellipse (11.2, 27.75),
                new Circle (15.6)
            };

            for (int i = 0; i < shapes.Length; i++)
                Console.WriteLine (shapes [i]);
        }
    }

    abstract class Shape
    {
        public abstract string Name { get; }

        public double Width { get; set; }

        public double Height { get; set; }

        public Shape (double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double Area {
            get {
                return this.Width * this.Height;
            }
        }

        public override string ToString ()
        {
            return this.Name + " [Width:" + this.Width + ", Height:" + this.Height + ", Area:" + this.Area + "]";
        }
    }

    class Rectangle : Shape
    {
        public override string Name {
            get {
                return "Rectangle";
            }
        }

        public Rectangle (double width, double height) : base (width, height)
        {
        }
    }

    class Square : Rectangle
    {
        public override string Name {
            get {
                return "Square";
            }
        }

        public Square (double dimension) : base (dimension, dimension)
        {
        }
    }

    sealed class UnitSquare : Square
    {
        public override string Name {
            get {
                return "Unit Square";
            }
        }

        public UnitSquare () : base (1)
        {
        }
    }

    class Ellipse : Shape
    {
        public override string Name {
            get {
                return "Ellipse";
            }
        }

        public double MajorDiameter{
            get{
                return Math.Max (this.Width, this.Height);
            }
        }

        public double MinorDiameter{
            get{
                return Math.Min (this.Width, this.Height);
            }
        }

        public Ellipse (double majorDiameter, double minorDiameter) : base (majorDiameter, minorDiameter)
        {
        }

        public override double Area {
            get {
                return Math.PI * this.Width / 2 * this.Height / 2;
            }
        }

        public override string ToString ()
        {
            return this.Name + " [MajorDiameter:" + this.MajorDiameter + ", MinorDiameter:" + this.MinorDiameter + ", Area:" + this.Area + "]";
        }
    }

    sealed class Circle : Ellipse
    {
        public override string Name {
            get {
                return "Circle";
            }
        }

        public double Radius{
            get{
                return this.Width / 2;
            }
        }

        public Circle (double radius) : base (radius * 2, radius * 2)
        {
        }

        public override string ToString ()
        {
            return this.Name + " [Radius:" + this.Width / 2 + ", Area:" + this.Area + "]";
        }
    }
}
